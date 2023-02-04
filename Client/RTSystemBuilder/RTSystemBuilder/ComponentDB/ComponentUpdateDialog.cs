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
  public partial class ComponentUpdateDialog : Form {
    public gRPCWrapper gRPCHandler { set; private get; }
    public GitHubWrapper GitHandler { set; private get; }
    public CompAppInfo TargetComp { set; get; }
    public bool IsOK { private set; get; }
    public ComponentUpdateDialog() {
      InitializeComponent();
    }

    private void ComponentUpdateDialog_Load(object sender, EventArgs e) {
      this.Text = CompDB_Const.TOOL_NAME;

      txtName.Text = TargetComp.Name;
      txtRegistory.Text = TargetComp.Repository;
      txtComment.Text = TargetComp.Comment;
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      this.IsOK = false;
      this.Close();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      if (txtName.Text.Length == 0) {
        MessageBox.Show("【登録名】が指定されていません",
          CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtRegistory.Focus();
        return;
      }
      string strName = txtName.Text.Trim();
      string strComment = txtComment.Text.Trim();
      CompAppInfo currentComp = null;

      if (chkProfile.Checked) {
        string strRepository = txtRegistory.Text.Trim();
        string targetUri = strRepository.Substring(19);
        try {
          List<ContentsInfo> result;
          if (GitHandler.getContentsList(targetUri, out result) == false) {
            MessageBox.Show("指定されたリポジトリの情報取得に失敗しました",
              CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
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
          currentComp = CompDb_Util.parseXML(xml);
          currentComp.Id = TargetComp.Id;
          currentComp.Repository = TargetComp.Repository;
          TargetComp = currentComp;

        } catch (WebException ex) {
          MessageBox.Show("コンポーネント情報の取得に失敗しました" + Environment.NewLine + ex.Message,
            CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }

      bool isUpdate = chkProfile.Checked;
      TargetComp.Name = strName;
      TargetComp.Comment = strComment;

      string errMsg;
      uint ret = gRPCHandler.updateComponent(TargetComp.Id, TargetComp, isUpdate, out errMsg);
      if (ret != CompDB_Const.STATUS_OK) {
        MessageBox.Show("コンポーネント情報の更新に失敗しました" + Environment.NewLine + errMsg,
        CompDB_Const.TOOL_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      this.IsOK = true;
      this.Close();
    }
  }
}
