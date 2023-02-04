using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grpc.Core;

namespace RTSystemBuilder {
  public sealed class gRPCWrapper {
    private string ipAddress_;
    private int portNo_;

    public gRPCWrapper(string ipAddress, int portNo) {
      this.ipAddress_ = ipAddress;
      this.portNo_ = portNo;
    }

    public void setNetInfo(string ipAddress, int portNo) {
      this.ipAddress_ = ipAddress;
      this.portNo_ = portNo;
    }

    public uint searchComponent(ComponentSearchCondition cond, out List<CompAppInfo> result) {
      try {
        var channel = new Channel(ipAddress_, portNo_, ChannelCredentials.Insecure);
        var client = new ComponentDatabaseService.ComponentDatabaseServiceClient(channel);

        ComponentSearchRequest param = new ComponentSearchRequest();
        if (0 < cond.Names.Count) {
          foreach (string each in cond.Names) {
            param.Names.Add(each);
          }
        }
        param.NamesOr = cond.OrNames;

        if (0 < cond.Categories.Count) {
          foreach (string each in cond.Categories) {
            param.Categories.Add(each);
          }
        }
        param.CategoriesOr = cond.OrCatregories;

        if (0 < cond.Vendors.Count) {
          foreach (string each in cond.Vendors) {
            param.Vendors.Add(each);
          }
        }
        param.VendorsOr = cond.OrVendors;

        if (0 < cond.Langiages.Count) {
          foreach (uint each in cond.Langiages) {
            param.Languages.Add(each);
          }
        }

        if (0 < cond.Comments.Count) {
          foreach (string each in cond.Comments) {
            param.Comments.Add(each);
          }
        }
        param.CommentsOr = cond.OrComments;

        if (0 < cond.DataPortTypes.Count) {
          foreach (string each in cond.DataPortTypes) {
            param.DataPortTypes.Add(each);
          }
        }
        param.DataPortTypeOr = cond.OrDataPortTypes;

        if (0 < cond.DataPortDirections.Count) {
          foreach (uint each in cond.DataPortDirections) {
            param.DataPortDirections.Add(each);

          }
        }

        if (0 < cond.ServiceInterfaceTypes.Count) {
          foreach (string each in cond.ServiceInterfaceTypes) {
            param.ServiceInterfaceTypes.Add(each);
          }
        }
        param.ServiceInterfaceTypeOr = cond.OrServiceInterfaceTypes;

        if (0 < cond.ServiceInterfaceDirections.Count) {
          foreach (uint each in cond.ServiceInterfaceDirections) {
            param.ServiceInterfaceDirections.Add(each);
          }
        }

        var ret = client.SearchComponent(param);

        result = new List<CompAppInfo>();
        foreach (ComponentInfo each in ret.Results) {
          CompAppInfo comp = new CompAppInfo();
          comp.Id = each.Id;
          comp.Name = each.Name;
          comp.ComponentName = each.ComponentName;
          comp.Vendor = each.Vendor;
          comp.Language = each.Language;
          comp.Repository = each.Repository;
          comp.Comment = each.Comment;
          result.Add(comp);

          comp.Categories = new List<CategoryAppInfo>();
          foreach (CategoryInfo eachCat in each.Categories) {
            CategoryAppInfo cat = new CategoryAppInfo();
            cat.Name = eachCat.Name;
            cat.ParentId = eachCat.ParentId;
            comp.Categories.Add(cat);
          }

          comp.DataPorts = new List<DataPortAppInfo>();
          foreach (DataPortInfo eachDp in each.DataPorts) {
            DataPortAppInfo port = new DataPortAppInfo();
            port.Name = eachDp.Name;
            port.Type = eachDp.Type;
            port.Direction = eachDp.Direction;
            comp.DataPorts.Add(port);
          }

          comp.ServicePorts = new List<ServicePortAppInfo>();
          foreach (ServicePortInfo eachSp in each.ServicePorts) {
            ServicePortAppInfo port = new ServicePortAppInfo();
            port.Name = eachSp.Name;
            comp.ServicePorts.Add(port);
            port.Interfaces = new List<ServiceInterfaceAppInfo>();
            foreach (ServiceInterfaceInfo eachSi in eachSp.Interfaces) {
              ServiceInterfaceAppInfo sif = new ServiceInterfaceAppInfo();
              sif.Name = eachSi.Name;
              sif.Direction = eachSi.Direction;
              sif.InterfacerType = eachSi.InterfaceType;
              port.Interfaces.Add(sif);
            }
          }
        }
      } catch (Exception ex) {
        result = new List<CompAppInfo>();
        return CompDB_Const.STATUS_NG;
      }
      return CompDB_Const.STATUS_OK;
    }

    public uint registComponent(CompAppInfo source, out string errMsg) {
      try {
        var channel = new Channel(ipAddress_, portNo_, ChannelCredentials.Insecure);
        var client = new ComponentDatabaseService.ComponentDatabaseServiceClient(channel);

        ComponentRegistRequest param = new ComponentRegistRequest();
        ComponentInfo comp = setComponentInfo(source);
        param.Component = comp;

        var result = client.RegistComponent(param);

        errMsg = result.Message;

        return result.Status;
      } catch (Exception ex) {
        errMsg = ex.Message;
        return CompDB_Const.STATUS_NG;
      }
    }

    public uint deleteComponent(ulong id, out string errMsg) {
      try {
        var channel = new Channel(ipAddress_, portNo_, ChannelCredentials.Insecure);
        var client = new ComponentDatabaseService.ComponentDatabaseServiceClient(channel);

        ComponentDeleteRequest param = new ComponentDeleteRequest();
        param.ComponentId = id;
        var result = client.DeleteComponent(param);

        int ret = (int)result.Status;
        errMsg = result.Message;

        return result.Status;
      } catch (Exception ex) {
        errMsg = ex.Message;
        return CompDB_Const.STATUS_NG;
      }
    }
    public uint updateComponent(ulong id, CompAppInfo source, bool isUpdate, out string errMsg) {
      try {
        var channel = new Channel(ipAddress_, portNo_, ChannelCredentials.Insecure);
        var client = new ComponentDatabaseService.ComponentDatabaseServiceClient(channel);

        ComponentUpdateRequest param = new ComponentUpdateRequest();
        param.ComponentId = id;
        param.UpdateDetail = isUpdate;
        ComponentInfo comp = setComponentInfo(source);
        param.Component = comp;
        var result = client.UpdateComponent(param);

        errMsg = result.Message;

        return result.Status;
      } catch (Exception ex) {
        errMsg = ex.Message;
        return CompDB_Const.STATUS_NG;
      }
    }
    private ComponentInfo setComponentInfo(CompAppInfo source) {
      ComponentInfo comp = new ComponentInfo();

      comp.Name = source.Name;
      comp.ComponentName = source.ComponentName;
      comp.Vendor = source.Vendor;
      comp.Language = source.Language;
      comp.Repository = source.Repository;
      comp.Comment = source.Comment;
      /////
      if (source.Category != null) {
        CategoryInfo category = new CategoryInfo();
        category.Name = source.Category;
        comp.Categories.Add(category);
      }
      foreach (CategoryAppInfo each in source.Categories) {
        CategoryInfo cat = new CategoryInfo();
        cat.Name = each.Name;
        cat.ParentId = each.ParentId;
        comp.Categories.Add(cat);
      }
      /////
      foreach (DataPortAppInfo each in source.DataPorts) {
        DataPortInfo port = new DataPortInfo();
        port.Name = each.Name;
        port.Type = each.Type;
        port.Direction = each.Direction;
        comp.DataPorts.Add(port);
      }
      /////
      foreach (ServicePortAppInfo each in source.ServicePorts) {
        ServicePortInfo port = new ServicePortInfo();
        port.Name = each.Name;
        foreach (ServiceInterfaceAppInfo eachIf in each.Interfaces) {
          ServiceInterfaceInfo sIf = new ServiceInterfaceInfo();
          sIf.Name = eachIf.Name;
          sIf.Direction = eachIf.Direction;
          sIf.InterfaceType = eachIf.InterfacerType;
          port.Interfaces.Add(sIf);
        }
        comp.ServicePorts.Add(port);
      }

      return comp;
    }
  }
}
