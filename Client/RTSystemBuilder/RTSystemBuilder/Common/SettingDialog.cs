using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using RTSystemBuilder.Common;

namespace RTSystemBuilder {
  public partial class SettingDialog : Form {
    public gRPCWrapper gRPCHandler { set; private get; }
    public GitHubWrapper GitHandler { set; private get; }
    public bool IsOK { private set; get; }

    private List<string> baseRepos_ = new List<string>();
    private List<string> wasanbonRepos_ = new List<string>();

    public SettingDialog() {
      InitializeComponent();
    }

    private void SettingDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      string ipAddress, userId, token;
      int portNo;
      bool ret = CompDb_Util.getSettingValue(out ipAddress, out portNo, 
                                              out userId, out token,
                                              out baseRepos_, out wasanbonRepos_);

      txtIP.Text = ipAddress;
      txtPort.Text = portNo.ToString();
      txtUserId.Text = userId;
      txtToken.Text = token;

      showBaseRepos();
      showWasanbonRepos();
    }

    private void showBaseRepos() {
      this.dgBase.Rows.Clear();

      for(int index=0; index<baseRepos_.Count; index++) {
        this.dgBase.Rows.Add(baseRepos_[index]);
      }

      if(this.dgBase.Rows.Count ==0) {
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;

        btnUpBase.Enabled = false;
        btnDownBase.Enabled = false;
      } else {
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;
      }
    }
    private void btnAdd_Click(object sender, EventArgs e) {
      URIDialog dialog = new URIDialog();
      dialog.TargetURI = "";
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      baseRepos_.Add(dialog.TargetURI);
      showBaseRepos();
    }
    private void btnUpdate_Click(object sender, EventArgs e) {
      updateBaseRepo();
    }
    private void dgBase_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      updateBaseRepo();
    }

    private void updateBaseRepo() {
      if (dgBase.RowCount == 0) return;
      int index= dgBase.CurrentRow.Index;
      string target = baseRepos_[index];

      URIDialog dialog = new URIDialog();
      dialog.TargetURI = target;
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      baseRepos_[index] = dialog.TargetURI;

      int current = this.dgBase.CurrentRow.Index;
      showBaseRepos();
      if (0 < this.dgBase.Rows.Count) {
        if (current < this.dgBase.Rows.Count) {
          this.dgBase.CurrentCell = this.dgBase.Rows[current].Cells[0];
        } else {
          this.dgBase.CurrentCell = this.dgBase.Rows[this.dgBase.Rows.Count - 1].Cells[0];
        }
        dgBase_SelectionChanged();
      }
    }
    private void btnDelete_Click(object sender, EventArgs e) {
      if (dgBase.RowCount == 0) return;
      int index = dgBase.CurrentRow.Index;
      string target = baseRepos_[index];

      DialogResult result = MessageBox.Show("【" + target + "】を削除してもよろしいですか？",
        CompDB_Const.TOOL_NAME,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (result != DialogResult.Yes) return;

      baseRepos_.Remove(target);

      int current = this.dgBase.CurrentRow.Index;
      showBaseRepos();
      if (0 < this.dgBase.Rows.Count) {
        if (current < this.dgBase.Rows.Count) {
          this.dgBase.CurrentCell = this.dgBase.Rows[current].Cells[0];
        } else {
          this.dgBase.CurrentCell = this.dgBase.Rows[this.dgBase.Rows.Count - 1].Cells[0];
        }
        dgBase_SelectionChanged();
      }
    }
    private void btnUpBase_Click(object sender, EventArgs e) {
      if (dgBase.RowCount == 0) return;
      int index = dgBase.CurrentRow.Index;
      string target = baseRepos_[index];

      baseRepos_.Swap(index, index - 1);

      int current = this.dgBase.CurrentRow.Index;
      showBaseRepos();
      this.dgBase.CurrentCell = this.dgBase.Rows[current- 1].Cells[0];
      dgBase_SelectionChanged();
    }
    private void btnDownBase_Click(object sender, EventArgs e) {
      if (dgBase.RowCount == 0) return;
      int index = dgBase.CurrentRow.Index;
      string target = baseRepos_[index];

      baseRepos_.Swap(index, index + 1);

      int current = this.dgBase.CurrentRow.Index;
      showBaseRepos();
      this.dgBase.CurrentCell = this.dgBase.Rows[current + 1].Cells[0];
      dgBase_SelectionChanged();
    }
    private void dgBase_SelectionChanged(object sender, EventArgs e) {
      dgBase_SelectionChanged();
    }
    private void dgBase_SelectionChanged() {
      int index = dgBase.CurrentRow.Index;
      if(index == 0) {
        btnUpBase.Enabled = false;
      } else {
        btnUpBase.Enabled = true;
      }

      if(index == baseRepos_.Count - 1) {
        btnDownBase.Enabled = false;
      } else {
        btnDownBase.Enabled = true;
      }
    }
    //////////
    private void showWasanbonRepos() {
      this.dgWasanbon.Rows.Clear();

      for (int index = 0; index < wasanbonRepos_.Count; index++) {
        this.dgWasanbon.Rows.Add(wasanbonRepos_[index]);
      }
      if (this.dgWasanbon.Rows.Count == 0) {
        btnUpdateWa.Enabled = false;
        btnDeleteWa.Enabled = false;

        btnUpdateWa.Enabled = false;
        btnDownWa.Enabled = false;
      } else {
        btnUpdateWa.Enabled = true;
        btnDeleteWa.Enabled = true;
      }
    }
    private void btnAddWa_Click(object sender, EventArgs e) {
      URIDialog dialog = new URIDialog();
      dialog.TargetURI = "";
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      wasanbonRepos_.Add(dialog.TargetURI);
      showWasanbonRepos();
    }
    private void btnUpdateWa_Click(object sender, EventArgs e) {
      updateWasanbonRepo();
    }

    private void dgWasanbon_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      updateWasanbonRepo();
    }
    private void updateWasanbonRepo() {
      if (dgWasanbon.RowCount == 0) return;
      int index = dgWasanbon.CurrentRow.Index;
      string target = wasanbonRepos_[index];

      URIDialog dialog = new URIDialog();
      dialog.TargetURI = target;
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      wasanbonRepos_[index] = dialog.TargetURI;

      int current = this.dgWasanbon.CurrentRow.Index;
      showWasanbonRepos();
      if (0 < this.dgWasanbon.Rows.Count) {
        if (current < this.dgWasanbon.Rows.Count) {
          this.dgWasanbon.CurrentCell = this.dgWasanbon.Rows[current].Cells[0];
        } else {
          this.dgWasanbon.CurrentCell = this.dgWasanbon.Rows[this.dgWasanbon.Rows.Count - 1].Cells[0];
        }
        dgWasanbon_SelectionChanged();
      }
    }
    private void btnDeleteWa_Click(object sender, EventArgs e) {
      if (dgWasanbon.RowCount == 0) return;
      int index = dgWasanbon.CurrentRow.Index;
      string target = wasanbonRepos_[index];

      DialogResult result = MessageBox.Show("【" + target + "】を削除してもよろしいですか？",
        CompDB_Const.TOOL_NAME,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (result != DialogResult.Yes) return;

      wasanbonRepos_.Remove(target);

      int current = this.dgWasanbon.CurrentRow.Index;
      showWasanbonRepos();
      if (0 < this.dgWasanbon.Rows.Count) {
        if (current < this.dgWasanbon.Rows.Count) {
          this.dgWasanbon.CurrentCell = this.dgWasanbon.Rows[current].Cells[0];
        } else {
          this.dgWasanbon.CurrentCell = this.dgWasanbon.Rows[this.dgWasanbon.Rows.Count - 1].Cells[0];
        }
        dgWasanbon_SelectionChanged();
      }
    }
    private void btnUpWa_Click(object sender, EventArgs e) {
      if (dgWasanbon.RowCount == 0) return;
      int index = dgWasanbon.CurrentRow.Index;
      string target = wasanbonRepos_[index];

      wasanbonRepos_.Swap(index, index - 1);

      int current = this.dgWasanbon.CurrentRow.Index;
      showWasanbonRepos();
      this.dgWasanbon.CurrentCell = this.dgWasanbon.Rows[current - 1].Cells[0];
      dgWasanbon_SelectionChanged();
    }

    private void btnDownWa_Click(object sender, EventArgs e) {
      if (dgWasanbon.RowCount == 0) return;
      int index = dgWasanbon.CurrentRow.Index;
      string target = wasanbonRepos_[index];

      wasanbonRepos_.Swap(index, index + 1);

      int current = this.dgWasanbon.CurrentRow.Index;
      showWasanbonRepos();
      this.dgWasanbon.CurrentCell = this.dgWasanbon.Rows[current + 1].Cells[0];
      dgWasanbon_SelectionChanged();
    }
    private void dgWasanbon_SelectionChanged(object sender, EventArgs e) {
      dgWasanbon_SelectionChanged();
    }

    private void dgWasanbon_SelectionChanged() {
      int index = dgWasanbon.CurrentRow.Index;
      if (index == 0) {
        btnUpWa.Enabled = false;
      } else {
        btnUpWa.Enabled = true;
      }

      if (index == wasanbonRepos_.Count - 1) {
        btnDownWa.Enabled = false;
      } else {
        btnDownWa.Enabled = true;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      if (txtIP.Text.Length == 0) {
        MessageBox.Show("【IPアドレス】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtIP.Focus();
        return;
      }
      string strIp = txtIP.Text.Trim();

      if (txtPort.Text.Length == 0) {
        MessageBox.Show("【ポート番号】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtPort.Focus();
        return;
      }
      int portNo;
      if(int.TryParse(txtPort.Text, out portNo) == false) {
        MessageBox.Show("【ポート番号】には整数値を設定してください",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtPort.Focus();
        return;
      }
      if(portNo <= 0) {
        MessageBox.Show("【ポート番号】には正の整数値を設定してください",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtPort.Focus();
        return;
      }

      if (txtUserId.Text.Length == 0) {
        MessageBox.Show("【ユーザId】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtUserId.Focus();
        return;
      }
      string strUserId = txtUserId.Text.Trim();

      if (txtToken.Text.Length == 0) {
        MessageBox.Show("【アクセストークン】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtToken.Focus();
        return;
      }
      string strToken = txtToken.Text.Trim();

      if(baseRepos_.Count == 0) {
        MessageBox.Show("【システム構築時ベースリポジトリURI】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      StringBuilder builder = new StringBuilder();
      for (int index = 0; index < baseRepos_.Count; index++) {
        if (0 < builder.Length) {
          builder.Append("|");
        }
        builder.Append(baseRepos_[index]);
      }
      string sreBase = builder.ToString();
      ///
      if (wasanbonRepos_.Count == 0) {
        MessageBox.Show("【Wasanbon binderリポジトリURI】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      StringBuilder builderWa = new StringBuilder();
      for (int index = 0; index < wasanbonRepos_.Count; index++) {
        if (0 < builderWa.Length) {
          builderWa.Append("|");
        }
        builderWa.Append(wasanbonRepos_[index]);
      }
      string sreWasanbon = builderWa.ToString();

      var configFile = @"RTSystemBuilderClient.config";
      var exeFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
      var config = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None);
      config.AppSettings.Settings["ServerIP"].Value = strIp;
      config.AppSettings.Settings["ServerPort"].Value =  portNo.ToString();
      config.AppSettings.Settings["UserId"].Value = strUserId;
      config.AppSettings.Settings["AccessToken"].Value = strToken;
      config.AppSettings.Settings["BaseRepository"].Value = sreBase;
      config.AppSettings.Settings["WasanbonRepository"].Value = sreWasanbon;

      config.Save();

      gRPCHandler.setNetInfo(strIp, portNo);
      GitHandler.setUserInfo(strUserId, strToken);

      this.IsOK = true;
      this.Close();
    }
  }
}
