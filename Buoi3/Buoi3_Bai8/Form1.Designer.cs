namespace Buoi3_Bai8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhap = new System.Windows.Forms.ComboBox();
            this.btnHien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // cbNhap
            // 
            this.cbNhap.FormattingEnabled = true;
            this.cbNhap.Items.AddRange(new object[] {
            "Võ Văn Tỷ",
            "Nguyễn Trần Duy Nhất",
            "Trịnh Trần Phương Tuấn"});
            this.cbNhap.Location = new System.Drawing.Point(234, 66);
            this.cbNhap.Name = "cbNhap";
            this.cbNhap.Size = new System.Drawing.Size(192, 24);
            this.cbNhap.TabIndex = 1;
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(234, 123);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(187, 70);
            this.btnHien.TabIndex = 2;
            this.btnHien.Text = "Hiện Lời Chào";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.cbNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhap;
        private System.Windows.Forms.Button btnHien;
    }
}

