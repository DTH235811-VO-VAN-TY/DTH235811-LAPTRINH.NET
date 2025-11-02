namespace OnTapPhanMang
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
            this.txtSoPT = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử mảng";
            // 
            // txtSoPT
            // 
            this.txtSoPT.Location = new System.Drawing.Point(225, 42);
            this.txtSoPT.Name = "txtSoPT";
            this.txtSoPT.Size = new System.Drawing.Size(100, 30);
            this.txtSoPT.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(385, 99);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 45);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(338, 42);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(178, 35);
            this.btnTaoMang.TabIndex = 2;
            this.btnTaoMang.Text = "Tạo Mảng Random";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnMax
            // 
            this.btnMax.Enabled = false;
            this.btnMax.Location = new System.Drawing.Point(219, 99);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(160, 45);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Số lớn nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnTongMang
            // 
            this.btnTongMang.Enabled = false;
            this.btnTongMang.Location = new System.Drawing.Point(39, 99);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(160, 45);
            this.btnTongMang.TabIndex = 2;
            this.btnTongMang.Text = "Tổng Mảng";
            this.btnTongMang.UseVisualStyleBackColor = true;
            this.btnTongMang.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 172);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtSoPT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnTongMang;
    }
}

