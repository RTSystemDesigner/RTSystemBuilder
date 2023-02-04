using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSystemBuilder.SystemEdit {
  public partial class DescriptionDialog : Form {
    public SystemCompInfo TargetComp { set; get; }
    public bool IsOK { private set; get; }
    public DescriptionDialog() {
      InitializeComponent();
    }

    private void DescriptionDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      lblComp.Text = TargetComp.Name;
      txtComment.Text = TargetComp.Description;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      TargetComp.Description = txtComment.Text.Trim();

      this.IsOK = true;
      this.Close();
    }
  }
}
