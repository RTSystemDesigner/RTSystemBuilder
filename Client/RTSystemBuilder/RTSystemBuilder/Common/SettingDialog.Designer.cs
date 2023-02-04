namespace RTSystemBuilder {
  partial class SettingDialog {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingDialog));
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtIP = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.btnDownWa = new System.Windows.Forms.Button();
      this.btnUpWa = new System.Windows.Forms.Button();
      this.btnDeleteWa = new System.Windows.Forms.Button();
      this.btnUpdateWa = new System.Windows.Forms.Button();
      this.btnAddWa = new System.Windows.Forms.Button();
      this.dgWasanbon = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btnDownBase = new System.Windows.Forms.Button();
      this.btnUpBase = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.dgBase = new System.Windows.Forms.DataGridView();
      this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtToken = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtUserId = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgWasanbon)).BeginInit();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgBase)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.lblTitle.Location = new System.Drawing.Point(8, 10);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(74, 21);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "設定情報";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(472, 586);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(90, 30);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "キャンセル";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnOK.Location = new System.Drawing.Point(376, 586);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(90, 30);
      this.btnOK.TabIndex = 3;
      this.btnOK.TabStop = false;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtPort);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtIP);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Location = new System.Drawing.Point(12, 34);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(553, 65);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "データベース設定";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(422, 26);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(125, 27);
      this.txtPort.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(335, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "ポート番号：";
      // 
      // txtIP
      // 
      this.txtIP.Location = new System.Drawing.Point(94, 26);
      this.txtIP.Name = "txtIP";
      this.txtIP.Size = new System.Drawing.Size(235, 27);
      this.txtIP.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label8.Location = new System.Drawing.Point(13, 29);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(81, 20);
      this.label8.TabIndex = 0;
      this.label8.Text = "IPアドレス：";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.txtUserId);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.groupBox4);
      this.groupBox2.Controls.Add(this.groupBox3);
      this.groupBox2.Controls.Add(this.txtToken);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(12, 102);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(553, 478);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "GitHub設定";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.btnDownWa);
      this.groupBox4.Controls.Add(this.btnUpWa);
      this.groupBox4.Controls.Add(this.btnDeleteWa);
      this.groupBox4.Controls.Add(this.btnUpdateWa);
      this.groupBox4.Controls.Add(this.btnAddWa);
      this.groupBox4.Controls.Add(this.dgWasanbon);
      this.groupBox4.Location = new System.Drawing.Point(6, 282);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(541, 191);
      this.groupBox4.TabIndex = 5;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Wasanbon binderリポジトリURI";
      // 
      // btnDownWa
      // 
      this.btnDownWa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDownWa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnDownWa.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnDownWa.Location = new System.Drawing.Point(507, 113);
      this.btnDownWa.Name = "btnDownWa";
      this.btnDownWa.Size = new System.Drawing.Size(30, 30);
      this.btnDownWa.TabIndex = 5;
      this.btnDownWa.Text = "▼";
      this.btnDownWa.UseVisualStyleBackColor = false;
      this.btnDownWa.Click += new System.EventHandler(this.btnDownWa_Click);
      // 
      // btnUpWa
      // 
      this.btnUpWa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnUpWa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnUpWa.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnUpWa.Location = new System.Drawing.Point(507, 79);
      this.btnUpWa.Name = "btnUpWa";
      this.btnUpWa.Size = new System.Drawing.Size(30, 30);
      this.btnUpWa.TabIndex = 4;
      this.btnUpWa.Text = "▲";
      this.btnUpWa.UseVisualStyleBackColor = false;
      this.btnUpWa.Click += new System.EventHandler(this.btnUpWa_Click);
      // 
      // btnDeleteWa
      // 
      this.btnDeleteWa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDeleteWa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnDeleteWa.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnDeleteWa.Location = new System.Drawing.Point(411, 14);
      this.btnDeleteWa.Name = "btnDeleteWa";
      this.btnDeleteWa.Size = new System.Drawing.Size(90, 30);
      this.btnDeleteWa.TabIndex = 2;
      this.btnDeleteWa.Text = "削除";
      this.btnDeleteWa.UseVisualStyleBackColor = false;
      this.btnDeleteWa.Click += new System.EventHandler(this.btnDeleteWa_Click);
      // 
      // btnUpdateWa
      // 
      this.btnUpdateWa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnUpdateWa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnUpdateWa.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnUpdateWa.Location = new System.Drawing.Point(315, 14);
      this.btnUpdateWa.Name = "btnUpdateWa";
      this.btnUpdateWa.Size = new System.Drawing.Size(90, 30);
      this.btnUpdateWa.TabIndex = 1;
      this.btnUpdateWa.Text = "更新";
      this.btnUpdateWa.UseVisualStyleBackColor = false;
      this.btnUpdateWa.Click += new System.EventHandler(this.btnUpdateWa_Click);
      // 
      // btnAddWa
      // 
      this.btnAddWa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddWa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnAddWa.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnAddWa.Location = new System.Drawing.Point(219, 14);
      this.btnAddWa.Name = "btnAddWa";
      this.btnAddWa.Size = new System.Drawing.Size(90, 30);
      this.btnAddWa.TabIndex = 0;
      this.btnAddWa.Text = "追加";
      this.btnAddWa.UseVisualStyleBackColor = false;
      this.btnAddWa.Click += new System.EventHandler(this.btnAddWa_Click);
      // 
      // dgWasanbon
      // 
      this.dgWasanbon.AllowUserToAddRows = false;
      this.dgWasanbon.AllowUserToDeleteRows = false;
      this.dgWasanbon.AllowUserToResizeRows = false;
      this.dgWasanbon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgWasanbon.BackgroundColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgWasanbon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgWasanbon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgWasanbon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
      this.dgWasanbon.EnableHeadersVisualStyles = false;
      this.dgWasanbon.Location = new System.Drawing.Point(11, 48);
      this.dgWasanbon.MultiSelect = false;
      this.dgWasanbon.Name = "dgWasanbon";
      this.dgWasanbon.ReadOnly = true;
      this.dgWasanbon.RowHeadersVisible = false;
      this.dgWasanbon.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
      this.dgWasanbon.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgWasanbon.RowTemplate.Height = 25;
      this.dgWasanbon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgWasanbon.Size = new System.Drawing.Size(490, 133);
      this.dgWasanbon.TabIndex = 3;
      this.dgWasanbon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWasanbon_CellDoubleClick);
      this.dgWasanbon.SelectionChanged += new System.EventHandler(this.dgWasanbon_SelectionChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "URI";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 460;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.btnDownBase);
      this.groupBox3.Controls.Add(this.btnUpBase);
      this.groupBox3.Controls.Add(this.btnDelete);
      this.groupBox3.Controls.Add(this.btnUpdate);
      this.groupBox3.Controls.Add(this.btnAdd);
      this.groupBox3.Controls.Add(this.dgBase);
      this.groupBox3.Location = new System.Drawing.Point(6, 88);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(541, 191);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "システム構築時ベースリポジトリURI";
      // 
      // btnDownBase
      // 
      this.btnDownBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDownBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnDownBase.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnDownBase.Location = new System.Drawing.Point(507, 113);
      this.btnDownBase.Name = "btnDownBase";
      this.btnDownBase.Size = new System.Drawing.Size(30, 30);
      this.btnDownBase.TabIndex = 5;
      this.btnDownBase.Text = "▼";
      this.btnDownBase.UseVisualStyleBackColor = false;
      this.btnDownBase.Click += new System.EventHandler(this.btnDownBase_Click);
      // 
      // btnUpBase
      // 
      this.btnUpBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnUpBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnUpBase.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnUpBase.Location = new System.Drawing.Point(507, 79);
      this.btnUpBase.Name = "btnUpBase";
      this.btnUpBase.Size = new System.Drawing.Size(30, 30);
      this.btnUpBase.TabIndex = 4;
      this.btnUpBase.Text = "▲";
      this.btnUpBase.UseVisualStyleBackColor = false;
      this.btnUpBase.Click += new System.EventHandler(this.btnUpBase_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnDelete.Location = new System.Drawing.Point(411, 14);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(90, 30);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "削除";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnUpdate.Location = new System.Drawing.Point(315, 14);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(90, 30);
      this.btnUpdate.TabIndex = 1;
      this.btnUpdate.Text = "更新";
      this.btnUpdate.UseVisualStyleBackColor = false;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnAdd.Location = new System.Drawing.Point(219, 14);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(90, 30);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "追加";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // dgBase
      // 
      this.dgBase.AllowUserToAddRows = false;
      this.dgBase.AllowUserToDeleteRows = false;
      this.dgBase.AllowUserToResizeRows = false;
      this.dgBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgBase.BackgroundColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9});
      this.dgBase.EnableHeadersVisualStyles = false;
      this.dgBase.Location = new System.Drawing.Point(11, 48);
      this.dgBase.MultiSelect = false;
      this.dgBase.Name = "dgBase";
      this.dgBase.ReadOnly = true;
      this.dgBase.RowHeadersVisible = false;
      this.dgBase.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
      this.dgBase.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgBase.RowTemplate.Height = 25;
      this.dgBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgBase.Size = new System.Drawing.Size(490, 133);
      this.dgBase.TabIndex = 3;
      this.dgBase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBase_CellDoubleClick);
      this.dgBase.SelectionChanged += new System.EventHandler(this.dgBase_SelectionChanged);
      // 
      // Column9
      // 
      this.Column9.HeaderText = "URI";
      this.Column9.Name = "Column9";
      this.Column9.ReadOnly = true;
      this.Column9.Width = 460;
      // 
      // txtToken
      // 
      this.txtToken.Location = new System.Drawing.Point(119, 55);
      this.txtToken.Name = "txtToken";
      this.txtToken.Size = new System.Drawing.Size(428, 27);
      this.txtToken.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label2.Location = new System.Drawing.Point(11, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "アクセストークン：";
      // 
      // txtUserId
      // 
      this.txtUserId.Location = new System.Drawing.Point(119, 22);
      this.txtUserId.Name = "txtUserId";
      this.txtUserId.Size = new System.Drawing.Size(428, 27);
      this.txtUserId.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label3.Location = new System.Drawing.Point(52, 25);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "ユーザId：";
      // 
      // SettingDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(576, 625);
      this.ControlBox = false;
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "SettingDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SettingDialog";
      this.Load += new System.EventHandler(this.SettingDialog_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgWasanbon)).EndInit();
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgBase)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtToken;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.DataGridView dgBase;
    private System.Windows.Forms.Button btnDownBase;
    private System.Windows.Forms.Button btnUpBase;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button btnDownWa;
    private System.Windows.Forms.Button btnUpWa;
    private System.Windows.Forms.Button btnDeleteWa;
    private System.Windows.Forms.Button btnUpdateWa;
    private System.Windows.Forms.Button btnAddWa;
    private System.Windows.Forms.DataGridView dgWasanbon;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.TextBox txtUserId;
    private System.Windows.Forms.Label label3;
  }
}