namespace RTSystemBuilder {
  partial class ComponentSearchDialog {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentSearchDialog));
      this.lblTitle = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.chkComment = new System.Windows.Forms.CheckBox();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.chkName = new System.Windows.Forms.CheckBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.chkJava = new System.Windows.Forms.CheckBox();
      this.chkPython = new System.Windows.Forms.CheckBox();
      this.chkCpp = new System.Windows.Forms.CheckBox();
      this.chkVendor = new System.Windows.Forms.CheckBox();
      this.chkCatrgory = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtVendor = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCategory = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.chkOut = new System.Windows.Forms.CheckBox();
      this.chkIn = new System.Windows.Forms.CheckBox();
      this.chkDPType = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDPType = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.chkRequired = new System.Windows.Forms.CheckBox();
      this.chkProvided = new System.Windows.Forms.CheckBox();
      this.chkSPType = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtSPType = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.lblTitle.Location = new System.Drawing.Point(12, 9);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(159, 21);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "コンポーネント検索条件";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chkComment);
      this.groupBox1.Controls.Add(this.txtComment);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.chkName);
      this.groupBox1.Controls.Add(this.txtName);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.chkJava);
      this.groupBox1.Controls.Add(this.chkPython);
      this.groupBox1.Controls.Add(this.chkCpp);
      this.groupBox1.Controls.Add(this.chkVendor);
      this.groupBox1.Controls.Add(this.chkCatrgory);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtVendor);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtCategory);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Location = new System.Drawing.Point(12, 33);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(643, 187);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "コンポーネント";
      // 
      // chkComment
      // 
      this.chkComment.AutoSize = true;
      this.chkComment.Location = new System.Drawing.Point(562, 150);
      this.chkComment.Name = "chkComment";
      this.chkComment.Size = new System.Drawing.Size(78, 24);
      this.chkComment.TabIndex = 10;
      this.chkComment.Text = "OR検索";
      this.chkComment.UseVisualStyleBackColor = true;
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(106, 149);
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(450, 27);
      this.txtComment.TabIndex = 9;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label9.Location = new System.Drawing.Point(31, 152);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(66, 20);
      this.label9.TabIndex = 25;
      this.label9.Text = "コメント：";
      // 
      // chkName
      // 
      this.chkName.AutoSize = true;
      this.chkName.Location = new System.Drawing.Point(562, 22);
      this.chkName.Name = "chkName";
      this.chkName.Size = new System.Drawing.Size(78, 24);
      this.chkName.TabIndex = 1;
      this.chkName.Text = "OR検索";
      this.chkName.UseVisualStyleBackColor = true;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(106, 21);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(450, 27);
      this.txtName.TabIndex = 0;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label7.Location = new System.Drawing.Point(28, 24);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(69, 20);
      this.label7.TabIndex = 22;
      this.label7.Text = "登録名：";
      // 
      // chkJava
      // 
      this.chkJava.AutoSize = true;
      this.chkJava.Location = new System.Drawing.Point(248, 118);
      this.chkJava.Name = "chkJava";
      this.chkJava.Size = new System.Drawing.Size(56, 24);
      this.chkJava.TabIndex = 8;
      this.chkJava.Text = "Java";
      this.chkJava.UseVisualStyleBackColor = true;
      // 
      // chkPython
      // 
      this.chkPython.AutoSize = true;
      this.chkPython.Location = new System.Drawing.Point(169, 118);
      this.chkPython.Name = "chkPython";
      this.chkPython.Size = new System.Drawing.Size(73, 24);
      this.chkPython.TabIndex = 7;
      this.chkPython.Text = "Python";
      this.chkPython.UseVisualStyleBackColor = true;
      // 
      // chkCpp
      // 
      this.chkCpp.AutoSize = true;
      this.chkCpp.Location = new System.Drawing.Point(106, 118);
      this.chkCpp.Name = "chkCpp";
      this.chkCpp.Size = new System.Drawing.Size(57, 24);
      this.chkCpp.TabIndex = 6;
      this.chkCpp.Text = "C++";
      this.chkCpp.UseVisualStyleBackColor = true;
      // 
      // chkVendor
      // 
      this.chkVendor.AutoSize = true;
      this.chkVendor.Location = new System.Drawing.Point(562, 86);
      this.chkVendor.Name = "chkVendor";
      this.chkVendor.Size = new System.Drawing.Size(78, 24);
      this.chkVendor.TabIndex = 5;
      this.chkVendor.Text = "OR検索";
      this.chkVendor.UseVisualStyleBackColor = true;
      // 
      // chkCatrgory
      // 
      this.chkCatrgory.AutoSize = true;
      this.chkCatrgory.Location = new System.Drawing.Point(562, 54);
      this.chkCatrgory.Name = "chkCatrgory";
      this.chkCatrgory.Size = new System.Drawing.Size(78, 24);
      this.chkCatrgory.TabIndex = 3;
      this.chkCatrgory.Text = "OR検索";
      this.chkCatrgory.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label2.Location = new System.Drawing.Point(13, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 20);
      this.label2.TabIndex = 19;
      this.label2.Text = "実装言語：";
      // 
      // txtVendor
      // 
      this.txtVendor.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.txtVendor.Location = new System.Drawing.Point(106, 85);
      this.txtVendor.Name = "txtVendor";
      this.txtVendor.Size = new System.Drawing.Size(450, 27);
      this.txtVendor.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(23, 88);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 20);
      this.label1.TabIndex = 17;
      this.label1.Text = "ベンダ名：";
      // 
      // txtCategory
      // 
      this.txtCategory.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.txtCategory.Location = new System.Drawing.Point(106, 53);
      this.txtCategory.Name = "txtCategory";
      this.txtCategory.Size = new System.Drawing.Size(450, 27);
      this.txtCategory.TabIndex = 2;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label8.Location = new System.Drawing.Point(29, 56);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(68, 20);
      this.label8.TabIndex = 15;
      this.label8.Text = "カテゴリ：";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.chkOut);
      this.groupBox2.Controls.Add(this.chkIn);
      this.groupBox2.Controls.Add(this.chkDPType);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.txtDPType);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Location = new System.Drawing.Point(12, 223);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(643, 93);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "データポート";
      // 
      // chkOut
      // 
      this.chkOut.AutoSize = true;
      this.chkOut.Location = new System.Drawing.Point(169, 63);
      this.chkOut.Name = "chkOut";
      this.chkOut.Size = new System.Drawing.Size(52, 24);
      this.chkOut.TabIndex = 3;
      this.chkOut.Text = "Out";
      this.chkOut.UseVisualStyleBackColor = true;
      // 
      // chkIn
      // 
      this.chkIn.AutoSize = true;
      this.chkIn.Location = new System.Drawing.Point(106, 63);
      this.chkIn.Name = "chkIn";
      this.chkIn.Size = new System.Drawing.Size(40, 24);
      this.chkIn.TabIndex = 2;
      this.chkIn.Text = "In";
      this.chkIn.UseVisualStyleBackColor = true;
      // 
      // chkDPType
      // 
      this.chkDPType.AutoSize = true;
      this.chkDPType.Location = new System.Drawing.Point(562, 29);
      this.chkDPType.Name = "chkDPType";
      this.chkDPType.Size = new System.Drawing.Size(78, 24);
      this.chkDPType.TabIndex = 1;
      this.chkDPType.Text = "OR検索";
      this.chkDPType.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label3.Location = new System.Drawing.Point(46, 63);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 20);
      this.label3.TabIndex = 19;
      this.label3.Text = "方向：";
      // 
      // txtDPType
      // 
      this.txtDPType.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.txtDPType.Location = new System.Drawing.Point(106, 26);
      this.txtDPType.Name = "txtDPType";
      this.txtDPType.Size = new System.Drawing.Size(450, 27);
      this.txtDPType.TabIndex = 0;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label5.Location = new System.Drawing.Point(28, 29);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 20);
      this.label5.TabIndex = 15;
      this.label5.Text = "データ型：";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.chkRequired);
      this.groupBox3.Controls.Add(this.chkProvided);
      this.groupBox3.Controls.Add(this.chkSPType);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.txtSPType);
      this.groupBox3.Controls.Add(this.label6);
      this.groupBox3.Location = new System.Drawing.Point(12, 326);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(643, 93);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "サービスポート";
      // 
      // chkRequired
      // 
      this.chkRequired.AutoSize = true;
      this.chkRequired.Location = new System.Drawing.Point(235, 63);
      this.chkRequired.Name = "chkRequired";
      this.chkRequired.Size = new System.Drawing.Size(88, 24);
      this.chkRequired.TabIndex = 3;
      this.chkRequired.Text = "Required";
      this.chkRequired.UseVisualStyleBackColor = true;
      // 
      // chkProvided
      // 
      this.chkProvided.AutoSize = true;
      this.chkProvided.Location = new System.Drawing.Point(139, 63);
      this.chkProvided.Name = "chkProvided";
      this.chkProvided.Size = new System.Drawing.Size(87, 24);
      this.chkProvided.TabIndex = 2;
      this.chkProvided.Text = "Provided";
      this.chkProvided.UseVisualStyleBackColor = true;
      // 
      // chkSPType
      // 
      this.chkSPType.AutoSize = true;
      this.chkSPType.Location = new System.Drawing.Point(562, 29);
      this.chkSPType.Name = "chkSPType";
      this.chkSPType.Size = new System.Drawing.Size(78, 24);
      this.chkSPType.TabIndex = 1;
      this.chkSPType.Text = "OR検索";
      this.chkSPType.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label4.Location = new System.Drawing.Point(79, 63);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 20);
      this.label4.TabIndex = 19;
      this.label4.Text = "方向：";
      // 
      // txtSPType
      // 
      this.txtSPType.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.txtSPType.Location = new System.Drawing.Point(133, 26);
      this.txtSPType.Name = "txtSPType";
      this.txtSPType.Size = new System.Drawing.Size(423, 27);
      this.txtSPType.TabIndex = 0;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label6.Location = new System.Drawing.Point(9, 29);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(122, 20);
      this.label6.TabIndex = 15;
      this.label6.Text = "インターフェース型：";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(565, 425);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(90, 30);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "キャンセル";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnOK.Location = new System.Drawing.Point(469, 425);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(90, 30);
      this.btnOK.TabIndex = 4;
      this.btnOK.TabStop = false;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // ComponentSearchDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(662, 461);
      this.ControlBox = false;
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lblTitle);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ComponentSearchDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ComponentSearchDialog";
      this.Load += new System.EventHandler(this.ComponentSearchDialog_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtVendor;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCategory;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.CheckBox chkJava;
    private System.Windows.Forms.CheckBox chkPython;
    private System.Windows.Forms.CheckBox chkCpp;
    private System.Windows.Forms.CheckBox chkVendor;
    private System.Windows.Forms.CheckBox chkCatrgory;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chkOut;
    private System.Windows.Forms.CheckBox chkIn;
    private System.Windows.Forms.CheckBox chkDPType;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDPType;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.CheckBox chkRequired;
    private System.Windows.Forms.CheckBox chkProvided;
    private System.Windows.Forms.CheckBox chkSPType;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtSPType;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.CheckBox chkComment;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.CheckBox chkName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label7;
  }
}