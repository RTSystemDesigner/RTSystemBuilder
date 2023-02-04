using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSystemBuilder {
  public class CompAppInfo {
    public ulong Id { set; get; }
    public string Name { set; get; }
    public string ComponentName { set; get; }
    public string Category { set; get; }
    public string Vendor { set; get; }
    public uint Language { set; get; }
    public string Repository { set; get; }
    public string Comment { set; get; }
    public List<CategoryAppInfo> Categories { set; get; }
    public List<DataPortAppInfo> DataPorts { set; get; }
    public List<ServicePortAppInfo> ServicePorts { set; get; }
    public CompAppInfo() {
      this.Categories = new List<CategoryAppInfo>();
      this.DataPorts = new List<DataPortAppInfo>();
      this.ServicePorts = new List<ServicePortAppInfo>();
    }
    public string getCategoryStr() {
      StringBuilder buider = new StringBuilder();
      if(this.Category != null && 0 < this.Category.Length) {
        buider.Append(this.Category);
      }
      foreach(CategoryAppInfo each in this.Categories) {
        if(0<buider.Length) {
          buider.Append(", ");
        }
        buider.Append(each.Name);
      }
      return buider.ToString();
    }
    public string getDataPortStr() {
      if (this.DataPorts.Count == 0) return "";

      StringBuilder builder = new StringBuilder();
      List<DataPortAppInfo> inPorts = this.DataPorts.Where(c => c.Direction == CompDB_Const.DP_IN).ToList();
      List<DataPortAppInfo> outPorts = this.DataPorts.Where(c => c.Direction == CompDB_Const.DP_OUT).ToList();
      if (0 < inPorts.Count) {
        builder.Append("[InPort]").Append(Environment.NewLine);
        foreach (DataPortAppInfo each in inPorts) {
          builder.Append(" - ").Append(each.Name).Append(" (").Append(each.Type).Append(")").Append(Environment.NewLine);
        }
      }
      if (0 < outPorts.Count) {
        builder.Append("[OutPort]").Append(Environment.NewLine);
        foreach (DataPortAppInfo each in outPorts) {
          builder.Append(" - ").Append(each.Name).Append(" (").Append(each.Type).Append(")").Append(Environment.NewLine);
        }
      }
      return builder.ToString();
    }
    public string getServicePortStr() {
      if (this.ServicePorts.Count == 0) return "";

      StringBuilder builder = new StringBuilder();
      foreach(ServicePortAppInfo each in this.ServicePorts) {
        builder.Append("- ").Append(each.Name).Append(Environment.NewLine);
        foreach(ServiceInterfaceAppInfo eachIf in each.Interfaces) {
          builder.Append("  - ").Append(eachIf.Name).Append(Environment.NewLine);
          builder.Append("     type=").Append(eachIf.InterfacerType).Append(Environment.NewLine);
          builder.Append("     direction=").Append(CompDb_Util.getIfDirection(eachIf.Direction)).Append(Environment.NewLine);
        }
      }
      return builder.ToString();
    }
  }
  public class CategoryAppInfo {
    public string Name { set; get; }
    public uint ParentId { set; get; }
  }
  public class DataPortAppInfo {
    public string Name { set; get; }
    public string Type { set; get; }
    public uint Direction { set; get; }
  }
  public class ServicePortAppInfo {
    public string Name { set; get; }
    public List<ServiceInterfaceAppInfo> Interfaces { set; get; }
    public ServicePortAppInfo() {
      this.Interfaces = new List<ServiceInterfaceAppInfo>();
    }
  }
  public class ServiceInterfaceAppInfo {
    public string Name { set; get; }
    public string InterfacerType { set; get; }
    public uint Direction { set; get; }
  }
  public class SystemCompInfo {
    public string Name { set; get; }
    public string Description { set; get; }
    public string Url { set; get; }
    public uint Language { set; get; }
    public string Hash { set; get; }
    public string RepoName { set; get; }
    public bool IsUpdated { set; get; }
  }
  public class WasanbonRegistInfo {
    public string SystemName { set; get; }
    public string Url { set; get; }

  }
  //REST API
  public class CommitInfo {
    public string sha { set; get; }
    public string node_id { set; get; }
    public string url { set; get; }
  }
  public class ContentsInfo {
    public string name { set; get; }
    public string path { set; get; }
    public string content { set; get; }
  }
  public class SystemPackageInfo {
    public string name { set; get; }
    public string sha { set; get; }
    public string download_url { set; get; }
  }
  public class SystemContentsInfo {
    public string name { set; get; }
    public string description { set; get; }
    public string type { set; get; }
    public string url { set; get; }
    public string platform { set; get; }
    public bool isNew { set; get; }
  }
  public class SystemSettingInfo {
    public string description { set; get; }
    public string type { set; get; }
    public string url { set; get; }
    public string platform { set; get; }
  }
  public class RtcContentsInfo {
    public string description { set; get; }
    public string git { set; get; }
    public string hash { set; get; }
    public string repo_name { set; get; }
  }

  public class UpdateContentsInfo {
    public string message { set; get; }
    public string content { set; get; }
    public string sha { set; get; }
  }
  public class AddRepositoryInfo {
    public string name { set; get; }
    public bool auto_init { set; get; }
    public bool @private { set; get; }
  }
  public class RepositoryInfo {
    public string name { set; get; }
  }
  public class RtcRepositoryInfo {
    public string name { set; get; }
    public string description { set; get; }
    public string git { set; get; }
    public string hash { set; get; }
    public string repo_name { set; get; }
  }
  public class OrgRepositoryInfo {
    public string name { set; get; }
    public string html_url { set; get; }
  }
}
