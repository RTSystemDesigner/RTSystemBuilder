namespace RTSystemBuilder {
  partial class EditSystemForm {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSystemForm));
      this.btnClose = new System.Windows.Forms.Button();
      this.dgComponent = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSearch = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtServicePort = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtDataPort = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.cmbSysRep = new System.Windows.Forms.ComboBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtSysName = new System.Windows.Forms.TextBox();
      this.btnNewSys = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnUpdateSys = new System.Windows.Forms.Button();
      this.dgSystem = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSetSys = new System.Windows.Forms.Button();
      this.btnGetSys = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnAll = new System.Windows.Forms.Button();
      this.btnRegist = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgComponent)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgSystem)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(1413, 681);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(90, 30);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "終了";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // dgComponent
      // 
      this.dgComponent.AllowUserToAddRows = false;
      this.dgComponent.AllowUserToDeleteRows = false;
      this.dgComponent.AllowUserToResizeRows = false;
      this.dgComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgComponent.BackgroundColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgComponent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgComponent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column9});
      this.dgComponent.EnableHeadersVisualStyles = false;
      this.dgComponent.Location = new System.Drawing.Point(6, 53);
      this.dgComponent.MultiSelect = false;
      this.dgComponent.Name = "dgComponent";
      this.dgComponent.ReadOnly = true;
      this.dgComponent.RowHeadersVisible = false;
      this.dgComponent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
      this.dgComponent.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgComponent.RowTemplate.Height = 25;
      this.dgComponent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgComponent.Size = new System.Drawing.Size(1485, 211);
      this.dgComponent.TabIndex = 4;
      this.dgComponent.SelectionChanged += new System.EventHandler(this.dgComponent_SelectionChanged);
      // 
      // Column1
      // 
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
      this.Column1.HeaderText = "Column1";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Visible = false;
      // 
      // Column8
      // 
      this.Column8.HeaderText = "登録名";
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      this.Column8.Width = 150;
      // 
      // Column2
      // 
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
      this.Column2.HeaderText = "コンポーネント名";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 200;
      // 
      // Column3
      // 
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
      this.Column3.HeaderText = "ベンダ名";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 200;
      // 
      // Column7
      // 
      this.Column7.HeaderText = "カテゴリ";
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column7.Width = 200;
      // 
      // Column4
      // 
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
      this.Column4.HeaderText = "実装言語";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      // 
      // Column5
      // 
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
      this.Column5.HeaderText = "リポジトリ";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 420;
      // 
      // Column9
      // 
      this.Column9.HeaderText = "コメント";
      this.Column9.Name = "Column9";
      this.Column9.ReadOnly = true;
      this.Column9.Width = 185;
      // 
      // btnSearch
      // 
      this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnSearch.Location = new System.Drawing.Point(8, 20);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(90, 30);
      this.btnSearch.TabIndex = 0;
      this.btnSearch.Text = "検索";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.57983F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.42017F));
      this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 267);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1491, 154);
      this.tableLayoutPanel1.TabIndex = 25;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txtServicePort);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(742, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(746, 148);
      this.panel2.TabIndex = 1;
      // 
      // txtServicePort
      // 
      this.txtServicePort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtServicePort.Font = new System.Drawing.Font("Times New Roman", 11.25F);
      this.txtServicePort.ImeMode = System.Windows.Forms.ImeMode.On;
      this.txtServicePort.Location = new System.Drawing.Point(6, 24);
      this.txtServicePort.Multiline = true;
      this.txtServicePort.Name = "txtServicePort";
      this.txtServicePort.ReadOnly = true;
      this.txtServicePort.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtServicePort.Size = new System.Drawing.Size(737, 120);
      this.txtServicePort.TabIndex = 123;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(8, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 21);
      this.label1.TabIndex = 124;
      this.label1.Text = "【サービスポート】";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtDataPort);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(733, 148);
      this.panel1.TabIndex = 0;
      // 
      // txtDataPort
      // 
      this.txtDataPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDataPort.Font = new System.Drawing.Font("Times New Roman", 11.25F);
      this.txtDataPort.ImeMode = System.Windows.Forms.ImeMode.On;
      this.txtDataPort.Location = new System.Drawing.Point(6, 24);
      this.txtDataPort.Multiline = true;
      this.txtDataPort.Name = "txtDataPort";
      this.txtDataPort.ReadOnly = true;
      this.txtDataPort.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtDataPort.Size = new System.Drawing.Size(724, 120);
      this.txtDataPort.TabIndex = 123;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label5.Location = new System.Drawing.Point(8, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(98, 21);
      this.label5.TabIndex = 124;
      this.label5.Text = "【データポート】";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 34);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1496, 643);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.groupBox3);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1496, 192);
      this.panel3.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.cmbSysRep);
      this.groupBox3.Controls.Add(this.btnClear);
      this.groupBox3.Controls.Add(this.txtSysName);
      this.groupBox3.Controls.Add(this.btnNewSys);
      this.groupBox3.Controls.Add(this.label6);
      this.groupBox3.Controls.Add(this.btnDelete);
      this.groupBox3.Controls.Add(this.btnUpdateSys);
      this.groupBox3.Controls.Add(this.dgSystem);
      this.groupBox3.Controls.Add(this.btnSetSys);
      this.groupBox3.Controls.Add(this.btnGetSys);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.groupBox3.Location = new System.Drawing.Point(0, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(1496, 192);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "システム構成";
      // 
      // cmbSysRep
      // 
      this.cmbSysRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSysRep.FormattingEnabled = true;
      this.cmbSysRep.Location = new System.Drawing.Point(142, 28);
      this.cmbSysRep.Name = "cmbSysRep";
      this.cmbSysRep.Size = new System.Drawing.Size(377, 28);
      this.cmbSysRep.TabIndex = 126;
      // 
      // btnClear
      // 
      this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnClear.Location = new System.Drawing.Point(1184, 26);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(90, 30);
      this.btnClear.TabIndex = 21;
      this.btnClear.Text = "情報クリア";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // txtSysName
      // 
      this.txtSysName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.txtSysName.ImeMode = System.Windows.Forms.ImeMode.Disable;
      this.txtSysName.Location = new System.Drawing.Point(603, 28);
      this.txtSysName.Name = "txtSysName";
      this.txtSysName.Size = new System.Drawing.Size(291, 27);
      this.txtSysName.TabIndex = 18;
      // 
      // btnNewSys
      // 
      this.btnNewSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnNewSys.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnNewSys.Location = new System.Drawing.Point(898, 26);
      this.btnNewSys.Name = "btnNewSys";
      this.btnNewSys.Size = new System.Drawing.Size(90, 30);
      this.btnNewSys.TabIndex = 20;
      this.btnNewSys.Text = "新規作成";
      this.btnNewSys.UseVisualStyleBackColor = false;
      this.btnNewSys.Click += new System.EventHandler(this.btnNewSys_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label6.Location = new System.Drawing.Point(523, 31);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(85, 20);
      this.label6.TabIndex = 19;
      this.label6.Text = "システム名：";
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnDelete.Location = new System.Drawing.Point(1402, 26);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(90, 30);
      this.btnDelete.TabIndex = 1;
      this.btnDelete.Text = "削除";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnUpdateSys
      // 
      this.btnUpdateSys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnUpdateSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnUpdateSys.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnUpdateSys.Location = new System.Drawing.Point(1312, 26);
      this.btnUpdateSys.Name = "btnUpdateSys";
      this.btnUpdateSys.Size = new System.Drawing.Size(90, 30);
      this.btnUpdateSys.TabIndex = 3;
      this.btnUpdateSys.Text = "概要更新";
      this.btnUpdateSys.UseVisualStyleBackColor = false;
      this.btnUpdateSys.Click += new System.EventHandler(this.btnUpdateSys_Click);
      // 
      // dgSystem
      // 
      this.dgSystem.AllowUserToAddRows = false;
      this.dgSystem.AllowUserToDeleteRows = false;
      this.dgSystem.AllowUserToResizeRows = false;
      this.dgSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgSystem.BackgroundColor = System.Drawing.Color.White;
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgSystem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
      this.dgSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgSystem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
      this.dgSystem.EnableHeadersVisualStyles = false;
      this.dgSystem.Location = new System.Drawing.Point(3, 63);
      this.dgSystem.MultiSelect = false;
      this.dgSystem.Name = "dgSystem";
      this.dgSystem.ReadOnly = true;
      this.dgSystem.RowHeadersVisible = false;
      this.dgSystem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
      this.dgSystem.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgSystem.RowTemplate.Height = 25;
      this.dgSystem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgSystem.Size = new System.Drawing.Size(1491, 123);
      this.dgSystem.TabIndex = 4;
      this.dgSystem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSystem_CellDoubleClick);
      // 
      // dataGridViewTextBoxColumn6
      // 
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle8;
      this.dataGridViewTextBoxColumn6.HeaderText = "Column1";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Visible = false;
      // 
      // dataGridViewTextBoxColumn7
      // 
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle9;
      this.dataGridViewTextBoxColumn7.HeaderText = "コンポーネント名";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      this.dataGridViewTextBoxColumn7.Width = 200;
      // 
      // dataGridViewTextBoxColumn8
      // 
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle10;
      this.dataGridViewTextBoxColumn8.HeaderText = "概要";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Width = 700;
      // 
      // dataGridViewTextBoxColumn10
      // 
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle11;
      this.dataGridViewTextBoxColumn10.HeaderText = "URL";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.ReadOnly = true;
      this.dataGridViewTextBoxColumn10.Width = 550;
      // 
      // btnSetSys
      // 
      this.btnSetSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnSetSys.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnSetSys.Location = new System.Drawing.Point(1094, 26);
      this.btnSetSys.Name = "btnSetSys";
      this.btnSetSys.Size = new System.Drawing.Size(90, 30);
      this.btnSetSys.TabIndex = 2;
      this.btnSetSys.Text = "情報設定";
      this.btnSetSys.UseVisualStyleBackColor = false;
      this.btnSetSys.Click += new System.EventHandler(this.btnSetSys_Click);
      // 
      // btnGetSys
      // 
      this.btnGetSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnGetSys.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnGetSys.Location = new System.Drawing.Point(988, 26);
      this.btnGetSys.Name = "btnGetSys";
      this.btnGetSys.Size = new System.Drawing.Size(90, 30);
      this.btnGetSys.TabIndex = 1;
      this.btnGetSys.Text = "情報取得";
      this.btnGetSys.UseVisualStyleBackColor = false;
      this.btnGetSys.Click += new System.EventHandler(this.btnGetSys_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label4.Location = new System.Drawing.Point(5, 31);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(137, 20);
      this.label4.TabIndex = 17;
      this.label4.Text = "ベースリポジトリURI：";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnAll);
      this.groupBox1.Controls.Add(this.btnRegist);
      this.groupBox1.Controls.Add(this.dgComponent);
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.groupBox1.Location = new System.Drawing.Point(0, 192);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1496, 451);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "コンポーネント一覧";
      // 
      // btnAll
      // 
      this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnAll.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnAll.Location = new System.Drawing.Point(104, 20);
      this.btnAll.Name = "btnAll";
      this.btnAll.Size = new System.Drawing.Size(90, 30);
      this.btnAll.TabIndex = 26;
      this.btnAll.Text = "全件取得";
      this.btnAll.UseVisualStyleBackColor = false;
      this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // btnRegist
      // 
      this.btnRegist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnRegist.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.btnRegist.Location = new System.Drawing.Point(1346, 20);
      this.btnRegist.Name = "btnRegist";
      this.btnRegist.Size = new System.Drawing.Size(144, 30);
      this.btnRegist.TabIndex = 0;
      this.btnRegist.Text = "対象システムに登録";
      this.btnRegist.UseVisualStyleBackColor = false;
      this.btnRegist.Click += new System.EventHandler(this.btnResist_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label3.Location = new System.Drawing.Point(10, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(121, 30);
      this.label3.TabIndex = 125;
      this.label3.Text = "システム構築";
      // 
      // EditSystemForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1510, 718);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tableLayoutPanel2);
      this.Controls.Add(this.btnClose);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditSystemForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.CompDBMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgComponent)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgSystem)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.DataGridView dgComponent;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtServicePort;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtDataPort;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnRegist;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnAll;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnUpdateSys;
    private System.Windows.Forms.DataGridView dgSystem;
    private System.Windows.Forms.Button btnSetSys;
    private System.Windows.Forms.Button btnGetSys;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnNewSys;
    private System.Windows.Forms.TextBox txtSysName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.ComboBox cmbSysRep;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
  }
}

