namespace RTSystemBuilder.SystemEdit {
  partial class DescriptionDialog {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescriptionDialog));
      this.txtComment = new System.Windows.Forms.TextBox();
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblComp = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtComment
      // 
      this.txtComment.ImeMode = System.Windows.Forms.ImeMode.Disable;
      this.txtComment.Location = new System.Drawing.Point(124, 69);
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(433, 88);
      this.txtComment.TabIndex = 31;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.lblTitle.Location = new System.Drawing.Point(11, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(127, 21);
      this.lblTitle.TabIndex = 25;
      this.lblTitle.Text = "コンポーネント概要";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(462, 166);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(90, 30);
      this.btnCancel.TabIndex = 33;
      this.btnCancel.TabStop = false;
      this.btnCancel.Text = "キャンセル";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
      this.btnOK.Location = new System.Drawing.Point(366, 166);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(90, 30);
      this.btnOK.TabIndex = 32;
      this.btnOK.TabStop = false;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label8.Location = new System.Drawing.Point(12, 38);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(116, 20);
      this.label8.TabIndex = 34;
      this.label8.Text = "コンポーネント名：";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(74, 69);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 20);
      this.label1.TabIndex = 35;
      this.label1.Text = "概要：";
      // 
      // lblComp
      // 
      this.lblComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblComp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblComp.Location = new System.Drawing.Point(124, 35);
      this.lblComp.Name = "lblComp";
      this.lblComp.Size = new System.Drawing.Size(433, 27);
      this.lblComp.TabIndex = 36;
      this.lblComp.Text = "コンポーネント名：";
      this.lblComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // DescriptionDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(565, 203);
      this.ControlBox = false;
      this.Controls.Add(this.lblComp);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "DescriptionDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DescriptionDialog";
      this.Load += new System.EventHandler(this.DescriptionDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblComp;
  }
}