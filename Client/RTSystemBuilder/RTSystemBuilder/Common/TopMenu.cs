using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSystemBuilder {
  public partial class TopMenu : Form {
    public AppStatus Status { private set; get; }
    public gRPCWrapper gRPCHandler { set; private get; }
    public GitHubWrapper GitHandler { set; private get; }

    private bool isOk_ = false;
    public TopMenu() {
      InitializeComponent();
    }

    private void TopMenu_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;
    }

    private void btnDB_Click(object sender, EventArgs e) {
      Status = AppStatus.COMP_DB;
      isOk_ = true;
      this.Close();
    }

    private void btnSystem_Click(object sender, EventArgs e) {
      Status = AppStatus.SYSTEM_EDIT;
      isOk_ = true;
      this.Close();
    }

    private void btnWasan_Click(object sender, EventArgs e) {
      Status = AppStatus.WASANBON_EDIT;
      isOk_ = true;
      this.Close();
    }

    private void btnSetting_Click(object sender, EventArgs e) {
      SettingDialog dialog = new SettingDialog();
      dialog.gRPCHandler = this.gRPCHandler;
      dialog.GitHandler = this.GitHandler;
      dialog.ShowDialog();
    }
    private void btnClose_Click(object sender, EventArgs e) {
      Status = AppStatus.END;
      isOk_ = true;
      this.Close();
    }

    private void TopMenu_FormClosing(object sender, FormClosingEventArgs e) {
      if (isOk_) return;
      Status = AppStatus.END;
    }
  }
}
