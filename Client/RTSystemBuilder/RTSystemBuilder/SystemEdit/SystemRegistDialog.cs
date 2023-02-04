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
  public partial class SystemRegistDialog : Form {
    public string Description { private set; get; }
    public string NameService { private set; get; }
    public string CommitMessage { private set; get; }
    public bool IsOK { private set; get; }
    public SystemRegistDialog() {
      InitializeComponent();
    }

    private void SystemRegistDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      this.Description = txtDesc.Text.Trim();
      this.NameService = txtNameServ.Text.Trim();
      this.CommitMessage = txtCommit.Text.Trim();

      this.IsOK = true;
      this.Close();
    }
  }
}
