namespace RTSystemBuilder.Wasanbon {
  partial class SearchRepositoryDialog {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchRepositoryDialog));
      this.lblTitle = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnFilter = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtFilter = new System.Windows.Forms.TextBox();
      this.dgRepository = new System.Windows.Forms.DataGridView();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgRepository)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.lblTitle.Location = new System.Drawing.Point(12, 9);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(102, 21);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "リポジトリ検索";
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.txtName.ImeMode = System.Windows.Forms.ImeMode.Disable;
      this.txtName.Location = new System.Drawing.Point(104, 37);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(539, 27);
      this.txtName.TabIndex = 0;
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnSearch.Location = new System.Drawing.Point(649, 35);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(66, 30);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.TabStop = false;
      this.btnSearch.Text = "検索";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnFilter
      // 
      this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnFilter.Location = new System.Drawing.Point(538, 77);
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(86, 30);
      this.btnFilter.TabIndex = 3;
      this.btnFilter.TabStop = false;
      this.btnFilter.Text = "絞り込み";
      this.btnFilter.UseVisualStyleBackColor = false;
      this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.BackColor = System.Drawing.Color.White;
      this.btnClear.Location = new System.Drawing.Point(629, 77);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(86, 30);
      this.btnClear.TabIndex = 4;
      this.btnClear.TabStop = false;
      this.btnClear.Text = "クリア";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // txtFilter
      // 
      this.txtFilter.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.txtFilter.Location = new System.Drawing.Point(104, 79);
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new System.Drawing.Size(428, 27);
      this.txtFilter.TabIndex = 2;
      // 
      // dgRepository
      // 
      this.dgRepository.AllowUserToAddRows = false;
      this.dgRepository.AllowUserToDeleteRows = false;
      this.dgRepository.AllowUserToResizeRows = false;
      this.dgRepository.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgRepository.BackgroundColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgRepository.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgRepository.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgRepository.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column7});
      this.dgRepository.EnableHeadersVisualStyles = false;
      this.dgRepository.Location = new System.Drawing.Point(9, 113);
      this.dgRepository.MultiSelect = false;
      this.dgRepository.Name = "dgRepository";
      this.dgRepository.ReadOnly = true;
      this.dgRepository.RowHeadersVisible = false;
      this.dgRepository.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
      this.dgRepository.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgRepository.RowTemplate.Height = 25;
      this.dgRepository.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgRepository.Size = new System.Drawing.Size(706, 470);
      this.dgRepository.TabIndex = 5;
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(625, 589);
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
      this.btnOK.Location = new System.Drawing.Point(529, 589);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(90, 30);
      this.btnOK.TabIndex = 6;
      this.btnOK.TabStop = false;
      this.btnOK.Text = "選択";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(13, 82);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 20);
      this.label1.TabIndex = 138;
      this.label1.Text = "フィルタリング";
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
      this.Column8.HeaderText = "リポジトリ名";
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      this.Column8.Width = 200;
      // 
      // Column7
      // 
      this.Column7.HeaderText = "URL";
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column7.Width = 480;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label2.Location = new System.Drawing.Point(44, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 20);
      this.label2.TabIndex = 139;
      this.label2.Text = "組織名";
      // 
      // SearchRepositoryDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(727, 624);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.dgRepository);
      this.Controls.Add(this.txtFilter);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnFilter);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lblTitle);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchRepositoryDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SearchRepositoryDialog";
      this.Load += new System.EventHandler(this.SearchRepositoryDialog_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgRepository)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TextBox txtFilter;
    private System.Windows.Forms.DataGridView dgRepository;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.Label label2;
  }
}