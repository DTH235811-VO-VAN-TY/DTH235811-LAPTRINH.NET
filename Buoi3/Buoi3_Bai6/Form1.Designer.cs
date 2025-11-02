namespace Buoi3_Bai6
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtThem = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnMauNen = new System.Windows.Forms.Button();
            this.btnMauChu = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Chuỗi";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(79, 83);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(255, 22);
            this.txtNhap.TabIndex = 1;
            // 
            // txtThem
            // 
            this.txtThem.Location = new System.Drawing.Point(79, 133);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(115, 34);
            this.txtThem.TabIndex = 2;
            this.txtThem.Text = "THÊM";
            this.txtThem.UseVisualStyleBackColor = true;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.Location = new System.Drawing.Point(219, 133);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(115, 34);
            this.txtXoa.TabIndex = 3;
            this.txtXoa.Text = "XÓA";
            this.txtXoa.UseVisualStyleBackColor = true;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(79, 212);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(255, 116);
            this.lstDanhSach.TabIndex = 4;
            this.lstDanhSach.SelectedIndexChanged += new System.EventHandler(this.lstDanhSach_SelectedIndexChanged);
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(354, 64);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(414, 155);
            this.txtHienThi.TabIndex = 5;
            // 
            // btnMauNen
            // 
            this.btnMauNen.Location = new System.Drawing.Point(497, 244);
            this.btnMauNen.Name = "btnMauNen";
            this.btnMauNen.Size = new System.Drawing.Size(135, 57);
            this.btnMauNen.TabIndex = 6;
            this.btnMauNen.Text = "Chọn màu nền";
            this.btnMauNen.UseVisualStyleBackColor = true;
            this.btnMauNen.Click += new System.EventHandler(this.btnMauNen_Click);
            // 
            // btnMauChu
            // 
            this.btnMauChu.Location = new System.Drawing.Point(354, 244);
            this.btnMauChu.Name = "btnMauChu";
            this.btnMauChu.Size = new System.Drawing.Size(135, 57);
            this.btnMauChu.TabIndex = 7;
            this.btnMauChu.Text = "Chọn màu chữ";
            this.btnMauChu.UseVisualStyleBackColor = true;
            this.btnMauChu.Click += new System.EventHandler(this.btnMauChu_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(638, 244);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(135, 57);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "Chọn Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(502, 307);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(135, 57);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnMauChu);
            this.Controls.Add(this.btnMauNen);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button txtThem;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnMauNen;
        private System.Windows.Forms.Button btnMauChu;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnDong;
    }
}

