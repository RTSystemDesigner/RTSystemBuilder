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
  public partial class CommitDialog : Form {
    public string Message { private set; get; }
    public bool IsOK { private set; get; }
    public CommitDialog() {
      InitializeComponent();
    }

    private void CommitDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      this.Message = txtDescription.Text.Trim();

      this.IsOK = true;
      this.Close();
    }
  }
}
