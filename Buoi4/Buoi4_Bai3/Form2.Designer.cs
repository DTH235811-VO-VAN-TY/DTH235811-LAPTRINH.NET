namespace Buoi4_Bai3
{
    partial class Form2
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
            this.lblToong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToong
            // 
            this.lblToong.AutoSize = true;
            this.lblToong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToong.ForeColor = System.Drawing.Color.Blue;
            this.lblToong.Location = new System.Drawing.Point(144, 154);
            this.lblToong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToong.Name = "lblToong";
            this.lblToong.Size = new System.Drawing.Size(86, 32);
            this.lblToong.TabIndex = 0;
            this.lblToong.Text = "label1";
            this.lblToong.Click += new System.EventHandler(this.lblToong_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.lblToong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToong;
    }
}