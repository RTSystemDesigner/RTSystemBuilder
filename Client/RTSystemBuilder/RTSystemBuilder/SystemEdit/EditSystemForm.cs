using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using YamlDotNet.Serialization;

using RTSystemBuilder.SystemEdit;

namespace RTSystemBuilder {
  public partial class EditSystemForm : Form {
    public gRPCWrapper gRPCHandler { set; private get; }
    public GitHubWrapper GitHandler { set; private get; }
    public AppStatus NextStatus { private set; get; }
    public WasanbonRegistInfo RegistInfo { private set; get; }

    private List<CompAppInfo> componentList_ = new List<CompAppInfo>();
    private List<SystemCompInfo> contentsList_ = new List<SystemCompInfo>();
    private ComponentSearchCondition cond_ = new ComponentSearchCondition();

    public EditSystemForm() {
      InitializeComponent();
    }

    private void CompDBMain_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      btnClear.Enabled = false;
      btnSetSys.Enabled = false;
      btnDelete.Enabled = false;
      btnRegist.Enabled = false;

      List<string> repositoryList;
      if(CompDb_Util.getSystemRepositories(out repositoryList) == false) {
        MessageBox.Show("ベースリポジトリ情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if (repositoryList.Count == 0) {
        MessageBox.Show("Wasanbonリポジトリ情報が登録されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      cmbSysRep.Items.Clear();
      for (int index = 0; index < repositoryList.Count; index++) {
        cmbSysRep.Items.Add(repositoryList[index]);
      }
      cmbSysRep.SelectedIndex = 0;

      showCompList();

      //TODO ダミー
      txtSysName.Text = "MarkerPoseEstimation";

      showRegistered();
    }
    private void btnNewSys_Click(object sender, EventArgs e) {
      string strRepository = cmbSysRep.Text.Trim();
      if (strRepository.StartsWith("https://github.com/") == false) {
        MessageBox.Show("【WasanbonリポジトリURI】の指定が不正です",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (txtSysName.Text.Trim().Length == 0) {
        MessageBox.Show("【システム名】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtSysName.Focus();
        return;
      }
      string targetName = txtSysName.Text.Trim();

      string targetOrg = strRepository.Substring(19);
      if (targetOrg.EndsWith("/")) {
        targetOrg = targetOrg.Remove(targetOrg.Length - 1);
      }

      if (GitHandler.checkRepositoryExists(targetOrg, targetName)) {
        MessageBox.Show("指定されたリポジトリはすでに存在します" + Environment.NewLine
                        + "もしくはリポジトリ情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtSysName.Focus();
        return;
      }

      if (GitHandler.addRepository(targetOrg, targetName) == false) {
        MessageBox.Show("指定されたリポジトリの追加に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      setEditMode();
    }

    private void btnGetSys_Click(object sender, EventArgs e) {
      this.Cursor = Cursors.WaitCursor;
      string strRepository = cmbSysRep.Text.Trim();
      if (strRepository.StartsWith("https://github.com/") == false) {
        this.Cursor = Cursors.Arrow;
        MessageBox.Show("【WasanbonリポジトリURI】の指定が不正です",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (txtSysName.Text.Trim().Length == 0) {
        this.Cursor = Cursors.Arrow;
        MessageBox.Show("【システム名】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtSysName.Focus();
        return;
      }

      string targetUri = strRepository.Substring(19);
      if (targetUri.EndsWith("/")) {
        targetUri = targetUri.Remove(targetUri.Length - 1);
      }
      string strName = txtSysName.Text.Trim();
      if (GitHandler.checkRepositoryExists(targetUri, strName) == false) {
        this.Cursor = Cursors.Arrow;
        MessageBox.Show("指定されたリポジトリが存在しません"+ Environment.NewLine
                        + "もしくはリポジトリ情報の取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtSysName.Focus();
        return;
      }

      targetUri = targetUri + "/" + strName;

      string strRepositoryYaml;
      GitHandler.getFile(targetUri, "rtc/repository.yaml", out strRepositoryYaml);

      string strCppConf;
      GitHandler.getFile(targetUri, "conf/rtc_cpp.conf", out strCppConf);
      List<string> cppComps = getRegisteredComp(strCppConf);

      string strJavaConf;
      GitHandler.getFile(targetUri, "conf/rtc_java.conf", out strJavaConf);
      List<string> javaComps = getRegisteredComp(strJavaConf);

      string strPyConf;
      GitHandler.getFile(targetUri, "conf/rtc_py.conf", out strPyConf);
      List<string> pyComps = getRegisteredComp(strPyConf);

      contentsList_.Clear();
      if (strRepositoryYaml != null && 0 < strRepositoryYaml.Length) {
        Deserializer deser = new Deserializer();
        Dictionary<string, RtcRepositoryInfo> sysDef = deser.Deserialize<Dictionary<string, RtcRepositoryInfo>>(strRepositoryYaml);
        foreach (string each in sysDef.Keys) {
          RtcRepositoryInfo info = sysDef[each];
          SystemCompInfo comp = new SystemCompInfo();
          comp.Name = each;
          comp.Description = info.description;
          comp.Url = info.git;
          comp.Hash = info.hash;
          comp.RepoName = info.repo_name;

          if(cppComps.Contains(comp.Name)) {
            comp.Language = CompDB_Const.LANG_CPP;
          } else if (javaComps.Contains(comp.Name)) {
            comp.Language = CompDB_Const.LANG_JAVA;
          } else if (pyComps.Contains(comp.Name)) {
            comp.Language = CompDB_Const.LANG_PYTHON;
          }

          contentsList_.Add(comp);
        }
      }

      showRegistered();

      setEditMode();

      this.Cursor = Cursors.Arrow;
      MessageBox.Show("指定されたリポジトリの情報を取得しました",
        CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private List<string> getRegisteredComp(string source) {
      List<string> result = new List<string>();

      string[] lines = source.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);
      string targetLine = lines.FirstOrDefault(c => c.StartsWith("manager.components.precreate:"));
      if (targetLine != null) {
        string[] elems = targetLine.Split(':');
        if (2 <= elems.Length) {
          string[] rtcs = elems[1].Split(',');
          foreach(string each in rtcs) {
            string cand = each.Trim();
            if(0<cand.Length) {
              result.Add(cand);
            }
          }
        }
      }

      return result;
    }
    private void btnClear_Click(object sender, EventArgs e) {
      clearEditMode();
    }

    private void setEditMode() {
      btnNewSys.Enabled = false;
      btnGetSys.Enabled = false;

      btnClear.Enabled = true;
      btnSetSys.Enabled = true;

      cmbSysRep.Enabled = false;
      txtSysName.Enabled = false;

    }
    private void clearEditMode() {
      btnNewSys.Enabled = true;
      btnGetSys.Enabled = true;

      contentsList_.Clear();
      showRegistered();

      btnClear.Enabled = false;
      btnSetSys.Enabled = false;

      cmbSysRep.Enabled = true;
      txtSysName.Enabled = true;

    }
    private void showRegistered() {
      this.dgSystem.Rows.Clear();

      for (int index = 0; index < this.contentsList_.Count; index++) {
        SystemCompInfo each = this.contentsList_[index];
        this.dgSystem.Rows.Add(index, each.Name,
                                      each.Description,
                                      each.Url);
        if (each.IsUpdated) {
          this.dgSystem.Rows[this.dgSystem.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightPink;
        }
      }

      if (this.dgSystem.Rows.Count == 0) {
        btnDelete.Enabled = false;
        btnUpdateSys.Enabled = false;
      } else {
        btnDelete.Enabled = true;
        btnUpdateSys.Enabled = true;
      }
    }
    private void btnSetSys_Click(object sender, EventArgs e) {
      SystemRegistDialog dialog = new SystemRegistDialog();
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      this.Cursor = Cursors.WaitCursor;

      string strDesc = dialog.Description;
      string strNS = dialog.NameService;
      string strCommitMsg = dialog.CommitMessage;
      string strSysName = txtSysName.Text.Trim();
      string strRepository = cmbSysRep.Text.Trim();

      string targetUri = strRepository.Substring(19);
      if (targetUri.EndsWith("/")) {
        targetUri = targetUri.Remove(targetUri.Length - 1);
      }
      if (updateSettingYaml(strSysName, strNS, targetUri, strCommitMsg) == false) {
        this.Cursor = Cursors.Arrow;
        return;
      }
      if (updateReadMeMd(strSysName, strDesc, targetUri, strCommitMsg) == false) {
        this.Cursor = Cursors.Arrow;
        return;
      }

      List<string> cppComps = new List<string>();
      List<string> javaComps = new List<string>();
      List<string> pyComps = new List<string>();
      if (updateComponentInfo(strSysName, targetUri, strCommitMsg, ref cppComps, ref javaComps, ref pyComps) == false) {
        this.Cursor = Cursors.Arrow;
        return;
      }

      if (updateManagerConf(cppComps, strSysName, targetUri, "conf/rtc_cpp.conf", strCommitMsg) == false) {
        this.Cursor = Cursors.Arrow;
        return;
      }
      if (updateManagerConf(javaComps, strSysName, targetUri, "conf/rtc_java.conf", strCommitMsg) == false) {
        this.Cursor = Cursors.Arrow;
        return;
      }
      if (updateManagerConf(pyComps, strSysName, targetUri, "conf/rtc_py.conf", strCommitMsg) == false) {
        this.Cursor = Cursors.Arrow;
        return;
      }
      //////////
      if (strRepository.EndsWith("/") == false) {
        strRepository = strRepository + "/";
      }
      strRepository = strRepository + strSysName + ".git";

      this.RegistInfo = new WasanbonRegistInfo();
      this.RegistInfo.Url = strRepository;
      this.RegistInfo.SystemName = txtSysName.Text.Trim();
      this.NextStatus = AppStatus.WASANBON_REGIST;
      this.Cursor = Cursors.Arrow;
      this.Close();
    }

    private bool updateManagerConf(List<string> comps, string sysName, string targetUri, string path, string commitMsg) {
      string confBase = System.Text.Encoding.UTF8.GetString(Properties.Resources.manager);
      StringBuilder builder = new StringBuilder();
      builder.Append(confBase);

      if (0 < comps.Count) {
        string strRtcs = string.Join(", ", comps);
        builder.Append(Environment.NewLine);
        builder.Append("manager.modules.load_path:bin").Append(Environment.NewLine);
        builder.Append("manager.modules.preload:").Append(strRtcs).Append(Environment.NewLine);
        builder.Append("manager.components.precreate:").Append(strRtcs).Append(Environment.NewLine);
        foreach(string each in comps) {
          builder.Append(each + "0").Append(".config_file:conf/").Append(each + "0").Append(".conf").Append(Environment.NewLine);
        }
      }
      string aaa = builder.ToString();

      if (GitHandler.updateContents(targetUri, sysName, path, builder.ToString(), commitMsg) == false) {
        MessageBox.Show("リポジトリの更新に失敗しました [" + path + "]",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private bool updateComponentInfo(string sysName, string targetUri, string commitMsg,
                                      ref List<string> cppComps, ref List<string> javaComps, ref List<string> pyComps) {
      Dictionary<string, RtcContentsInfo> compDict = new Dictionary<string, RtcContentsInfo>();
      foreach (SystemCompInfo each in this.contentsList_) {
        string eachUri = each.Url.Substring(19);
        if (eachUri.EndsWith(".git")) {
          eachUri = eachUri.Remove(eachUri.Length - 4);
        }

        string confName = each.Name + ".conf";
        string confContents;
        if (GitHandler.getFile(eachUri, confName, out confContents) == false) continue;

        string confNewName = "conf/" + each.Name + "0.conf";
        if (GitHandler.updateContents(targetUri, sysName, confNewName, confContents, commitMsg) == false) continue;
        /////
        switch (each.Language) {
          case CompDB_Const.LANG_CPP:
            cppComps.Add(each.Name);
            break;
          case CompDB_Const.LANG_JAVA:
            javaComps.Add(each.Name);
            break;
          case CompDB_Const.LANG_PYTHON:
            pyComps.Add(each.Name);
            break;
        }
        /////
        RtcContentsInfo elem = new RtcContentsInfo();
        elem.description = each.Description;
        elem.git = each.Url;
        elem.repo_name = each.Name;

        List<CommitInfo> commits;
        if (GitHandler.getCommitsList(eachUri, out commits) == false) continue;
        if (commits.Count == 0) continue;
        elem.hash = commits[0].sha;

        compDict[each.Name] = elem;
      }

      Serializer ser = new Serializer();
      string contents = ser.Serialize(compDict);

      if (GitHandler.updateContents(targetUri, sysName, "rtc/repository.yaml", contents, commitMsg) == false) {
        MessageBox.Show("リポジトリの更新に失敗しました [rtc/repository.yaml]",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    private bool updateReadMeMd(string sysName, string sysDesc, string targetUri, string commitMsg) {
      StringBuilder builder = new StringBuilder();
      builder.Append("# ").Append(sysName).Append(Environment.NewLine);
      builder.Append(sysName).Append(Environment.NewLine);
      builder.Append(Environment.NewLine);
      builder.Append(sysDesc).Append(Environment.NewLine);

      if (GitHandler.updateContents(targetUri, sysName, "README.md", builder.ToString(), commitMsg) == false) {
        MessageBox.Show("リポジトリの更新に失敗しました [README.md]",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }
    private bool updateSettingYaml(string sysName, string nameSrv, string targetUri, string commitMsg) {
      StringBuilder builder = new StringBuilder();
      builder.Append("application :").Append(Environment.NewLine);
      builder.Append("  name : ").Append(sysName).Append(Environment.NewLine);
      builder.Append("  BIN_DIR : bin").Append(Environment.NewLine);
      builder.Append("  RTC_DIR : rtc").Append(Environment.NewLine);
      builder.Append("  RTS_DIR : system").Append(Environment.NewLine);
      builder.Append("  CONF_DIR : conf").Append(Environment.NewLine);
      builder.Append("  conf.C++ : rtc_cpp.conf").Append(Environment.NewLine);
      builder.Append("  conf.Python  : rtc_py.conf").Append(Environment.NewLine);
      builder.Append("  conf.Java: rtc_java.conf").Append(Environment.NewLine);
      builder.Append("  system : DefaultSystem.xml").Append(Environment.NewLine);
      builder.Append("  console_bind : ['C++', 'Java', 'Python']").Append(Environment.NewLine);
      builder.Append("  nameservers :").Append(Environment.NewLine);
      builder.Append("    - ").Append(nameSrv).Append(Environment.NewLine);

      if (GitHandler.updateContents(targetUri, sysName, "setting.yaml", builder.ToString(), commitMsg) == false) {
        MessageBox.Show("リポジトリの更新に失敗しました [setting.yaml]",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }
    private void btnUpdateSys_Click(object sender, EventArgs e) {
      updateSys();
    }
    private void dgSystem_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      updateSys();
    }
    private void updateSys() {
      if (dgSystem.RowCount == 0) return;
      int index = (int)dgSystem.CurrentRow.Cells[0].Value;
      SystemCompInfo target = this.contentsList_[index];

      DescriptionDialog dialog = new DescriptionDialog();
      dialog.TargetComp = target;
      dialog.ShowDialog();
      if (dialog.IsOK == false) return;

      int current = this.dgSystem.CurrentRow.Index;
      showRegistered();
      this.dgSystem.CurrentCell = this.dgSystem.Rows[current].Cells[1];
    }
    private void btnDelete_Click(object sender, EventArgs e) {
      if (dgSystem.RowCount == 0) return;
      int index = (int)dgSystem.CurrentRow.Cells[0].Value;
      SystemCompInfo target = this.contentsList_[index];

      DialogResult result = MessageBox.Show("【" + target.Name + "】を削除してもよろしいですか？",
        CompDB_Const.TOOL_NAME,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (result != DialogResult.Yes) return;

      this.contentsList_.Remove(target);

      int current = this.dgSystem.CurrentRow.Index;
      showRegistered();
      if (0 < this.dgSystem.Rows.Count) {
        if (current < this.dgSystem.Rows.Count) {
          this.dgSystem.CurrentCell = this.dgSystem.Rows[current].Cells[1];
        } else {
          this.dgSystem.CurrentCell = this.dgSystem.Rows[this.dgSystem.Rows.Count - 1].Cells[1];
        }
      }
    }
    //////////
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
        btnRegist.Enabled = false;
      } else {
        btnRegist.Enabled = true;
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
    private bool searchComponent() {
      List<CompAppInfo> result;
      if (gRPCHandler.searchComponent(cond_, out result) != CompDB_Const.STATUS_OK) {
        return false;
      }
      this.componentList_ = result;
      return true;
    }
    private void btnResist_Click(object sender, EventArgs e) {
      if (dgComponent.RowCount == 0) return;
      ulong id = (ulong)dgComponent.CurrentRow.Cells[0].Value;
      CompAppInfo target = componentList_.FirstOrDefault(n => n.Id == id);
      if (target == null) return;

      SystemCompInfo existed = contentsList_.FirstOrDefault(c => c.Name == target.ComponentName && c.Url == target.Repository + ".git");
      if(existed != null) {
        MessageBox.Show("【コンポーネント名】と【URL】が同一の要素がすでに登録されています",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      SystemCompInfo info = new SystemCompInfo();
      info.Name = target.ComponentName;
      info.Url = target.Repository + ".git";
      info.Language = target.Language;
      string[] elems = target.Repository.Split('/');
      info.RepoName = elems[elems.Length - 1];
      info.IsUpdated = true;

      this.contentsList_.Add(info);

      showRegistered();
    }

    private void btnClose_Click(object sender, EventArgs e) {
      this.NextStatus = AppStatus.TOP_MENU;
      this.Close();
    }
  }
}
