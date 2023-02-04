using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

using YamlDotNet.Serialization;

namespace RTSystemBuilder {
  public class GitHubWrapper {
    private string token_;
    private string user_id_;

    public GitHubWrapper(string user_id, string token) {
      this.user_id_ = user_id;
      this.token_ = token;
    }
    public void setUserInfo(string user_id, string token) {
      this.user_id_ = user_id;
      this.token_ = token;
    }
    public bool checkRepositoryExists(string target, string name) {
      string targetUri = "https://api.github.com/repos/" + target + "/" + name;
      try {
        string content = sendGetRequest(targetUri);
      } catch {
        return false;
      }
      return true;
    }
    public bool getCommitsList(string target, out List<CommitInfo> result) {
      string targetUri = "https://api.github.com/repos/" + target + "/commits";
      try {
        string content = sendGetRequest(targetUri);
        result = JSONUtil.Deserialize<List<CommitInfo>>(content);

      } catch (WebException ex) {
        result = new List<CommitInfo>();
        return false;
      }
      return true;
    }
    public bool getContentsList(string target, out List<ContentsInfo> result) {
      string targetUri = "https://api.github.com/repos/" + target + "/contents";
      try {
        string content = sendGetRequest(targetUri);
        result = JSONUtil.Deserialize<List<ContentsInfo>>(content);

      } catch (WebException ex) {
        result = new List<ContentsInfo>();
        return false;
      }
      return true;
    }
    public bool getContentsList(string target, string path, out List<ContentsInfo> result) {
      string targetUri = "https://api.github.com/repos/" + target + "/contents/" + path;
      try {
        string content = sendGetRequest(targetUri);
        result = JSONUtil.Deserialize<List<ContentsInfo>>(content);

      } catch (WebException ex) {
        result = new List<ContentsInfo>();
        return false;
      }
      return true;
    }
    public bool getRTCProfile(string target, out string result) {
      bool ret = getFile(target, "RTC.xml", out result);
      return ret;
    }
    public bool getFile(string target, string file, out string result) {
      result = "";
      string targetUri = "https://api.github.com/repos/" + target + "/contents/" + file; 
      try {
        string content = sendGetRequest(targetUri);
        ContentsInfo retInfo = JSONUtil.Deserialize<ContentsInfo>(content);

        Encoding enc = Encoding.GetEncoding("UTF-8");
        result = enc.GetString(Convert.FromBase64String(retInfo.content));
      } catch (WebException ex) {
        result = "";
        return false;
      }
      return true;
    }
    public bool getSystemProfile(string target, out List<SystemContentsInfo> result, out string sha) {
      result = new List<SystemContentsInfo>();
      sha = "";
      string targetUri = "https://api.github.com/repos/" + target + "/contents/packages";
      try {
        string content = sendGetRequest(targetUri);
        List<SystemPackageInfo> retInfo = JSONUtil.Deserialize<List<SystemPackageInfo>>(content);
        SystemPackageInfo sysElem = retInfo.FirstOrDefault(c => c.name == "system.yaml");
        if (sysElem == null) return false;
        sha = sysElem.sha;

        string contentSys = sendGetRequest(sysElem.download_url);
        Deserializer deser = new Deserializer();
        Dictionary<string, SystemContentsInfo> sysDef = deser.Deserialize<Dictionary<string, SystemContentsInfo>>(contentSys);

        foreach(string each in sysDef.Keys) {
          SystemContentsInfo info = sysDef[each];
          info.name = each;
          result.Add(info);
        }
      } catch (WebException ex) {
        result = new List<SystemContentsInfo>();
        return false;
      }
      return true;
    }
    public bool addRepository(string target, string name) {
      string targetUri;
      if (target == this.user_id_) {
        targetUri = "https://api.github.com/user/repos";
      } else {
        targetUri = "https://api.github.com/orgs/" + target + "/repos";
      }

      AddRepositoryInfo param = new AddRepositoryInfo();
      param.name = name;
      param.auto_init = true;
      param.@private = false;
      string param_contents = JSONUtil.Serialize(param);

      try {
        string result = sendPostRequest(targetUri, param_contents);
      } catch (WebException ex) {
        return false;
      }

      return true;
    }
    public bool updateSystemProfile(string target, string contents) {
      string targetUri = "https://api.github.com/repos/" + target + "/contents/packages/system.yaml";
      try {
        sendPutRequest(targetUri, contents);
      } catch (WebException ex) {
        return false;
      }
      return true;
    }

    public bool updateContents(string target, string repo, string path, string contents, string message) {
      string checkUri = "https://api.github.com/repos/" + target + "/" + repo + "/contents/" + path;

      string strSha = "";
      try {
        string content = sendGetRequest(checkUri);
        CommitInfo retInfo = JSONUtil.Deserialize<CommitInfo>(content);
        strSha = retInfo.sha;
      } catch {
      }

      Encoding enc = Encoding.GetEncoding("UTF-8");
      string base64cont = Convert.ToBase64String(enc.GetBytes(contents));

      UpdateContentsInfo param = new UpdateContentsInfo();
      param.message = message;
      param.sha = strSha;
      param.content = base64cont;
      string param_contents = JSONUtil.Serialize(param);

      string targetUri = "https://api.github.com/repos/" + target + "/" + repo + "/contents/" + path;
      try {
        sendPutRequest(targetUri, param_contents);
      } catch (WebException ex) {
        return false;
      }
      return true;
    }
    public bool getRepositoryList(string target, out List<OrgRepositoryInfo> retInfo) {
      string targetUri;
      if (target == this.user_id_) {
        targetUri = "https://api.github.com/user/repos?per_page=100&sort='updated'";
      } else {
        targetUri = "https://api.github.com/orgs/" + target + "/repos?per_page=100&sort='pushed'";
      }

      try {
        string content = sendGetRequest(targetUri);
        retInfo = JSONUtil.Deserialize<List<OrgRepositoryInfo>>(content);
      } catch {
        retInfo = new List<OrgRepositoryInfo>();
        return false;
      }

      return true;
    }

    //////////
    private string sendGetRequest(string targetUri) {
      string result = "";

      HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(targetUri);
      httpRequest.Method = "GET";
      httpRequest.ContentType = "application/vnd.github+json";
      httpRequest.UserAgent = "CompDBApp";
      httpRequest.Headers["Authorization"] = "Bearer " + token_;
      httpRequest.Headers.Add("X-GitHub-Api-Version", "2022-11-28");

      var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
      Stream responseStream = httpResponse.GetResponseStream();
      StreamReader reader = new StreamReader(responseStream);
      result = reader.ReadToEnd();

      return result;
    }
    private string sendPutRequest(string targetUri, string targetData) {
      string result = "";

      HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(targetUri);
      httpRequest.Method = "PUT";
      httpRequest.ContentType = "application/json";
      httpRequest.UserAgent = "CompDBApp";
      httpRequest.Headers["Authorization"] = "Bearer " + token_;
      httpRequest.Headers.Add("X-GitHub-Api-Version", "2022-11-28");

      byte[] byteArray = Encoding.UTF8.GetBytes(targetData);
      httpRequest.ContentLength = byteArray.Length;
      using (var dataStream = httpRequest.GetRequestStream()) {
        dataStream.Write(byteArray, 0, byteArray.Length);
      }

      var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
      Stream responseStream = httpResponse.GetResponseStream();
      StreamReader reader = new StreamReader(responseStream);
      result = reader.ReadToEnd();

      return result;
    }
    private string sendPostRequest(string targetUri, string targetData) {
      string result = "";

      HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(targetUri);
      httpRequest.Method = "POST";
      httpRequest.ContentType = "application/vnd.github+json";
      httpRequest.UserAgent = "CompDBApp";
      httpRequest.Headers["Authorization"] = "Bearer " + token_;
      httpRequest.Headers.Add("X-GitHub-Api-Version", "2022-11-28");

      byte[] byteArray = Encoding.UTF8.GetBytes(targetData);
      httpRequest.ContentLength = byteArray.Length;
      using (var dataStream = httpRequest.GetRequestStream()) {
        dataStream.Write(byteArray, 0, byteArray.Length);
      }

      var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
      Stream responseStream = httpResponse.GetResponseStream();
      StreamReader reader = new StreamReader(responseStream);
      result = reader.ReadToEnd();

      return result;
    }
  }
}
