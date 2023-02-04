using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSystemBuilder.Common {
  public partial class URIDialog : Form {
    public string TargetURI { set; get; }
    public bool IsOK { private set; get; }
    public URIDialog() {
      InitializeComponent();
    }

    private void URIDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      txtURI.Text = TargetURI;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      if (txtURI.Text.Length == 0) {
        MessageBox.Show("【URI】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtURI.Focus();
        return;
      }

      TargetURI = txtURI.Text.Trim();

      this.IsOK = true;
      this.Close();
    }
  }
}
