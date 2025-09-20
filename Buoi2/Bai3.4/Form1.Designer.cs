namespace Bai3._4
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
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(255, 148);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(223, 22);
            this.txtNgay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(154, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "NGÀY:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(255, 196);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(223, 22);
            this.txtThang.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(154, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÁNG: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(255, 236);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(223, 22);
            this.txtNam.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(154, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "NĂM:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(187, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 93);
            this.label4.TabIndex = 9;
            this.label4.Text = "KIỂM TRA NGÀY HỢP LỆ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.Fuchsia;
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.ForeColor = System.Drawing.Color.Cyan;
            this.btnKiemTra.Location = new System.Drawing.Point(255, 289);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(223, 64);
            this.btnKiemTra.TabIndex = 10;
            this.btnKiemTra.Text = "KIỂM TRA";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKiemTra;
    }
}

