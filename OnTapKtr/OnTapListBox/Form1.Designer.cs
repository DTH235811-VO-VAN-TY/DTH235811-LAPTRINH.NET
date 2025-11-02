namespace OnTapListBox
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLopB = new System.Windows.Forms.RadioButton();
            this.rdLopA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLopA = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLopB = new System.Windows.Forms.ListBox();
            this.btnMoveAB = new System.Windows.Forms.Button();
            this.btnMoveBA = new System.Windows.Forms.Button();
            this.btnMoveAll_AB = new System.Windows.Forms.Button();
            this.btnMoveAll_BA = new System.Windows.Forms.Button();
            this.btnTongSV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(323, 63);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(387, 30);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(791, 59);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 42);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLopB);
            this.groupBox1.Controls.Add(this.rdLopA);
            this.groupBox1.Location = new System.Drawing.Point(348, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Lớp";
            // 
            // rdLopB
            // 
            this.rdLopB.AutoSize = true;
            this.rdLopB.Location = new System.Drawing.Point(201, 29);
            this.rdLopB.Name = "rdLopB";
            this.rdLopB.Size = new System.Drawing.Size(81, 26);
            this.rdLopB.TabIndex = 0;
            this.rdLopB.Text = "Lớp B";
            this.rdLopB.UseVisualStyleBackColor = true;
            // 
            // rdLopA
            // 
            this.rdLopA.AutoSize = true;
            this.rdLopA.Checked = true;
            this.rdLopA.Location = new System.Drawing.Point(48, 29);
            this.rdLopA.Name = "rdLopA";
            this.rdLopA.Size = new System.Drawing.Size(81, 26);
            this.rdLopA.TabIndex = 0;
            this.rdLopA.TabStop = true;
            this.rdLopA.Text = "Lớp A";
            this.rdLopA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLopA);
            this.groupBox2.Location = new System.Drawing.Point(60, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 331);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // lbLopA
            // 
            this.lbLopA.FormattingEnabled = true;
            this.lbLopA.ItemHeight = 22;
            this.lbLopA.Items.AddRange(new object[] {
            "Trần Thanh Tín",
            "Nguyễn Văn Linh",
            "Lê Văn Đô",
            "Trần Thanh Phong",
            "Kilian Mpappe"});
            this.lbLopA.Location = new System.Drawing.Point(16, 30);
            this.lbLopA.Name = "lbLopA";
            this.lbLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLopA.Size = new System.Drawing.Size(270, 268);
            this.lbLopA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLopB);
            this.groupBox3.Location = new System.Drawing.Point(711, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 331);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // lbLopB
            // 
            this.lbLopB.FormattingEnabled = true;
            this.lbLopB.ItemHeight = 22;
            this.lbLopB.Items.AddRange(new object[] {
            "Nguyễn Thúc Thùy Tiên",
            "Lê Quang Linh",
            "Hằng Du Muc",
            "Nguyễn Thanh Bình"});
            this.lbLopB.Location = new System.Drawing.Point(19, 36);
            this.lbLopB.Name = "lbLopB";
            this.lbLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLopB.Size = new System.Drawing.Size(270, 268);
            this.lbLopB.TabIndex = 0;
            // 
            // btnMoveAB
            // 
            this.btnMoveAB.Location = new System.Drawing.Point(453, 224);
            this.btnMoveAB.Name = "btnMoveAB";
            this.btnMoveAB.Size = new System.Drawing.Size(138, 51);
            this.btnMoveAB.TabIndex = 6;
            this.btnMoveAB.Text = ">";
            this.btnMoveAB.UseVisualStyleBackColor = true;
            this.btnMoveAB.Click += new System.EventHandler(this.btnMoveAB_Click);
            // 
            // btnMoveBA
            // 
            this.btnMoveBA.Location = new System.Drawing.Point(453, 296);
            this.btnMoveBA.Name = "btnMoveBA";
            this.btnMoveBA.Size = new System.Drawing.Size(138, 51);
            this.btnMoveBA.TabIndex = 6;
            this.btnMoveBA.Text = "<";
            this.btnMoveBA.UseVisualStyleBackColor = true;
            this.btnMoveBA.Click += new System.EventHandler(this.btnMoveBA_Click);
            // 
            // btnMoveAll_AB
            // 
            this.btnMoveAll_AB.Location = new System.Drawing.Point(453, 372);
            this.btnMoveAll_AB.Name = "btnMoveAll_AB";
            this.btnMoveAll_AB.Size = new System.Drawing.Size(138, 51);
            this.btnMoveAll_AB.TabIndex = 6;
            this.btnMoveAll_AB.Text = ">>";
            this.btnMoveAll_AB.UseVisualStyleBackColor = true;
            this.btnMoveAll_AB.Click += new System.EventHandler(this.btnMoveAll_AB_Click);
            // 
            // btnMoveAll_BA
            // 
            this.btnMoveAll_BA.Location = new System.Drawing.Point(453, 447);
            this.btnMoveAll_BA.Name = "btnMoveAll_BA";
            this.btnMoveAll_BA.Size = new System.Drawing.Size(138, 51);
            this.btnMoveAll_BA.TabIndex = 6;
            this.btnMoveAll_BA.Text = "<<";
            this.btnMoveAll_BA.UseVisualStyleBackColor = true;
            this.btnMoveAll_BA.Click += new System.EventHandler(this.btnMoveAll_BA_Click);
            // 
            // btnTongSV
            // 
            this.btnTongSV.Location = new System.Drawing.Point(279, 540);
            this.btnTongSV.Name = "btnTongSV";
            this.btnTongSV.Size = new System.Drawing.Size(198, 49);
            this.btnTongSV.TabIndex = 6;
            this.btnTongSV.Text = "Tổng số sinh viên";
            this.btnTongSV.UseVisualStyleBackColor = true;
            this.btnTongSV.Click += new System.EventHandler(this.btnTongSV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(589, 540);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 49);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTongSV);
            this.Controls.Add(this.btnMoveAll_BA);
            this.Controls.Add(this.btnMoveAll_AB);
            this.Controls.Add(this.btnMoveBA);
            this.Controls.Add(this.btnMoveAB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLopB;
        private System.Windows.Forms.RadioButton rdLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbLopA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbLopB;
        private System.Windows.Forms.Button btnMoveAB;
        private System.Windows.Forms.Button btnMoveBA;
        private System.Windows.Forms.Button btnMoveAll_AB;
        private System.Windows.Forms.Button btnMoveAll_BA;
        private System.Windows.Forms.Button btnTongSV;
        private System.Windows.Forms.Button btnThoat;
    }
}

