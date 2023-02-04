namespace RTSystemBuilder {
  partial class ComponentRegistDialog {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentRegistDialog));
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.txtProfile = new System.Windows.Forms.TextBox();
      this.txtRegistory = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnRef = new System.Windows.Forms.Button();
      this.lblTitle = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnOK.Location = new System.Drawing.Point(481, 240);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(90, 30);
      this.btnOK.TabIndex = 10;
      this.btnOK.TabStop = false;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(577, 240);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(90, 30);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "キャンセル";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label8.Location = new System.Drawing.Point(28, 82);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(88, 20);
      this.label8.TabIndex = 3;
      this.label8.Text = "プロファイル：";
      // 
      // txtProfile
      // 
      this.txtProfile.Location = new System.Drawing.Point(122, 79);
      this.txtProfile.Name = "txtProfile";
      this.txtProfile.Size = new System.Drawing.Size(450, 27);
      this.txtProfile.TabIndex = 4;
      // 
      // txtRegistory
      // 
      this.txtRegistory.Location = new System.Drawing.Point(122, 112);
      this.txtRegistory.Name = "txtRegistory";
      this.txtRegistory.Size = new System.Drawing.Size(545, 27);
      this.txtRegistory.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(12, 115);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 20);
      this.label1.TabIndex = 6;
      this.label1.Text = "リポジトリURI：";
      // 
      // btnRef
      // 
      this.btnRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnRef.Location = new System.Drawing.Point(578, 77);
      this.btnRef.Name = "btnRef";
      this.btnRef.Size = new System.Drawing.Size(90, 30);
      this.btnRef.TabIndex = 5;
      this.btnRef.Text = "参照";
      this.btnRef.UseVisualStyleBackColor = false;
      this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.lblTitle.Location = new System.Drawing.Point(12, 9);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(127, 21);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "コンポーネント登録";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(122, 46);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(372, 27);
      this.txtName.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label2.Location = new System.Drawing.Point(47, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "登録名：";
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(123, 145);
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(545, 88);
      this.txtComment.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label3.Location = new System.Drawing.Point(50, 148);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 20);
      this.label3.TabIndex = 8;
      this.label3.Text = "コメント：";
      // 
      // ComponentRegistDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(679, 276);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.btnRef);
      this.Controls.Add(this.txtRegistory);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtProfile);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ComponentRegistDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ComponentRegistDialog";
      this.Load += new System.EventHandler(this.ComponentRegistDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtProfile;
    private System.Windows.Forms.TextBox txtRegistory;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnRef;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Label label3;
  }
}