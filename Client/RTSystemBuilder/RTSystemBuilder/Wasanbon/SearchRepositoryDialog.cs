using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSystemBuilder.Wasanbon {
  public partial class SearchRepositoryDialog : Form {
    public OrgRepositoryInfo Selected { private set; get; }
    public GitHubWrapper GitHandler { set; private get; }
    public bool IsOK { private set; get; }

    private List<OrgRepositoryInfo> repoList_;
    private string cond_ = "";

    public SearchRepositoryDialog() {
      InitializeComponent();
    }

    private void SearchRepositoryDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      this.dgRepository.Rows.Clear();
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      if(txtName.Text == null || txtName.Text.Length ==0) {
        MessageBox.Show("【組織名】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtName.Focus();
        return;
      }

      this.Cursor = Cursors.WaitCursor;
      string strOrg = txtName.Text.Trim();
      if(GitHandler.getRepositoryList(strOrg, out repoList_) == false) {
        this.Cursor = Cursors.Arrow;
        MessageBox.Show("リポジトリ情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtName.Focus();
        return;
      }
      showRepositoryList();
      this.Cursor = Cursors.Arrow;
    }
    private void showRepositoryList() {
      this.dgRepository.Rows.Clear();
      for(int index=0; index<repoList_.Count;index++) {
        OrgRepositoryInfo each = repoList_[index];
        if (0 < cond_.Length) {
          if (each.name.Contains(cond_) == false) continue;
        }
        this.dgRepository.Rows.Add(index, each.name, each.html_url);
      }
    }

    private void btnFilter_Click(object sender, EventArgs e) {
      cond_ = txtFilter.Text.Trim();
      showRepositoryList();
      btnFilter.BackColor = Color_Const.BTN_BG_DISABLE;
    }

    private void btnClear_Click(object sender, EventArgs e) {
      cond_ = "";
      txtFilter.Text = "";
      showRepositoryList();
      btnFilter.BackColor = Color_Const.BTN_BG_ENABLE;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      int index = (int)dgRepository.CurrentRow.Cells[0].Value;
      if (index < 0 || repoList_.Count < index) return;

      Selected = repoList_[index];

      this.IsOK = true;
      this.Close();
    }
  }
}
