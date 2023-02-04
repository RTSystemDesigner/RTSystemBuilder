using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using YamlDotNet.Serialization;

namespace RTSystemBuilder {
  public partial class ComponentDBForm : Form {
    public gRPCWrapper gRPCHandler { set; private get; }
    public GitHubWrapper GitHandler { set; private get; }
    public AppStatus NextStatus { private set; get; }

    private List<CompAppInfo> componentList_ = new List<CompAppInfo>();
    private List<SystemContentsInfo> contentsList_ = new List<SystemContentsInfo>();
    private ComponentSearchCondition cond_ = new ComponentSearchCondition();
    private string systemSHA_;

    private bool isSkip_ = false;

    public ComponentDBForm() {
      InitializeComponent();
    }

    private void CompDBMain_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      btnUpdate.Enabled = false;
      btnDelete.Enabled = false;

      showCompList();
    }

    private void showCompList() {
      this.dgComponent.Rows.Clear();

      for(int index=0; index<componentList_.Count; index++) {
        CompAppInfo comp = componentList_[index];
        this.dgComponent.Rows.Add(comp.Id, comp.Name,
                                    comp.ComponentName,
                                    comp.Vendor,
                                    comp.getCategoryStr(),
                                    CompDb_Util.getLangTypeName(comp.Language),
                                    comp.Repository,
                                    comp.Comment);
      }
      if(this.dgComponent.Rows.Count==0) {
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
      } else {
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;
      }
    }
    private void dgComponent_SelectionChanged(object sender, EventArgs e) {
      dgComponent_SelectionChanged();
    }
    private void dgComponent_SelectionChanged() {
      txtDataPort.Text = "";
      txtServicePort.Text = "";

      if (dgComponent.RowCount == 0) return;
      ulong id = (ulong)dgComponent.CurrentRow.Cells[0].Value;
      CompAppInfo target = componentList_.FirstOrDefault(n => n.Id == id);
      if (target == null) return;

      txtDataPort.Text = target.getDataPortStr();
      txtServicePort.Text = target.getServicePortStr();
    }

    private void btnAll_Click(object sender, EventArgs e) {
      cond_.Clear();
      btnSearch.BackColor = Color_Const.BTN_BG_ENABLE;
      if (searchComponent() == false) {
        MessageBox.Show("コンポーネント情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      showCompList();
    }
    private void btnSearch_Click(object sender, EventArgs e) {
      ComponentSearchDialog dialog = new ComponentSearchDialog();
      dialog.Cond = cond_;
      dialog.gRPCHandler = this.gRPCHandler;
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      componentList_ = dialog.CompList;
      showCompList();
      dgComponent_SelectionChanged();
      if(cond_.IsSet()) {
        btnSearch.BackColor = Color_Const.BTN_BG_DISABLE;
      }
    }
    private void btnAdd_Click(object sender, EventArgs e) {
      ComponentRegistDialog dialog = new ComponentRegistDialog();
      dialog.gRPCHandler = this.gRPCHandler;
      dialog.GitHandler = this.GitHandler;
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      if (searchComponent() == false) {
        MessageBox.Show("コンポーネント情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      showCompList();
      this.dgComponent.CurrentCell = this.dgComponent.Rows[this.dgComponent.Rows.Count - 1].Cells[1];
      dgComponent_SelectionChanged();
    }
    private void dgComponent_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      updateComponent();
    }
    private void btnUpdate_Click(object sender, EventArgs e) {
      updateComponent();
    }
    private void updateComponent() {
      if (dgComponent.RowCount == 0) return;
      ulong id = (ulong)dgComponent.CurrentRow.Cells[0].Value;
      CompAppInfo target = componentList_.FirstOrDefault(n => n.Id == id);
      if (target == null) return;

      ComponentUpdateDialog dialog = new ComponentUpdateDialog();
      dialog.TargetComp = target;
      dialog.gRPCHandler = this.gRPCHandler;
      dialog.GitHandler = this.GitHandler;
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      if (searchComponent() == false) {
        MessageBox.Show("コンポーネント情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      int current = this.dgComponent.CurrentRow.Index;
      showCompList();
      if (0 < this.dgComponent.Rows.Count) {
        if (current < this.dgComponent.Rows.Count) {
          this.dgComponent.CurrentCell = this.dgComponent.Rows[current].Cells[1];
        } else {
          this.dgComponent.CurrentCell = this.dgComponent.Rows[this.dgComponent.Rows.Count - 1].Cells[1];
        }
        dgComponent_SelectionChanged();
      }
    }
    private void btnDelete_Click(object sender, EventArgs e) {
      if (dgComponent.RowCount == 0) return;
      ulong id = (ulong)dgComponent.CurrentRow.Cells[0].Value;
      CompAppInfo target = componentList_.FirstOrDefault(n => n.Id == id);
      if (target == null) return;

      DialogResult result = MessageBox.Show("【" + target.Name + "】を削除してもよろしいですか？",
        CompDB_Const.TOOL_NAME,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (result != DialogResult.Yes) return;

      string errMsg;
      if(gRPCHandler.deleteComponent(target.Id, out errMsg) != CompDB_Const.STATUS_OK) {
        MessageBox.Show("コンポーネントの削除に失敗しました" + Environment.NewLine + errMsg,
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if(searchComponent()== false) {
        MessageBox.Show("コンポーネント情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      int current = this.dgComponent.CurrentRow.Index;
      showCompList();
      if (0 < this.dgComponent.Rows.Count) {
        if (current < this.dgComponent.Rows.Count) {
          this.dgComponent.CurrentCell = this.dgComponent.Rows[current].Cells[1];
        } else {
          this.dgComponent.CurrentCell = this.dgComponent.Rows[this.dgComponent.Rows.Count - 1].Cells[1];
        }
        dgComponent_SelectionChanged();
      }
    }

    private bool searchComponent() {
      List<CompAppInfo> result;
      if (gRPCHandler.searchComponent(cond_, out result) != CompDB_Const.STATUS_OK) {
        return false;
      }
      this.componentList_ = result;
      return true;
    }

    private void btnClose_Click(object sender, EventArgs e) {
      this.NextStatus = AppStatus.TOP_MENU;
      this.Close();
    }
  }
}
