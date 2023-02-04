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
  public partial class ComponentSearchDialog : Form {
    public gRPCWrapper gRPCHandler { set; private get; }
    public ComponentSearchCondition Cond { set; get; }
    public List<CompAppInfo> CompList { private set; get; }
    public bool IsOK { private set; get; }
    public ComponentSearchDialog() {
      InitializeComponent();
    }

    private void ComponentSearchDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      txtName.Text = Cond.getNamesStr();
      chkName.Checked = Cond.OrNames;
      txtCategory.Text = Cond.getCategoriesStr();
      chkCatrgory.Checked = Cond.OrCatregories;
      txtVendor.Text = Cond.getVendorsStr();
      chkVendor.Checked = Cond.OrVendors;

      chkCpp.Checked = Cond.Langiages.Contains(CompDB_Const.LANG_CPP);
      chkPython.Checked = Cond.Langiages.Contains(CompDB_Const.LANG_PYTHON);
      chkJava.Checked = Cond.Langiages.Contains(CompDB_Const.LANG_JAVA);

      txtComment.Text = Cond.getCommentsStr();
      chkComment.Checked = Cond.OrComments;

      txtDPType.Text = Cond.getDataPortTypesStr();
      chkDPType.Checked = Cond.OrDataPortTypes;
      chkIn.Checked = Cond.DataPortDirections.Contains(CompDB_Const.DP_IN);
      chkOut.Checked = Cond.DataPortDirections.Contains(CompDB_Const.DP_OUT);

      txtSPType.Text = Cond.getServiceInterfaceTypesStr();
      chkSPType.Checked = Cond.OrServiceInterfaceTypes;
      chkProvided.Checked = Cond.ServiceInterfaceDirections.Contains(CompDB_Const.SP_PROVIDED);
      chkRequired.Checked = Cond.ServiceInterfaceDirections.Contains(CompDB_Const.SP_REQUIRED);
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      Cond.setNames(txtName.Text.Trim());
      Cond.OrNames = chkName.Checked;
      Cond.setCategories(txtCategory.Text.Trim());
      Cond.OrCatregories = chkCatrgory.Checked;
      Cond.setVendors(txtVendor.Text.Trim());
      Cond.OrVendors = chkVendor.Checked;
      Cond.Langiages.Clear();
      if(chkCpp.Checked) {
        Cond.Langiages.Add(CompDB_Const.LANG_CPP);
      }
      if (chkPython.Checked) {
        Cond.Langiages.Add(CompDB_Const.LANG_PYTHON);
      }
      if (chkJava.Checked) {
        Cond.Langiages.Add(CompDB_Const.LANG_JAVA);
      }
      Cond.setComments(txtComment.Text.Trim());
      Cond.OrComments = chkComment.Checked;

      Cond.setDataPortTypes(txtDPType.Text.Trim());
      Cond.OrDataPortTypes = chkDPType.Checked;
      Cond.DataPortDirections.Clear();
      if(chkIn.Checked) {
        Cond.DataPortDirections.Add(CompDB_Const.DP_IN);
      }
      if (chkOut.Checked) {
        Cond.DataPortDirections.Add(CompDB_Const.DP_OUT);
      }

      Cond.setServiceInterfaceTypes(txtSPType.Text.Trim());
      Cond.OrServiceInterfaceTypes = chkSPType.Checked;
      Cond.ServiceInterfaceDirections.Clear();
      if(chkProvided.Checked) {
        Cond.ServiceInterfaceDirections.Add(CompDB_Const.SP_PROVIDED);
      }
      if (chkRequired.Checked) {
        Cond.ServiceInterfaceDirections.Add(CompDB_Const.SP_REQUIRED);
      }

      List<CompAppInfo> result;
      if (gRPCHandler.searchComponent(Cond, out result) != CompDB_Const.STATUS_OK) {
        MessageBox.Show("コンポーネントの検索に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      this.CompList = result;

      this.IsOK = true;
      this.Close();
    }
  }
}
