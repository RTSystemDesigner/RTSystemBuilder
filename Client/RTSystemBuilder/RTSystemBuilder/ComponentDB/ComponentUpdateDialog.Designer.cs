namespace RTSystemBuilder {
  partial class ComponentUpdateDialog {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentUpdateDialog));
      this.txtComment = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.txtRegistory = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.chkProfile = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(122, 143);
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(545, 88);
      this.txtComment.TabIndex = 21;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label3.Location = new System.Drawing.Point(49, 146);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 20);
      this.label3.TabIndex = 20;
      this.label3.Text = "コメント：";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(121, 45);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(372, 27);
      this.txtName.TabIndex = 14;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label2.Location = new System.Drawing.Point(46, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 20);
      this.label2.TabIndex = 13;
      this.label2.Text = "登録名：";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.lblTitle.Location = new System.Drawing.Point(11, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(127, 21);
      this.lblTitle.TabIndex = 12;
      this.lblTitle.Text = "コンポーネント更新";
      // 
      // txtRegistory
      // 
      this.txtRegistory.Location = new System.Drawing.Point(121, 78);
      this.txtRegistory.Name = "txtRegistory";
      this.txtRegistory.ReadOnly = true;
      this.txtRegistory.Size = new System.Drawing.Size(545, 27);
      this.txtRegistory.TabIndex = 19;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(11, 81);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 20);
      this.label1.TabIndex = 18;
      this.label1.Text = "リポジトリURI：";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(576, 239);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(90, 30);
      this.btnCancel.TabIndex = 23;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "キャンセル";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnOK.Location = new System.Drawing.Point(480, 239);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(90, 30);
      this.btnOK.TabIndex = 22;
      this.btnOK.TabStop = false;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // chkProfile
      // 
      this.chkProfile.AutoSize = true;
      this.chkProfile.Location = new System.Drawing.Point(123, 113);
      this.chkProfile.Name = "chkProfile";
      this.chkProfile.Size = new System.Drawing.Size(178, 24);
      this.chkProfile.TabIndex = 24;
      this.chkProfile.Text = "プロファイル情報を再確認";
      this.chkProfile.UseVisualStyleBackColor = true;
      // 
      // ComponentUpdateDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(679, 276);
      this.Controls.Add(this.chkProfile);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.txtRegistory);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ComponentUpdateDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ComponentUpdateDialog";
      this.Load += new System.EventHandler(this.ComponentUpdateDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtRegistory;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.CheckBox chkProfile;
  }
}