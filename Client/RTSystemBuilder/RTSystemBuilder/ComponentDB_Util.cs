using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Configuration;

using System.Xml;
using System.Xml.Linq;

namespace RTSystemBuilder {
  public class CompDb_Util {
    public static string getLangTypeName(uint index) {
      switch (index) {
        case CompDB_Const.LANG_CPP: return "C++";
        case CompDB_Const.LANG_PYTHON: return "Python";
        case CompDB_Const.LANG_JAVA: return "Java";
        default: return "";
      }
    }
    public static string getIfDirection(uint index) {
      switch (index) {
        case CompDB_Const.SP_PROVIDED: return "Provided";
        case CompDB_Const.SP_REQUIRED: return "Required";
        default: return "";
      }
    }
    public static bool getSettingValue(out string ipAddress, out int portNo,
                                        out string userId, out string token,
                                        out List<string> baseRepos, out List<string> wasanbonRepos) {
      ipAddress = "localhost";
      portNo = 50000;
      userId = "";
      token = "";
      baseRepos = new List<string>();
      wasanbonRepos = new List<string>();

      var configFile = @"RTSystemBuilderClient.config";
      try {
        var exeFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
        var config = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None);
        if (config.AppSettings.Settings.Count == 0) {
          config.AppSettings.Settings.Add("ServerIP", "localhost");
          config.AppSettings.Settings.Add("ServerPort", "50201");
          config.AppSettings.Settings.Add("UserId", "");
          config.AppSettings.Settings.Add("AccessToken", "");
          config.AppSettings.Settings.Add("BaseRepository", "");
          config.AppSettings.Settings.Add("WasanbonRepository", "");

          config.Save();

        } else {
          if (config.AppSettings.Settings.AllKeys.Contains("ServerIP")) {
            ipAddress = config.AppSettings.Settings["ServerIP"].Value;
          }

          if (config.AppSettings.Settings.AllKeys.Contains("ServerPort")) {
            var serverPortStr = config.AppSettings.Settings["ServerPort"].Value;
            int.TryParse(serverPortStr, out portNo);
          }

          if (config.AppSettings.Settings.AllKeys.Contains("UserId")) {
            userId = config.AppSettings.Settings["UserId"].Value;
          }

          if (config.AppSettings.Settings.AllKeys.Contains("AccessToken")) {
            token = config.AppSettings.Settings["AccessToken"].Value;
          }

          if (config.AppSettings.Settings.AllKeys.Contains("BaseRepository")) {
            string baseRepo = config.AppSettings.Settings["BaseRepository"].Value;
            if (baseRepo != null && 0 < baseRepo.Length) {
              string[] elems = baseRepo.Split('|');
              foreach (string each in elems) {
                if (elems.Length == 0) continue;
                baseRepos.Add(each);
              }
            }
          }

          if (config.AppSettings.Settings.AllKeys.Contains("WasanbonRepository")) {
            string baseRepo = config.AppSettings.Settings["WasanbonRepository"].Value;
            if (baseRepo != null && 0 < baseRepo.Length) {
              string[] elems = baseRepo.Split('|');
              foreach (string each in elems) {
                if (elems.Length == 0) continue;
                wasanbonRepos.Add(each);
              }
            }
          }
        }
      } catch {
        return true;
      }
      return true;
    }
    public static bool getSystemRepositories(out List<string> baseRepos) {
      baseRepos = new List<string>();

      var configFile = @"RTSystemBuilderClient.config";
      try {
        var exeFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
        var config = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None);
          if (config.AppSettings.Settings.AllKeys.Contains("BaseRepository")) {
            string baseRepo = config.AppSettings.Settings["BaseRepository"].Value;
            if (baseRepo != null && 0 < baseRepo.Length) {
              string[] elems = baseRepo.Split('|');
              foreach (string each in elems) {
                if (elems.Length == 0) continue;
                baseRepos.Add(each);
              }
            }
          }
      } catch {
        return true;
      }
      return true;
    }
    public static bool getWasanbonRepositories(out List<string> wasanbonRepos) {
      wasanbonRepos = new List<string>();

      var configFile = @"RTSystemBuilderClient.config";
      try {
        var exeFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
        var config = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None);
        if (config.AppSettings.Settings.AllKeys.Contains("WasanbonRepository")) {
          string baseRepo = config.AppSettings.Settings["WasanbonRepository"].Value;
          if (baseRepo != null && 0 < baseRepo.Length) {
            string[] elems = baseRepo.Split('|');
            foreach (string each in elems) {
              if (elems.Length == 0) continue;
              wasanbonRepos.Add(each);
            }
          }
        }
      } catch {
        return true;
      }
      return true;
    }
    public static CompAppInfo parseXML(XElement root) {
      XNamespace nsRtc = "http://www.openrtp.org/namespaces/rtc";

      XElement rtcElem = root.Descendants(nsRtc + "BasicInfo").First();
      string compName = rtcElem.Attribute(nsRtc + "name").Value;
      string category = rtcElem.Attribute(nsRtc + "category").Value;
      string vendor = rtcElem.Attribute(nsRtc + "vendor").Value;

      XElement langElem = root.Descendants(nsRtc + "Language").First();
      string lang = langElem.Attribute(nsRtc + "kind").Value;

      uint langType = 0;
      if (lang.ToLower() == "c++") {
        langType = CompDB_Const.LANG_CPP;
      } else if (lang.ToLower() == "python") {
        langType = CompDB_Const.LANG_PYTHON;
      } else if (lang.ToLower() == "java") {
        langType = CompDB_Const.LANG_JAVA;
      }

      CompAppInfo result = new CompAppInfo();
      result.ComponentName = compName;
      result.Category = category;
      result.Vendor = vendor;
      result.Language = langType;

      //
      result.DataPorts = new List<DataPortAppInfo>();
      IEnumerable<XElement> dataPorts = root.Descendants(nsRtc + "DataPorts");
      foreach (XElement info in dataPorts) {
        string name = info.Attribute(nsRtc + "name").Value;
        string type = info.Attribute(nsRtc + "type").Value;
        string portType = info.Attribute(nsRtc + "portType").Value;

        uint direction = 0;
        if (portType.ToLower().Trim() == "datainport") {
          direction = CompDB_Const.DP_IN;
        } else if (portType.ToLower().Trim() == "dataoutport") {
          direction = CompDB_Const.DP_OUT;
        }

        DataPortAppInfo port = new DataPortAppInfo();
        port.Name = name;
        port.Type = type;
        port.Direction = direction;
        result.DataPorts.Add(port);
      }
      //
      result.ServicePorts = new List<ServicePortAppInfo>();
      IEnumerable<XElement> servicePorts = root.Descendants(nsRtc + "ServicePorts");
      foreach (XElement info in servicePorts) {
        string name = info.Attribute(nsRtc + "name").Value;
        ServicePortAppInfo port = new ServicePortAppInfo();
        port.Name = name;
        port.Interfaces = new List<ServiceInterfaceAppInfo>();
        IEnumerable<XElement> serviceIfs = info.Descendants(nsRtc + "ServiceInterface");
        foreach (XElement infoIf in serviceIfs) {
          string ifname = infoIf.Attribute(nsRtc + "name").Value;
          string direction = infoIf.Attribute(nsRtc + "direction").Value;
          string ifType = infoIf.Attribute(nsRtc + "type").Value;

          uint ifDir = 0;
          if (direction.ToLower().Trim() == "provided") {
            ifDir = CompDB_Const.SP_PROVIDED;
          } else if (direction.ToLower().Trim() == "required") {
            ifDir = CompDB_Const.SP_REQUIRED;
          }

          ServiceInterfaceAppInfo ifInfo = new ServiceInterfaceAppInfo();
          ifInfo.Name = ifname;
          ifInfo.InterfacerType = ifType;
          ifInfo.Direction = ifDir;
          port.Interfaces.Add(ifInfo);
        }
        result.ServicePorts.Add(port);
      }
      return result;
    }
  }

  public class JSONUtil {
    public static string Serialize<Type>(Type source) {
      string result = "";
      using (var stream = new MemoryStream()) {
        var serializer = new DataContractJsonSerializer(typeof(Type));
        serializer.WriteObject(stream, source);
        result = Encoding.UTF8.GetString(stream.ToArray());
      }
      return result;
    }

    public static T Deserialize<T>(string message) {
      using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(message))) {
        var serializer = new DataContractJsonSerializer(typeof(T));
        return (T)serializer.ReadObject(stream);
      }
    }
  }

  public class ComponentSearchCondition {
    public List<string> Names { set; get; }
    public bool OrNames { set; get; }
    public List<string> Categories { set; get; }
    public bool OrCatregories { set; get; }
    public List<string> Vendors { set; get; }
    public bool OrVendors { set; get; }
    public List<uint> Langiages { set; get; }
    public List<string> Comments { set; get; }
    public bool OrComments { set; get; }
    public List<string> DataPortTypes { set; get; }
    public bool OrDataPortTypes { set; get; }
    public List<uint> DataPortDirections { set; get; }
    public List<string> ServiceInterfaceTypes { set; get; }
    public bool OrServiceInterfaceTypes { set; get; }
    public List<uint> ServiceInterfaceDirections { set; get; }

    public ComponentSearchCondition() {
      this.Names = new List<string>();
      this.Categories = new List<string>();
      this.Vendors = new List<string>();
      this.Langiages = new List<uint>();
      this.Comments = new List<string>();

      this.DataPortTypes = new List<string>();
      this.DataPortDirections = new List<uint>();
      this.ServiceInterfaceTypes = new List<string>();
      this.ServiceInterfaceDirections = new List<uint>();
    }

    public string getNamesStr() {
      return getDispStr(this.Names);
    }
    public void setNames(string source) {
      setDispStr(source, this.Names);
    }

    public string getCategoriesStr() {
      return getDispStr(this.Categories);
    }
    public void setCategories(string source) {
      setDispStr(source, this.Categories);
    }
    public string getVendorsStr() {
      return getDispStr(this.Vendors);
    }
    public void setVendors(string source) {
      setDispStr(source, this.Vendors);
    }
    public string getCommentsStr() {
      return getDispStr(this.Comments);
    }
    public void setComments(string source) {
      setDispStr(source, this.Comments);
    }

    public string getDataPortTypesStr() {
      return getDispStr(this.DataPortTypes);
    }
    public void setDataPortTypes(string source) {
      setDispStr(source, this.DataPortTypes);
    }
    public string getServiceInterfaceTypesStr() {
      return getDispStr(this.ServiceInterfaceTypes);
    }
    public void setServiceInterfaceTypes(string source) {
      setDispStr(source, this.ServiceInterfaceTypes);
    }

    private string getDispStr(List<string> source) {
      StringBuilder builder = new StringBuilder();
      foreach (string each in source) {
        if (0 < builder.Length) {
          builder.Append(" ");
        }
        builder.Append(each);
      }
      return builder.ToString();
    }

    private void setDispStr(string source, List<string> target) {
      target.Clear();
      string[] elems = source.Split(' ');
      foreach (string each in elems) {
        target.Add(each.Trim());
      }
    }

    public bool IsSet() {
      if (0 < this.Names.Count) return true;
      if (0 < this.Categories.Count) return true;
      if (0 < this.Vendors.Count) return true;
      if (0 < this.Langiages.Count) return true;
      if (0 < this.Comments.Count) return true;

      if (0 < this.DataPortTypes.Count) return true;
      if (0 < this.DataPortDirections.Count) return true;
      if (0 < this.ServiceInterfaceTypes.Count) return true;
      if (0 < this.ServiceInterfaceDirections.Count) return true;
      return false;

    }
    public void Clear() {
      this.Names.Clear();
      this.OrNames = false;

      this.Categories.Clear();
      this.OrCatregories = false;

      this.Vendors.Clear();
      this.OrVendors = false;

      this.Langiages.Clear();

      this.Comments.Clear();
      this.OrComments = false;

      this.DataPortTypes.Clear();
      this.OrDataPortTypes = false;
      this.DataPortDirections.Clear();

      this.ServiceInterfaceTypes.Clear();
      this.OrServiceInterfaceTypes = false;
      this.ServiceInterfaceDirections.Clear();
    }
  }
  public static class ExtensionMethods {
    public static void Swap<T>(this List<T> list, int index1, int index2) {
      T temp = list[index1];
      list[index1] = list[index2];
      list[index2] = temp;
    }
  }
}
