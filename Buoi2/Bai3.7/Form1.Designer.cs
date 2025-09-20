namespace Bai3._7
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
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(198, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình Bậc 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(200, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phương Trình";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(322, 277);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(257, 22);
            this.txtC.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(221, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "c:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(322, 237);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(257, 22);
            this.txtB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(221, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "b:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(322, 189);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(257, 22);
            this.txtA.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(221, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "a:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKetqua
            // 
            this.lblKetqua.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.ForeColor = System.Drawing.Color.Red;
            this.lblKetqua.Location = new System.Drawing.Point(322, 312);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(257, 29);
            this.lblKetqua.TabIndex = 30;
            this.lblKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "KẾT QUẢ:";
            // 
            // btnGiai
            // 
            this.btnGiai.BackColor = System.Drawing.Color.Yellow;
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnGiai.Location = new System.Drawing.Point(322, 359);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(257, 49);
            this.btnGiai.TabIndex = 31;
            this.btnGiai.Text = "GIẢI";
            this.btnGiai.UseVisualStyleBackColor = false;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGiai;
    }
}

