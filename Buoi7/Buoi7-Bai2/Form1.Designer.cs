namespace Buoi7_Bai2
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
            this.showPicPictureBox = new System.Windows.Forms.PictureBox();
            this.contentPicFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.explorerTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.showPicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showPicPictureBox
            // 
            this.showPicPictureBox.Location = new System.Drawing.Point(459, 45);
            this.showPicPictureBox.Name = "showPicPictureBox";
            this.showPicPictureBox.Size = new System.Drawing.Size(523, 290);
            this.showPicPictureBox.TabIndex = 0;
            this.showPicPictureBox.TabStop = false;
            // 
            // contentPicFlowLayoutPanel
            // 
            this.contentPicFlowLayoutPanel.Location = new System.Drawing.Point(394, 374);
            this.contentPicFlowLayoutPanel.Name = "contentPicFlowLayoutPanel";
            this.contentPicFlowLayoutPanel.Size = new System.Drawing.Size(661, 143);
            this.contentPicFlowLayoutPanel.TabIndex = 1;
            this.contentPicFlowLayoutPanel.Click += new System.EventHandler(this.contentPicFlowLayoutPanel_Click);
            // 
            // explorerTreeView
            // 
            this.explorerTreeView.Location = new System.Drawing.Point(34, 26);
            this.explorerTreeView.Name = "explorerTreeView";
            this.explorerTreeView.Size = new System.Drawing.Size(269, 491);
            this.explorerTreeView.TabIndex = 2;
            this.explorerTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.explorerTreeView_BeforeExpand);
            this.explorerTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.explorerTreeView_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 550);
            this.Controls.Add(this.explorerTreeView);
            this.Controls.Add(this.contentPicFlowLayoutPanel);
            this.Controls.Add(this.showPicPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.showPicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox showPicPictureBox;
        private System.Windows.Forms.FlowLayoutPanel contentPicFlowLayoutPanel;
        private System.Windows.Forms.TreeView explorerTreeView;
    }
}

