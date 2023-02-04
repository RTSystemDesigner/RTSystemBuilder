using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RTSystemBuilder {
  public class AppController {
    public void startApp() {
      string ipAddress;
      int portNo;
      string userId;
      string token;
      List<string> baseRepos, wasanbonRepos;
      bool ret = CompDb_Util.getSettingValue(out ipAddress, out portNo, out userId, out token, out baseRepos, out wasanbonRepos);

      gRPCWrapper rpc_handler = new gRPCWrapper(ipAddress, portNo);
      GitHubWrapper git_handler = new GitHubWrapper(userId, token);

      AppStatus currentStatus = AppStatus.TOP_MENU;
      WasanbonRegistInfo info = new WasanbonRegistInfo();

      while (true) {
        switch (currentStatus) {
          case AppStatus.TOP_MENU:
            TopMenu topMenu = new TopMenu();
            topMenu.gRPCHandler = rpc_handler;
            topMenu.GitHandler = git_handler;
            topMenu.ShowDialog();
            currentStatus = topMenu.Status;
            break;

          case AppStatus.COMP_DB: {
              ComponentDBForm form = new ComponentDBForm();
              form.gRPCHandler = rpc_handler;
              form.GitHandler = git_handler;
              form.ShowDialog();
              currentStatus = form.NextStatus;
              break;
            }

          case AppStatus.SYSTEM_EDIT: {
              EditSystemForm form = new EditSystemForm();
              form.gRPCHandler = rpc_handler;
              form.GitHandler = git_handler;
              form.ShowDialog();

              currentStatus = form.NextStatus;
              info = form.RegistInfo;
              break;
            }

          case AppStatus.WASANBON_EDIT: {
              WasanbonForm form = new WasanbonForm();
              form.gRPCHandler = rpc_handler;
              form.GitHandler = git_handler;
              form.ShowDialog();
              currentStatus = form.NextStatus;
              break;
            }

          case AppStatus.WASANBON_REGIST: {
              WasanbonForm form = new WasanbonForm();
              form.gRPCHandler = rpc_handler;
              form.GitHandler = git_handler;
              form.RegistInfo = info;
              form.DoRegist = true;
              form.ShowDialog();

              currentStatus = form.NextStatus;
              break;
            }

          case AppStatus.END:
            return;
          default:
            return;
        }
        if (currentStatus == AppStatus.END) break;
      }
    }
  }
}
