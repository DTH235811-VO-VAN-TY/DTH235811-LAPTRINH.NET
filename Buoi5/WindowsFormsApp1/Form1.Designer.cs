namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandomMang = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSXtang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.lblGoc = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(118, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng Gốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKQ);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(118, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // btnRandomMang
            // 
            this.btnRandomMang.Location = new System.Drawing.Point(118, 233);
            this.btnRandomMang.Name = "btnRandomMang";
            this.btnRandomMang.Size = new System.Drawing.Size(343, 52);
            this.btnRandomMang.TabIndex = 2;
            this.btnRandomMang.Text = "Xuất Mảng Ngẫu Nhiên";
            this.btnRandomMang.UseVisualStyleBackColor = true;
            this.btnRandomMang.Click += new System.EventHandler(this.btnRandomMang_Click);
            // 
            // btnTongMang
            // 
            this.btnTongMang.Location = new System.Drawing.Point(118, 292);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(343, 52);
            this.btnTongMang.TabIndex = 2;
            this.btnTongMang.Text = "Tính Tổng Giá Trị Mảng";
            this.btnTongMang.UseVisualStyleBackColor = true;
            this.btnTongMang.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(118, 347);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(343, 52);
            this.btnLe.TabIndex = 2;
            this.btnLe.Text = "Đếm Số Phần Tử Lẻ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Location = new System.Drawing.Point(118, 405);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(343, 52);
            this.btnTongLe.TabIndex = 2;
            this.btnTongLe.Text = "Tổng Giá Trị Các Phần Tử Lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Location = new System.Drawing.Point(594, 292);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(343, 52);
            this.btnTangLen2.TabIndex = 3;
            this.btnTangLen2.Text = "Tăng Mỗi Phần Tử Mảng Lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(594, 233);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(343, 52);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "Tìm Phần Tử Nhỏ Nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSXtang
            // 
            this.btnSXtang.Location = new System.Drawing.Point(594, 347);
            this.btnSXtang.Name = "btnSXtang";
            this.btnSXtang.Size = new System.Drawing.Size(343, 52);
            this.btnSXtang.TabIndex = 5;
            this.btnSXtang.Text = "Sắp Xếp Tăng";
            this.btnSXtang.UseVisualStyleBackColor = true;
            this.btnSXtang.Click += new System.EventHandler(this.btnSXtang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(594, 405);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(343, 52);
            this.btnGiam.TabIndex = 6;
            this.btnGiam.Text = "Sắp Xếp Giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // lblGoc
            // 
            this.lblGoc.BackColor = System.Drawing.Color.White;
            this.lblGoc.ForeColor = System.Drawing.Color.Red;
            this.lblGoc.Location = new System.Drawing.Point(40, 35);
            this.lblGoc.Name = "lblGoc";
            this.lblGoc.Size = new System.Drawing.Size(777, 32);
            this.lblGoc.TabIndex = 0;
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.White;
            this.lblKQ.ForeColor = System.Drawing.Color.Red;
            this.lblKQ.Location = new System.Drawing.Point(40, 38);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(777, 32);
            this.lblKQ.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1124, 619);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnSXtang);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnTangLen2);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnLe);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnRandomMang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandomMang;
        private System.Windows.Forms.Button btnTongMang;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSXtang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Label lblGoc;
        private System.Windows.Forms.Label lblKQ;
    }
}

