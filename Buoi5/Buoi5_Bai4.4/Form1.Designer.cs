namespace Buoi5_Bai4._4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHinh = new System.Windows.Forms.GroupBox();
            this.rdTamGiac = new System.Windows.Forms.RadioButton();
            this.rdChuNhat = new System.Windows.Forms.RadioButton();
            this.rdVuong = new System.Windows.Forms.RadioButton();
            this.rdTron = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groVuong = new System.Windows.Forms.GroupBox();
            this.txtCVvuong = new System.Windows.Forms.TextBox();
            this.txtDTvuong = new System.Windows.Forms.TextBox();
            this.txtVuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groTamGiac = new System.Windows.Forms.GroupBox();
            this.txtDTtg = new System.Windows.Forms.TextBox();
            this.txtLoaiTG = new System.Windows.Forms.TextBox();
            this.txtCVtg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groTron = new System.Windows.Forms.GroupBox();
            this.txtCVtron = new System.Windows.Forms.TextBox();
            this.txtDTtron = new System.Windows.Forms.TextBox();
            this.txtBKtron = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groChuNhat = new System.Windows.Forms.GroupBox();
            this.txtBcn = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCVcn = new System.Windows.Forms.TextBox();
            this.txtDTcn = new System.Windows.Forms.TextBox();
            this.txtAcn = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbHinh.SuspendLayout();
            this.groVuong.SuspendLayout();
            this.groTamGiac.SuspendLayout();
            this.groTron.SuspendLayout();
            this.groChuNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình Chu Vi và Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(438, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình Tròn - Hình vuông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(400, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình Tam Giác - Hình Chử Nhật";
            // 
            // cbHinh
            // 
            this.cbHinh.Controls.Add(this.rdTamGiac);
            this.cbHinh.Controls.Add(this.rdChuNhat);
            this.cbHinh.Controls.Add(this.rdVuong);
            this.cbHinh.Controls.Add(this.rdTron);
            this.cbHinh.Location = new System.Drawing.Point(334, 155);
            this.cbHinh.Name = "cbHinh";
            this.cbHinh.Size = new System.Drawing.Size(373, 103);
            this.cbHinh.TabIndex = 3;
            this.cbHinh.TabStop = false;
            this.cbHinh.Text = "Chọn";
            // 
            // rdTamGiac
            // 
            this.rdTamGiac.AutoSize = true;
            this.rdTamGiac.Location = new System.Drawing.Point(192, 61);
            this.rdTamGiac.Name = "rdTamGiac";
            this.rdTamGiac.Size = new System.Drawing.Size(151, 26);
            this.rdTamGiac.TabIndex = 0;
            this.rdTamGiac.Text = "Hinh Tam Giác";
            this.rdTamGiac.UseVisualStyleBackColor = true;
            this.rdTamGiac.CheckedChanged += new System.EventHandler(this.rdTamGiac_CheckedChanged);
            // 
            // rdChuNhat
            // 
            this.rdChuNhat.AutoSize = true;
            this.rdChuNhat.Location = new System.Drawing.Point(20, 61);
            this.rdChuNhat.Name = "rdChuNhat";
            this.rdChuNhat.Size = new System.Drawing.Size(149, 26);
            this.rdChuNhat.TabIndex = 0;
            this.rdChuNhat.Text = "Hình Chử Nhật";
            this.rdChuNhat.UseVisualStyleBackColor = true;
            this.rdChuNhat.CheckedChanged += new System.EventHandler(this.rdChuNhat_CheckedChanged);
            // 
            // rdVuong
            // 
            this.rdVuong.AutoSize = true;
            this.rdVuong.Checked = true;
            this.rdVuong.Location = new System.Drawing.Point(192, 29);
            this.rdVuong.Name = "rdVuong";
            this.rdVuong.Size = new System.Drawing.Size(123, 26);
            this.rdVuong.TabIndex = 0;
            this.rdVuong.TabStop = true;
            this.rdVuong.Text = "Hình Vuông";
            this.rdVuong.UseVisualStyleBackColor = true;
            this.rdVuong.CheckedChanged += new System.EventHandler(this.rdVuong_CheckedChanged);
            // 
            // rdTron
            // 
            this.rdTron.AutoSize = true;
            this.rdTron.Location = new System.Drawing.Point(20, 29);
            this.rdTron.Name = "rdTron";
            this.rdTron.Size = new System.Drawing.Size(111, 26);
            this.rdTron.TabIndex = 0;
            this.rdTron.Text = "Hình Tròn";
            this.rdTron.UseVisualStyleBackColor = true;
            this.rdTron.CheckedChanged += new System.EventHandler(this.rdTron_CheckedChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(267, 273);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(137, 48);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(461, 273);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 48);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(651, 273);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groVuong
            // 
            this.groVuong.Controls.Add(this.txtCVvuong);
            this.groVuong.Controls.Add(this.txtDTvuong);
            this.groVuong.Controls.Add(this.txtVuong);
            this.groVuong.Controls.Add(this.label6);
            this.groVuong.Controls.Add(this.label5);
            this.groVuong.Controls.Add(this.label4);
            this.groVuong.Location = new System.Drawing.Point(267, 340);
            this.groVuong.Name = "groVuong";
            this.groVuong.Size = new System.Drawing.Size(295, 176);
            this.groVuong.TabIndex = 5;
            this.groVuong.TabStop = false;
            this.groVuong.Text = "Hình Vuông";
            // 
            // txtCVvuong
            // 
            this.txtCVvuong.Enabled = false;
            this.txtCVvuong.Location = new System.Drawing.Point(134, 86);
            this.txtCVvuong.Name = "txtCVvuong";
            this.txtCVvuong.Size = new System.Drawing.Size(140, 30);
            this.txtCVvuong.TabIndex = 2;
            // 
            // txtDTvuong
            // 
            this.txtDTvuong.Enabled = false;
            this.txtDTvuong.Location = new System.Drawing.Point(134, 125);
            this.txtDTvuong.Name = "txtDTvuong";
            this.txtDTvuong.Size = new System.Drawing.Size(140, 30);
            this.txtDTvuong.TabIndex = 2;
            // 
            // txtVuong
            // 
            this.txtVuong.Location = new System.Drawing.Point(134, 43);
            this.txtVuong.Name = "txtVuong";
            this.txtVuong.Size = new System.Drawing.Size(140, 30);
            this.txtVuong.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Diện Tích:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chu Vi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập Cạnh A: ";
            // 
            // groTamGiac
            // 
            this.groTamGiac.Controls.Add(this.txtDTtg);
            this.groTamGiac.Controls.Add(this.txtLoaiTG);
            this.groTamGiac.Controls.Add(this.txtCVtg);
            this.groTamGiac.Controls.Add(this.label10);
            this.groTamGiac.Controls.Add(this.label11);
            this.groTamGiac.Controls.Add(this.label12);
            this.groTamGiac.Controls.Add(this.txtB);
            this.groTamGiac.Controls.Add(this.txtC);
            this.groTamGiac.Controls.Add(this.txtA);
            this.groTamGiac.Controls.Add(this.label7);
            this.groTamGiac.Controls.Add(this.label8);
            this.groTamGiac.Controls.Add(this.label9);
            this.groTamGiac.Location = new System.Drawing.Point(261, 340);
            this.groTamGiac.Name = "groTamGiac";
            this.groTamGiac.Size = new System.Drawing.Size(442, 221);
            this.groTamGiac.TabIndex = 6;
            this.groTamGiac.TabStop = false;
            this.groTamGiac.Text = "Hình Tam Giác";
            this.groTamGiac.Visible = false;
            // 
            // txtDTtg
            // 
            this.txtDTtg.Enabled = false;
            this.txtDTtg.Location = new System.Drawing.Point(288, 71);
            this.txtDTtg.Name = "txtDTtg";
            this.txtDTtg.Size = new System.Drawing.Size(139, 30);
            this.txtDTtg.TabIndex = 12;
            // 
            // txtLoaiTG
            // 
            this.txtLoaiTG.Enabled = false;
            this.txtLoaiTG.Location = new System.Drawing.Point(288, 110);
            this.txtLoaiTG.Name = "txtLoaiTG";
            this.txtLoaiTG.Size = new System.Drawing.Size(139, 30);
            this.txtLoaiTG.TabIndex = 13;
            // 
            // txtCVtg
            // 
            this.txtCVtg.Enabled = false;
            this.txtCVtg.Location = new System.Drawing.Point(288, 31);
            this.txtCVtg.Name = "txtCVtg";
            this.txtCVtg.Size = new System.Drawing.Size(139, 30);
            this.txtCVtg.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Loại Tam Giác:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "Diện Tích:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Chu Vi:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(87, 71);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(65, 30);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(87, 110);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(65, 30);
            this.txtC.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(87, 31);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(65, 30);
            this.txtA.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cạnh C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cạnh B:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cạnh A: ";
            // 
            // groTron
            // 
            this.groTron.Controls.Add(this.txtCVtron);
            this.groTron.Controls.Add(this.txtDTtron);
            this.groTron.Controls.Add(this.txtBKtron);
            this.groTron.Controls.Add(this.label13);
            this.groTron.Controls.Add(this.label14);
            this.groTron.Controls.Add(this.label15);
            this.groTron.Location = new System.Drawing.Point(267, 340);
            this.groTron.Name = "groTron";
            this.groTron.Size = new System.Drawing.Size(368, 192);
            this.groTron.TabIndex = 7;
            this.groTron.TabStop = false;
            this.groTron.Text = "Hình Tròn";
            this.groTron.Visible = false;
            // 
            // txtCVtron
            // 
            this.txtCVtron.Enabled = false;
            this.txtCVtron.Location = new System.Drawing.Point(134, 86);
            this.txtCVtron.Name = "txtCVtron";
            this.txtCVtron.Size = new System.Drawing.Size(140, 30);
            this.txtCVtron.TabIndex = 2;
            // 
            // txtDTtron
            // 
            this.txtDTtron.Enabled = false;
            this.txtDTtron.Location = new System.Drawing.Point(134, 125);
            this.txtDTtron.Name = "txtDTtron";
            this.txtDTtron.Size = new System.Drawing.Size(140, 30);
            this.txtDTtron.TabIndex = 2;
            // 
            // txtBKtron
            // 
            this.txtBKtron.Location = new System.Drawing.Point(134, 46);
            this.txtBKtron.Name = "txtBKtron";
            this.txtBKtron.Size = new System.Drawing.Size(140, 30);
            this.txtBKtron.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "Diện Tích:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Chu Vi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Bán Kính:";
            // 
            // groChuNhat
            // 
            this.groChuNhat.Controls.Add(this.txtBcn);
            this.groChuNhat.Controls.Add(this.label19);
            this.groChuNhat.Controls.Add(this.txtCVcn);
            this.groChuNhat.Controls.Add(this.txtDTcn);
            this.groChuNhat.Controls.Add(this.txtAcn);
            this.groChuNhat.Controls.Add(this.label16);
            this.groChuNhat.Controls.Add(this.label17);
            this.groChuNhat.Controls.Add(this.label18);
            this.groChuNhat.Location = new System.Drawing.Point(261, 340);
            this.groChuNhat.Name = "groChuNhat";
            this.groChuNhat.Size = new System.Drawing.Size(442, 215);
            this.groChuNhat.TabIndex = 8;
            this.groChuNhat.TabStop = false;
            this.groChuNhat.Text = "Hình Chữ Nhật";
            this.groChuNhat.Visible = false;
            // 
            // txtBcn
            // 
            this.txtBcn.Location = new System.Drawing.Point(134, 83);
            this.txtBcn.Name = "txtBcn";
            this.txtBcn.Size = new System.Drawing.Size(140, 30);
            this.txtBcn.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(56, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 22);
            this.label19.TabIndex = 3;
            this.label19.Text = "Cạnh B:";
            // 
            // txtCVcn
            // 
            this.txtCVcn.Enabled = false;
            this.txtCVcn.Location = new System.Drawing.Point(134, 119);
            this.txtCVcn.Name = "txtCVcn";
            this.txtCVcn.Size = new System.Drawing.Size(140, 30);
            this.txtCVcn.TabIndex = 2;
            // 
            // txtDTcn
            // 
            this.txtDTcn.Enabled = false;
            this.txtDTcn.Location = new System.Drawing.Point(134, 158);
            this.txtDTcn.Name = "txtDTcn";
            this.txtDTcn.Size = new System.Drawing.Size(140, 30);
            this.txtDTcn.TabIndex = 2;
            // 
            // txtAcn
            // 
            this.txtAcn.Location = new System.Drawing.Point(134, 46);
            this.txtAcn.Name = "txtAcn";
            this.txtAcn.Size = new System.Drawing.Size(140, 30);
            this.txtAcn.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 22);
            this.label16.TabIndex = 1;
            this.label16.Text = "Diện Tích:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Chu Vi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(56, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 22);
            this.label18.TabIndex = 0;
            this.label18.Text = "Cạnh A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 619);
            this.Controls.Add(this.groChuNhat);
            this.Controls.Add(this.groTron);
            this.Controls.Add(this.groTamGiac);
            this.Controls.Add(this.groVuong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.cbHinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.cbHinh.ResumeLayout(false);
            this.cbHinh.PerformLayout();
            this.groVuong.ResumeLayout(false);
            this.groVuong.PerformLayout();
            this.groTamGiac.ResumeLayout(false);
            this.groTamGiac.PerformLayout();
            this.groTron.ResumeLayout(false);
            this.groTron.PerformLayout();
            this.groChuNhat.ResumeLayout(false);
            this.groChuNhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox cbHinh;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdTamGiac;
        private System.Windows.Forms.RadioButton rdChuNhat;
        private System.Windows.Forms.RadioButton rdVuong;
        private System.Windows.Forms.RadioButton rdTron;
        private System.Windows.Forms.GroupBox groVuong;
        private System.Windows.Forms.TextBox txtCVvuong;
        private System.Windows.Forms.TextBox txtDTvuong;
        private System.Windows.Forms.TextBox txtVuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groTamGiac;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDTtg;
        private System.Windows.Forms.TextBox txtLoaiTG;
        private System.Windows.Forms.TextBox txtCVtg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groTron;
        private System.Windows.Forms.TextBox txtCVtron;
        private System.Windows.Forms.TextBox txtDTtron;
        private System.Windows.Forms.TextBox txtBKtron;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groChuNhat;
        private System.Windows.Forms.TextBox txtCVcn;
        private System.Windows.Forms.TextBox txtDTcn;
        private System.Windows.Forms.TextBox txtAcn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBcn;
        private System.Windows.Forms.Label label19;
    }
}

