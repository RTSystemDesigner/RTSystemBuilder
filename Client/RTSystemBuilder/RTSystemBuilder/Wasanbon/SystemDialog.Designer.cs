namespace RTSystemBuilder {
  partial class SystemDialog {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemDialog));
      this.lblTitle = new System.Windows.Forms.Label();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.chkWin = new System.Windows.Forms.CheckBox();
      this.chkUbuntu = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.chkMac = new System.Windows.Forms.CheckBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtURL = new System.Windows.Forms.TextBox();
      this.cmbRep = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.lblTitle.Location = new System.Drawing.Point(9, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(92, 21);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "システム追加";
      // 
      // txtDescription
      // 
      this.txtDescription.ImeMode = System.Windows.Forms.ImeMode.Disable;
      this.txtDescription.Location = new System.Drawing.Point(183, 102);
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(523, 114);
      this.txtDescription.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(131, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "概要：";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label8.ForeColor = System.Drawing.Color.Red;
      this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label8.Location = new System.Drawing.Point(100, 72);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(87, 20);
      this.label8.TabIndex = 1;
      this.label8.Text = "システム名：";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(624, 287);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(90, 30);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "キャンセル";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnOK.Location = new System.Drawing.Point(528, 287);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(90, 30);
      this.btnOK.TabIndex = 6;
      this.btnOK.TabStop = false;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label2.Location = new System.Drawing.Point(78, 259);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "プラットフォーム：";
      // 
      // chkWin
      // 
      this.chkWin.AutoSize = true;
      this.chkWin.Location = new System.Drawing.Point(183, 257);
      this.chkWin.Name = "chkWin";
      this.chkWin.Size = new System.Drawing.Size(89, 24);
      this.chkWin.TabIndex = 3;
      this.chkWin.Text = "Windows";
      this.chkWin.UseVisualStyleBackColor = true;
      // 
      // chkUbuntu
      // 
      this.chkUbuntu.AutoSize = true;
      this.chkUbuntu.Location = new System.Drawing.Point(383, 257);
      this.chkUbuntu.Name = "chkUbuntu";
      this.chkUbuntu.Size = new System.Drawing.Size(76, 24);
      this.chkUbuntu.TabIndex = 5;
      this.chkUbuntu.Text = "Ubuntu";
      this.chkUbuntu.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label4.ForeColor = System.Drawing.Color.Red;
      this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label4.Location = new System.Drawing.Point(135, 225);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 20);
      this.label4.TabIndex = 10;
      this.label4.Text = "URL：";
      // 
      // chkMac
      // 
      this.chkMac.AutoSize = true;
      this.chkMac.Location = new System.Drawing.Point(290, 257);
      this.chkMac.Name = "chkMac";
      this.chkMac.Size = new System.Drawing.Size(75, 24);
      this.chkMac.TabIndex = 4;
      this.chkMac.Text = "macOS";
      this.chkMac.UseVisualStyleBackColor = true;
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.txtName.Location = new System.Drawing.Point(183, 69);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(523, 27);
      this.txtName.TabIndex = 0;
      // 
      // txtURL
      // 
      this.txtURL.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.txtURL.Location = new System.Drawing.Point(183, 222);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(451, 27);
      this.txtURL.TabIndex = 2;
      // 
      // cmbRep
      // 
      this.cmbRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbRep.FormattingEnabled = true;
      this.cmbRep.Location = new System.Drawing.Point(183, 35);
      this.cmbRep.Name = "cmbRep";
      this.cmbRep.Size = new System.Drawing.Size(523, 28);
      this.cmbRep.TabIndex = 129;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label3.Location = new System.Drawing.Point(9, 38);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(173, 20);
      this.label3.TabIndex = 128;
      this.label3.Text = "WasanbonリポジトリURI：";
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnSearch.Location = new System.Drawing.Point(640, 220);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(66, 30);
      this.btnSearch.TabIndex = 130;
      this.btnSearch.TabStop = false;
      this.btnSearch.Text = "検索";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // SystemDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(727, 328);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.cmbRep);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtURL);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.chkMac);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.chkUbuntu);
      this.Controls.Add(this.chkWin);
      this.Controls.Add(this.txtDescription);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SystemDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RegisterdUpdateDialog";
      this.Load += new System.EventHandler(this.RegisterdUpdateDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox chkWin;
    private System.Windows.Forms.CheckBox chkUbuntu;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkMac;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtURL;
    private System.Windows.Forms.ComboBox cmbRep;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnSearch;
  }
}