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
  public partial class WasanbonForm : Form {
    public gRPCWrapper gRPCHandler { set; private get; }
    public GitHubWrapper GitHandler { set; private get; }
    public WasanbonRegistInfo RegistInfo { set; private get; }
    public bool DoRegist { set; private get; }
    public AppStatus NextStatus { private set; get; }

    private List<string> repositoryList_ = new List<string>();
    private List<CompAppInfo> componentList_ = new List<CompAppInfo>();
    private List<SystemContentsInfo> contentsList_ = new List<SystemContentsInfo>();
    private ComponentSearchCondition cond_ = new ComponentSearchCondition();
    private string systemSHA_;

    public WasanbonForm() {
      InitializeComponent();
    }

    private void CompDBMain_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      if (CompDb_Util.getWasanbonRepositories(out repositoryList_) == false) {
        MessageBox.Show("Wasanbonリポジトリ情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if(repositoryList_.Count == 0) {
        MessageBox.Show("Wasanbonリポジトリ情報が登録されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      cmbRep.Items.Clear();
      for (int index = 0; index < repositoryList_.Count; index++) {
        cmbRep.Items.Add(repositoryList_[index]);
      }
      cmbRep.SelectedIndex = 0;

      btnSet.Enabled = false;
      btnAdd.Enabled = false;

      showRegistered();

      if(this.DoRegist) {
        SystemDialog dialog = new SystemDialog();
        dialog.RegistInfo = this.RegistInfo;
        dialog.GitHandler = this.GitHandler;
        dialog.IsNewRegist = true;
        dialog.RepositoryList = repositoryList_;
        dialog.CanEdit = false;
        dialog.ShowDialog();
        if (dialog.IsOK == false) return;

        string strRepo = dialog.SelectedRepository;
        if(getRepositoryInfo(strRepo) == false) return;

        this.contentsList_.Add(dialog.TargetInfo);
        showRegistered();
      }
    }

    private void showRegistered() {
      this.dgRegistered.Rows.Clear();

      for(int index=0; index<this.contentsList_.Count; index++) {
        SystemContentsInfo each = this.contentsList_[index];
        this.dgRegistered.Rows.Add(index, each.name,
                                    each.description, each.type, each.url, each.platform);
        if(each.isNew) {
          this.dgRegistered.Rows[this.dgRegistered.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightPink;
        }
      }

      if(this.dgRegistered.Rows.Count == 0) {
        btnUpdateReg.Enabled = false;
        btnDelete.Enabled = false;
      } else {
        btnUpdateReg.Enabled = true;
        btnDelete.Enabled = true;
      }
    }
    private void btnGet_Click(object sender, EventArgs e) {
      this.Cursor = Cursors.WaitCursor;
      string strRepository = cmbRep.Text.Trim();
      getRepositoryInfo(strRepository);
      this.Cursor = Cursors.Arrow;
    }

    private bool getRepositoryInfo(string strRepository) {
      if (strRepository.StartsWith("https://github.com/") == false) {
        MessageBox.Show("【WasanbonリポジトリURI】の指定が不正です",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      string targetUri = strRepository.Substring(19);
      List<ContentsInfo> result;
      if (GitHandler.getContentsList(targetUri, out result) == false) {
        MessageBox.Show("指定されたリポジトリの情報取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      ContentsInfo target = result.FirstOrDefault(c => c.name == "packages");
      if (target == null) {
        MessageBox.Show("指定されたリポジトリにはパッケージ情報が存在しません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      if (GitHandler.getContentsList(targetUri, "packages", out result) == false) {
        MessageBox.Show("指定されたリポジトリの情報取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      target = result.FirstOrDefault(c => c.name == "system.yaml");
      if (target == null) {
        MessageBox.Show("指定されたリポジトリにはsystem.yamlが存在しません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      /////
      List<SystemContentsInfo> sysInfo;

      if (GitHandler.getSystemProfile(targetUri, out sysInfo, out systemSHA_) == false) {
        MessageBox.Show("プロファイル情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      this.contentsList_ = sysInfo;
      showRegistered();

      btnSet.Enabled = true;
      btnAdd.Enabled = true;

      return true;
    }

    private void btnSet_Click(object sender, EventArgs e) {
      string strRepository =cmbRep.Text.Trim();
      if (strRepository.StartsWith("https://github.com/") == false) {
        MessageBox.Show("【WasanbonリポジトリURI】の指定が不正です",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      string targetUri = strRepository.Substring(19);

      Dictionary<string, SystemSettingInfo> compDict = new Dictionary<string, SystemSettingInfo>();

      foreach(SystemContentsInfo each in this.contentsList_) {
        SystemSettingInfo elem = new SystemSettingInfo();
        elem.description = each.description;
        elem.type = each.type;
        elem.url = each.url;
        elem.platform = each.platform;

        compDict[each.name] = elem;
      }

      Serializer ser = new Serializer();
      string contents = ser.Serialize(compDict);

      Encoding enc = Encoding.GetEncoding("UTF-8");
      string base64cont = Convert.ToBase64String(enc.GetBytes(contents));

      CommitDialog dialog = new CommitDialog();
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      string commitMessage = dialog.Message;

      UpdateContentsInfo param = new UpdateContentsInfo();
      param.message = commitMessage;
      param.content = base64cont;
      param.sha = this.systemSHA_;
      string param_contents = JSONUtil.Serialize(param);

      if (GitHandler.updateSystemProfile(targetUri, param_contents) == false) {
        MessageBox.Show("Wasanbonリポジトリの更新に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      MessageBox.Show("Wasanbonリポジトリを更新しました",
        CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void btnAdd_Click(object sender, EventArgs e) {
      SystemDialog dialog = new SystemDialog();
      dialog.IsNewRegist = true;
      dialog.ContentsList = this.contentsList_;
      dialog.GitHandler = this.GitHandler;
      dialog.RepositoryList = repositoryList_;
      dialog.SelectedRepository = cmbRep.Text.Trim();
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      this.contentsList_.Add(dialog.TargetInfo);
      showRegistered();
    }
    private void btnUpdateReg_Click(object sender, EventArgs e) {
      updateRegistered();
    }

    private void dgRegistered_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      updateRegistered();
    }
    private void updateRegistered() {
      if (dgRegistered.RowCount == 0 || this.contentsList_.Count == 0) return;
      int index = (int)dgRegistered.CurrentRow.Cells[0].Value;
      SystemContentsInfo target = this.contentsList_[index];

      SystemDialog dialog = new SystemDialog();
      dialog.TargetInfo = target;
      dialog.ContentsList = this.contentsList_;
      dialog.GitHandler = this.GitHandler;
      dialog.CanEdit = target.isNew;
      dialog.RepositoryList = repositoryList_;
      dialog.SelectedRepository = cmbRep.Text.Trim();
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      int current = this.dgRegistered.CurrentRow.Index;
      showRegistered();
      if (0 < this.dgRegistered.Rows.Count) {
        if (current < this.dgRegistered.Rows.Count) {
          this.dgRegistered.CurrentCell = this.dgRegistered.Rows[current].Cells[1];
        } else {
          this.dgRegistered.CurrentCell = this.dgRegistered.Rows[this.dgRegistered.Rows.Count - 1].Cells[1];
        }
      }
    }
    private void btnDelete_Click(object sender, EventArgs e) {
      if (dgRegistered.RowCount == 0 || this.contentsList_.Count == 0) return;
      int index = (int)dgRegistered.CurrentRow.Cells[0].Value;
      SystemContentsInfo target = this.contentsList_[index];

      DialogResult result = MessageBox.Show("【" + target.name + "】を削除してもよろしいですか？",
        CompDB_Const.TOOL_NAME,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (result != DialogResult.Yes) return;

      this.contentsList_.Remove(target);

      int current = this.dgRegistered.CurrentRow.Index;
      showRegistered();
      if (0 < this.dgRegistered.Rows.Count) {
        if (current < this.dgRegistered.Rows.Count) {
          this.dgRegistered.CurrentCell = this.dgRegistered.Rows[current].Cells[1];
        } else {
          this.dgRegistered.CurrentCell = this.dgRegistered.Rows[this.dgRegistered.Rows.Count - 1].Cells[1];
        }
      }
    }
    private void btnClose_Click(object sender, EventArgs e) {
      this.NextStatus = AppStatus.TOP_MENU;
      this.Close();
    }
  }
}
