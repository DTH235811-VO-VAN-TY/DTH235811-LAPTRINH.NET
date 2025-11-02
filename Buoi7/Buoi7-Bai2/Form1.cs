using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitExplorerTreeView();
        }
        private void InitExplorerTreeView()
        {
           explorerTreeView.ShowRootLines = true;
            explorerTreeView.ShowLines = true;
            TreeNode root;
            string[] driver = Directory.GetLogicalDrives();
            foreach (string div in driver)
            {
                root = new TreeNode(div);
                root.Nodes.Add(new TreeNode(" "));
                explorerTreeView.Nodes.Add(root);
            }
        }
        private void explorerTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(e.Node.FullPath);
            contentPicFlowLayoutPanel.Controls.Clear();
            PictureBox[] pic;
            showPicPictureBox.Image = null;
            if (dir.Exists)
            {
                pic = new PictureBox[dir.GetFiles().GetLength(0)];
                int i = 0;
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (file.Name.EndsWith(".jpg") || file.Name.EndsWith(".png") || file.Name.EndsWith(".bmp") || file.Name.EndsWith(".gif"))
                    {
                        pic[i] = new PictureBox();
                        pic[i].Size = new Size(100, 100);
                        pic[i].Name = "pic" + file.Name;
                        pic[i].SizeMode = PictureBoxSizeMode.Zoom;
                        pic[i].BorderStyle = BorderStyle.FixedSingle;
                        pic[i].Image = Image.FromFile(e.Node.FullPath+"//"+file.Name);
                        pic[i].Click += new EventHandler(Form1_Click);
                        contentPicFlowLayoutPanel.Controls.Add(pic[i]);
                        i++;
                        contentPicFlowLayoutPanel.Update();
                    }
                }
            }
        }

        private void explorerTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if (e.Node.Nodes[0].Text == " ")
                {
                    e.Node.Nodes.Clear();
                    FillNode(e.Node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillNode(TreeNode rootNode)
        {
            DirectoryInfo dir = new DirectoryInfo(rootNode.FullPath);
            foreach (DirectoryInfo childName in dir.GetDirectories())
            {
                TreeNode childNode = new TreeNode(childName.Name);
                childNode.Nodes.Add(new TreeNode(" "));
                rootNode.Nodes.Add(childNode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showPicPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            contentPicFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            showPicPictureBox.Image = picture.Image;
        }

        private void contentPicFlowLayoutPanel_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            showPicPictureBox.Image = picture.Image;
        }
    }
}
