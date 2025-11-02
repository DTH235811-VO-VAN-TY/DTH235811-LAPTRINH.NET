namespace Buoi6_Bai5._2
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
            this.textNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbChonLop = new System.Windows.Forms.GroupBox();
            this.rdLopA = new System.Windows.Forms.RadioButton();
            this.rdLopB = new System.Windows.Forms.RadioButton();
            this.gbLopA = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.gbLopB = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btnChuyenAB = new System.Windows.Forms.Button();
            this.btnChuyenBA = new System.Windows.Forms.Button();
            this.btnAll_BA = new System.Windows.Forms.Button();
            this.btnAll_AB = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongSV = new System.Windows.Forms.Button();
            this.gbChonLop.SuspendLayout();
            this.gbLopA.SuspendLayout();
            this.gbLopB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // textNhap
            // 
            this.textNhap.Location = new System.Drawing.Point(314, 21);
            this.textNhap.Name = "textNhap";
            this.textNhap.Size = new System.Drawing.Size(473, 30);
            this.textNhap.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(869, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 39);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbChonLop
            // 
            this.gbChonLop.Controls.Add(this.rdLopB);
            this.gbChonLop.Controls.Add(this.rdLopA);
            this.gbChonLop.Location = new System.Drawing.Point(389, 67);
            this.gbChonLop.Name = "gbChonLop";
            this.gbChonLop.Size = new System.Drawing.Size(303, 78);
            this.gbChonLop.TabIndex = 3;
            this.gbChonLop.TabStop = false;
            this.gbChonLop.Text = "Chọn Lớp";
            // 
            // rdLopA
            // 
            this.rdLopA.AutoSize = true;
            this.rdLopA.Checked = true;
            this.rdLopA.Location = new System.Drawing.Point(39, 42);
            this.rdLopA.Name = "rdLopA";
            this.rdLopA.Size = new System.Drawing.Size(81, 26);
            this.rdLopA.TabIndex = 0;
            this.rdLopA.TabStop = true;
            this.rdLopA.Text = "Lớp A";
            this.rdLopA.UseVisualStyleBackColor = true;
            // 
            // rdLopB
            // 
            this.rdLopB.AutoSize = true;
            this.rdLopB.Location = new System.Drawing.Point(198, 42);
            this.rdLopB.Name = "rdLopB";
            this.rdLopB.Size = new System.Drawing.Size(81, 26);
            this.rdLopB.TabIndex = 1;
            this.rdLopB.TabStop = true;
            this.rdLopB.Text = "Lớp B";
            this.rdLopB.UseVisualStyleBackColor = true;
            // 
            // gbLopA
            // 
            this.gbLopA.Controls.Add(this.lstLopA);
            this.gbLopA.Location = new System.Drawing.Point(113, 148);
            this.gbLopA.Name = "gbLopA";
            this.gbLopA.Size = new System.Drawing.Size(259, 346);
            this.gbLopA.TabIndex = 4;
            this.gbLopA.TabStop = false;
            this.gbLopA.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 22;
            this.lstLopA.Items.AddRange(new object[] {
            "Võ Văn Tỷ\t",
            "Nguyễn Trần Duy Nhất",
            "Cristianal Ronaldo",
            "Supper Nova"});
            this.lstLopA.Location = new System.Drawing.Point(17, 29);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(217, 290);
            this.lstLopA.TabIndex = 0;
            // 
            // gbLopB
            // 
            this.gbLopB.Controls.Add(this.lstLopB);
            this.gbLopB.Location = new System.Drawing.Point(708, 148);
            this.gbLopB.Name = "gbLopB";
            this.gbLopB.Size = new System.Drawing.Size(259, 346);
            this.gbLopB.TabIndex = 5;
            this.gbLopB.TabStop = false;
            this.gbLopB.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 22;
            this.lstLopB.Items.AddRange(new object[] {
            "Ngô Kiến Huy",
            "Lê Anh Nuôi"});
            this.lstLopB.Location = new System.Drawing.Point(17, 29);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(217, 290);
            this.lstLopB.TabIndex = 0;
            // 
            // btnChuyenAB
            // 
            this.btnChuyenAB.Location = new System.Drawing.Point(486, 177);
            this.btnChuyenAB.Name = "btnChuyenAB";
            this.btnChuyenAB.Size = new System.Drawing.Size(99, 51);
            this.btnChuyenAB.TabIndex = 6;
            this.btnChuyenAB.Text = ">";
            this.btnChuyenAB.UseVisualStyleBackColor = true;
            this.btnChuyenAB.Click += new System.EventHandler(this.btnChuyenAB_Click);
            // 
            // btnChuyenBA
            // 
            this.btnChuyenBA.Location = new System.Drawing.Point(486, 253);
            this.btnChuyenBA.Name = "btnChuyenBA";
            this.btnChuyenBA.Size = new System.Drawing.Size(99, 51);
            this.btnChuyenBA.TabIndex = 6;
            this.btnChuyenBA.Text = "<";
            this.btnChuyenBA.UseVisualStyleBackColor = true;
            this.btnChuyenBA.Click += new System.EventHandler(this.btnChuyenBA_Click);
            // 
            // btnAll_BA
            // 
            this.btnAll_BA.Location = new System.Drawing.Point(486, 416);
            this.btnAll_BA.Name = "btnAll_BA";
            this.btnAll_BA.Size = new System.Drawing.Size(99, 51);
            this.btnAll_BA.TabIndex = 6;
            this.btnAll_BA.Text = "<<";
            this.btnAll_BA.UseVisualStyleBackColor = true;
            this.btnAll_BA.Click += new System.EventHandler(this.btnAll_BA_Click);
            // 
            // btnAll_AB
            // 
            this.btnAll_AB.Location = new System.Drawing.Point(486, 326);
            this.btnAll_AB.Name = "btnAll_AB";
            this.btnAll_AB.Size = new System.Drawing.Size(99, 51);
            this.btnAll_AB.TabIndex = 6;
            this.btnAll_AB.Text = ">>";
            this.btnAll_AB.UseVisualStyleBackColor = true;
            this.btnAll_AB.Click += new System.EventHandler(this.btnAll_AB_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(597, 500);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(226, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongSV
            // 
            this.btnTongSV.Location = new System.Drawing.Point(262, 500);
            this.btnTongSV.Name = "btnTongSV";
            this.btnTongSV.Size = new System.Drawing.Size(226, 41);
            this.btnTongSV.TabIndex = 7;
            this.btnTongSV.Text = "Tổng số sinh viên";
            this.btnTongSV.UseVisualStyleBackColor = true;
            this.btnTongSV.Click += new System.EventHandler(this.btnTongSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnTongSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAll_AB);
            this.Controls.Add(this.btnAll_BA);
            this.Controls.Add(this.btnChuyenBA);
            this.Controls.Add(this.btnChuyenAB);
            this.Controls.Add(this.gbLopB);
            this.Controls.Add(this.gbLopA);
            this.Controls.Add(this.gbChonLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbChonLop.ResumeLayout(false);
            this.gbChonLop.PerformLayout();
            this.gbLopA.ResumeLayout(false);
            this.gbLopB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbChonLop;
        private System.Windows.Forms.RadioButton rdLopB;
        private System.Windows.Forms.RadioButton rdLopA;
        private System.Windows.Forms.GroupBox gbLopA;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox gbLopB;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnChuyenAB;
        private System.Windows.Forms.Button btnChuyenBA;
        private System.Windows.Forms.Button btnAll_BA;
        private System.Windows.Forms.Button btnAll_AB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTongSV;
    }
}

