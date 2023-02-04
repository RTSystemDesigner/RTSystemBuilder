namespace RTSystemBuilder {
  partial class TopMenu {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopMenu));
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnWasan = new System.Windows.Forms.Button();
      this.btnSystem = new System.Windows.Forms.Button();
      this.btnDB = new System.Windows.Forms.Button();
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnSetting = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.btnSetting);
      this.panel1.Controls.Add(this.btnClose);
      this.panel1.Controls.Add(this.btnWasan);
      this.panel1.Controls.Add(this.btnSystem);
      this.panel1.Controls.Add(this.btnDB);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Location = new System.Drawing.Point(73, 83);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(505, 209);
      this.panel1.TabIndex = 0;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(390, 166);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(90, 30);
      this.btnClose.TabIndex = 108;
      this.btnClose.Text = "終了";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnWasan
      // 
      this.btnWasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
      this.btnWasan.ForeColor = System.Drawing.Color.White;
      this.btnWasan.Location = new System.Drawing.Point(333, 69);
      this.btnWasan.Name = "btnWasan";
      this.btnWasan.Size = new System.Drawing.Size(147, 80);
      this.btnWasan.TabIndex = 107;
      this.btnWasan.Text = "Wasanbon\r\n連携";
      this.btnWasan.UseVisualStyleBackColor = false;
      this.btnWasan.Click += new System.EventHandler(this.btnWasan_Click);
      // 
      // btnSystem
      // 
      this.btnSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
      this.btnSystem.ForeColor = System.Drawing.Color.White;
      this.btnSystem.Location = new System.Drawing.Point(176, 69);
      this.btnSystem.Name = "btnSystem";
      this.btnSystem.Size = new System.Drawing.Size(147, 80);
      this.btnSystem.TabIndex = 106;
      this.btnSystem.Text = "システム構築";
      this.btnSystem.UseVisualStyleBackColor = false;
      this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
      // 
      // btnDB
      // 
      this.btnDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
      this.btnDB.ForeColor = System.Drawing.Color.White;
      this.btnDB.Location = new System.Drawing.Point(23, 69);
      this.btnDB.Name = "btnDB";
      this.btnDB.Size = new System.Drawing.Size(147, 80);
      this.btnDB.TabIndex = 105;
      this.btnDB.Text = "コンポーネント情報\r\n管理";
      this.btnDB.UseVisualStyleBackColor = false;
      this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
      // 
      // lblTitle
      // 
      this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTitle.AutoSize = true;
      this.lblTitle.BackColor = System.Drawing.Color.White;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold);
      this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitle.Location = new System.Drawing.Point(76, 20);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(365, 37);
      this.lblTitle.TabIndex = 104;
      this.lblTitle.Text = "利用する機能を選択してください";
      // 
      // btnSetting
      // 
      this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnSetting.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnSetting.Location = new System.Drawing.Point(23, 166);
      this.btnSetting.Name = "btnSetting";
      this.btnSetting.Size = new System.Drawing.Size(90, 30);
      this.btnSetting.TabIndex = 109;
      this.btnSetting.Text = "設定";
      this.btnSetting.UseVisualStyleBackColor = false;
      this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
      // 
      // TopMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(624, 375);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TopMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "TopMenu";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopMenu_FormClosing);
      this.Load += new System.EventHandler(this.TopMenu_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnWasan;
    private System.Windows.Forms.Button btnSystem;
    private System.Windows.Forms.Button btnDB;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSetting;
  }
}