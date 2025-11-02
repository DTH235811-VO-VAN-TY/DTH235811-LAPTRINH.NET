using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(char c = 'A'; c <= 'Z'; c++)
            {
                treeView1.Nodes.Add(c.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string ho = txtHo.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ho))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ và tên.");
                return;
            }

            string chuCaiDau = ten.Substring(0, 1).ToUpper();

            TreeNode node = treeView1.Nodes.Cast<TreeNode>()
                .FirstOrDefault(n => n.Text == chuCaiDau);

            if (node != null)
            {
                node.Nodes.Add($"{ho} {ten}");
                node.Expand(); // Mở rộng node để thấy tên vừa thêm
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhóm chữ cái phù hợp.");
            }

            txtTen.Clear();
            txtHo.Clear();
            txtTen.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
