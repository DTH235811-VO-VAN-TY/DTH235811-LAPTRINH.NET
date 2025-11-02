namespace Buoi8_Bai1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdHV = new System.Windows.Forms.RadioButton();
            this.rdHCN = new System.Windows.Forms.RadioButton();
            this.rdHT = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thựcHiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(100, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH DIỆN TÍCH VÀ CHU VI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHT);
            this.groupBox1.Controls.Add(this.rdHCN);
            this.groupBox1.Controls.Add(this.rdHV);
            this.groupBox1.Location = new System.Drawing.Point(31, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCanh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(253, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 170);
            this.panel1.TabIndex = 2;
            // 
            // rdHV
            // 
            this.rdHV.AutoSize = true;
            this.rdHV.Checked = true;
            this.rdHV.ForeColor = System.Drawing.Color.Blue;
            this.rdHV.Location = new System.Drawing.Point(27, 43);
            this.rdHV.Name = "rdHV";
            this.rdHV.Size = new System.Drawing.Size(123, 26);
            this.rdHV.TabIndex = 0;
            this.rdHV.TabStop = true;
            this.rdHV.Text = "Hình Vuông";
            this.rdHV.UseVisualStyleBackColor = true;
            this.rdHV.CheckedChanged += new System.EventHandler(this.rdHV_CheckedChanged);
            // 
            // rdHCN
            // 
            this.rdHCN.AutoSize = true;
            this.rdHCN.ForeColor = System.Drawing.Color.Blue;
            this.rdHCN.Location = new System.Drawing.Point(27, 87);
            this.rdHCN.Name = "rdHCN";
            this.rdHCN.Size = new System.Drawing.Size(149, 26);
            this.rdHCN.TabIndex = 0;
            this.rdHCN.Text = "Hình Chữ Nhật";
            this.rdHCN.UseVisualStyleBackColor = true;
            this.rdHCN.CheckedChanged += new System.EventHandler(this.rdHCN_CheckedChanged);
            // 
            // rdHT
            // 
            this.rdHT.AutoSize = true;
            this.rdHT.ForeColor = System.Drawing.Color.Blue;
            this.rdHT.Location = new System.Drawing.Point(27, 129);
            this.rdHT.Name = "rdHT";
            this.rdHT.Size = new System.Drawing.Size(111, 26);
            this.rdHT.TabIndex = 0;
            this.rdHT.Text = "Hình Tròn";
            this.rdHT.UseVisualStyleBackColor = true;
            this.rdHT.CheckedChanged += new System.EventHandler(this.rdHT_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cạnh:";
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(67, 27);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(173, 30);
            this.txtCanh.TabIndex = 1;
            this.txtCanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanh_KeyPress);
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(67, 73);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(100, 30);
            this.txtDai.TabIndex = 3;
            this.txtDai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDai_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dài:";
            // 
            // txtBK
            // 
            this.txtBK.Location = new System.Drawing.Point(130, 113);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(100, 30);
            this.txtBK.TabIndex = 5;
            this.txtBK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBK_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bán Kính R:";
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(257, 73);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(100, 30);
            this.txtRong.TabIndex = 7;
            this.txtRong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rộng:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(345, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 47);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(157, 304);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(138, 47);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thựcHiệnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thựcHiệnToolStripMenuItem
            // 
            this.thựcHiệnToolStripMenuItem.Name = "thựcHiệnToolStripMenuItem";
            this.thựcHiệnToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.thựcHiệnToolStripMenuItem.Text = "Thực Hiện";
            this.thựcHiệnToolStripMenuItem.Click += new System.EventHandler(this.thựcHiệnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 371);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHT;
        private System.Windows.Forms.RadioButton rdHCN;
        private System.Windows.Forms.RadioButton rdHV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thựcHiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

