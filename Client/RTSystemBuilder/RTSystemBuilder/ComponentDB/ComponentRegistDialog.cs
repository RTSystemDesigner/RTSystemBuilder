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

using System.Net;

using System.Xml;
using System.Xml.Linq;

namespace RTSystemBuilder {
  public partial class ComponentRegistDialog : Form {
    public gRPCWrapper gRPCHandler { set; private get; }
    public GitHubWrapper GitHandler { set; private get; }
    public CompAppInfo TargetComp { set; get; }
    public bool IsOK { private set; get; }
    public ComponentRegistDialog() {
      InitializeComponent();
    }

    private void ComponentRegistDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;
    }
    private void btnRef_Click(object sender, EventArgs e) {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
      ofd.Title = "登録するプロファイルを選択してください";
      ofd.RestoreDirectory = true;
      ofd.CheckFileExists = true;
      ofd.CheckPathExists = true;
      ofd.Multiselect = false;
      ofd.FileName = txtProfile.Text;
      if (ofd.ShowDialog() != DialogResult.OK) return;

      txtProfile.Text = ofd.FileName;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      if (txtName.Text.Length == 0) {
        MessageBox.Show("【登録名】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtName.Focus();
        return;
      }
      string strName = txtName.Text.Trim();
      if (txtRegistory.Text.Length == 0) {
        MessageBox.Show("【リポジトリURI】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtRegistory.Focus();
        return;
      }
      string strRepository = txtRegistory.Text.Trim();
      if (strRepository.StartsWith("https://github.com/") == false) {
        MessageBox.Show("【リポジトリURI】の指定が不正です",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtRegistory.Focus();
        return;
      }
      string strComment = txtComment.Text.Trim();

      string targetUri = strRepository.Substring(19);
      List<ContentsInfo> result;
      if (GitHandler.getContentsList(targetUri, out result) == false) {
        MessageBox.Show("指定されたリポジトリの情報取得に失敗しました",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      //List<CommitInfo> commits;
      //if (GitHandler.getCommitsList(targetUri, out commits) == false) {
      //  MessageBox.Show("指定されたリポジトリの情報取得に失敗しました",
      //    CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
      //  return;
      //}
      //if(commits.Count == 0) {
      //  MessageBox.Show("指定されたリポジトリの情報取得に失敗しました",
      //    CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
      //  return;
      //}
      //string strSha = commits[0].sha;

      if (txtProfile.Text.Length == 0) {
        try {
          ContentsInfo target = result.FirstOrDefault(c => c.name == "RTC.xml");
          if (target == null) {
            MessageBox.Show("指定されたリポジトリにはプロファイル情報が存在しません",
              CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          string profile;
          if (GitHandler.getRTCProfile(targetUri, out profile) == false) {
            MessageBox.Show("プロファイル情報の取得に失敗しました",
              CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          XElement xml = XElement.Load(new MemoryStream(Encoding.UTF8.GetBytes(profile)));
          CompAppInfo comp = CompDb_Util.parseXML(xml);

          comp.Name = strName;
          comp.Repository = strRepository;
          comp.Comment = strComment;
          string errMsg;
          uint ret = gRPCHandler.registComponent(comp, out errMsg);
          if (ret != CompDB_Const.STATUS_OK) {
            MessageBox.Show("コンポーネント情報の登録に失敗しました" + Environment.NewLine + errMsg,
            CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }

        } catch (WebException ex) {
          MessageBox.Show("コンポーネント情報の登録に失敗しました" + Environment.NewLine + ex.Message,
            CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

      } else {
        try {
          XElement xml = XElement.Load(txtProfile.Text);
          CompAppInfo comp = CompDb_Util.parseXML(xml);
          comp.Name = strName;
          comp.Repository = strRepository;
          comp.Comment = strComment;
          string errMsg;
          uint ret = gRPCHandler.registComponent(comp, out errMsg);
          if (ret != CompDB_Const.STATUS_OK) {
            MessageBox.Show("コンポーネント情報の登録に失敗しました" + Environment.NewLine + errMsg,
              CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }

        } catch (Exception ex) {
          MessageBox.Show("コンポーネント情報の登録に失敗しました" + Environment.NewLine + ex.Message,
            CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }

      this.IsOK = true;
      this.Close();
    }
  }
}
