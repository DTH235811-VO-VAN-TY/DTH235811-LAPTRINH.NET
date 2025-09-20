
namespace Bai1_5
{
    partial class FrmChuongTrinhDonGian
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnHienThi = new Button();
            label2 = new Label();
            txtHoTen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(428, 41);
            label1.TabIndex = 0;
            label1.Text = "Xin chào, chúc một ngày vui vẽ";
            label1.Click += label1_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(272, 226);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(178, 83);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 186);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên: ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(272, 183);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(225, 27);
            txtHoTen.TabIndex = 3;
            // 
            // FrmChuongTrinhDonGian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 482);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(btnHienThi);
            Controls.Add(label1);
            Name = "FrmChuongTrinhDonGian";
            Text = "CHƯƠNG TRÌNH ĐƠN GIẢN";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa click vào label!");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn "+txtHoTen.Text+" đến với Lập trình Windowfrom!");
        }


        #endregion

       private Label label1;
        private Button btnHienThi;
        private Label label2;
        private TextBox txtHoTen;
    }
}
