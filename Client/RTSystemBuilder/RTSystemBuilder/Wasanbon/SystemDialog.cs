using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RTSystemBuilder.Wasanbon;

namespace RTSystemBuilder {
  public partial class SystemDialog : Form {
    public SystemContentsInfo TargetInfo { set; get; }
    public GitHubWrapper GitHandler { set; private get; }
    public bool IsNewRegist { set; get; }
    public List<SystemContentsInfo> ContentsList { set; private get; }
    public List<string> RepositoryList { set; get; }
    public string SelectedRepository { set; get; }
    public WasanbonRegistInfo RegistInfo { set; private get; }
    public bool CanEdit { set; private get; }
    public bool IsOK { private set; get; }
    public SystemDialog() {
      InitializeComponent();
    }

    private void RegisterdUpdateDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      cmbRep.Items.Clear();
      for (int index = 0; index < RepositoryList.Count; index++) {
        cmbRep.Items.Add(RepositoryList[index]);
      }
      if (SelectedRepository != null && 0 < SelectedRepository.Length) {
        cmbRep.Text = SelectedRepository;
      } else { 
        cmbRep.SelectedIndex = 0;
      }
      if (RegistInfo == null) {
        cmbRep.Enabled = false;
      }

      if (TargetInfo == null) {
        TargetInfo = new SystemContentsInfo();
        TargetInfo.type = "git";
        TargetInfo.isNew = true;
        if (RegistInfo != null) {
          txtName.Text = RegistInfo.SystemName;
          txtURL.Text = RegistInfo.Url;

          TargetInfo.name = RegistInfo.SystemName;
          TargetInfo.url = RegistInfo.Url;

          txtName.Enabled = false;
          txtURL.Enabled = false;
          btnSearch.Enabled = false;
        }

      } else { 
        lblTitle.Text = "システム更新";

        txtName.Text = TargetInfo.name;
        txtDescription.Text = TargetInfo.description;
        txtURL.Text = TargetInfo.url;
        if (TargetInfo.platform != null) {
          chkWin.Checked = TargetInfo.platform.ToLower().Contains("win");
          chkMac.Checked = TargetInfo.platform.ToLower().Contains("osx");
          chkUbuntu.Checked = TargetInfo.platform.ToLower().Contains("ubuntu");
        }
        if (CanEdit == false) {
          txtName.Enabled = false;
          txtURL.Enabled = false;
          btnSearch.Enabled = false;
        }
      }
    }
    private void btnSearch_Click(object sender, EventArgs e) {
      SearchRepositoryDialog dialog = new SearchRepositoryDialog();
      dialog.GitHandler = this.GitHandler;
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      OrgRepositoryInfo selected = dialog.Selected;
      txtURL.Text = selected.html_url;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      if (txtName.Text.Length == 0) {
        MessageBox.Show("【システム名】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtName.Focus();
        return;
      }
      string strName = txtName.Text.Trim();

      if (txtURL.Text.Length == 0) {
        MessageBox.Show("【URL】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtURL.Focus();
        return;
      }
      string strURL = txtURL.Text.Trim();
      if(strURL.EndsWith(".git") == false) {
        strURL = strURL + ".git";
      }
      
      StringBuilder builder = new StringBuilder();
      if(chkWin.Checked) {
        builder.Append("win");
      }
      if (chkMac.Checked) {
        if (0 < builder.Length) {
          builder.Append(", ");
        }
        builder.Append("osx");
      }
      if (chkUbuntu.Checked) {
        if(0<builder.Length) {
          builder.Append(", ");
        }
        builder.Append("ubuntu");
      }
      if (builder.Length == 0) {
        MessageBox.Show("【プラットフォーム】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (ContentsList != null) {
        SystemContentsInfo existed = ContentsList.FirstOrDefault(c => c.name == strName && c.url == strURL);
        if (existed != null &&
            (IsNewRegist || (IsNewRegist == false && TargetInfo != existed))) {
          MessageBox.Show("【システム名】【URL】が同一の要素が既に登録されています",
            CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtName.Focus();
          return;
        }
      }

      TargetInfo.name = strName;
      TargetInfo.description = txtDescription.Text;
      TargetInfo.url = strURL;
      TargetInfo.platform = builder.ToString();

      SelectedRepository = cmbRep.Text.Trim();

      this.IsOK = true;
      this.Close();
    }
  }
}
