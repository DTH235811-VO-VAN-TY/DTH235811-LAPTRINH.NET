using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi8_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(rdHV.Checked == true)
            {
                XoaTXT();
                txtCanh.Enabled = true;
                txtCanh.Focus();
            }
        }
        private void XoaTXT()
        {
           txtCanh.Clear();
           txtDai.Clear();
            txtRong.Clear();
            txtBK.Clear();

           // 
            txtCanh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBK.Enabled = false;
            txtCanh.Focus();
        }

        private void rdHV_CheckedChanged(object sender, EventArgs e)
        {
            XoaTXT();
            txtCanh.Enabled = true;
            txtCanh.Focus();
            
        }
        private  void rdHCN_CheckedChanged(object sender, EventArgs e)
        {
            XoaTXT();
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtDai.Focus();
        }

        private void rdHT_CheckedChanged(object sender, EventArgs e)
        {
            XoaTXT();
            txtBK.Enabled = true;
            txtBK.Focus();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdHV.Checked == true)
            {
                if(txtCanh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu cho cạnh!");
                    txtCanh.Focus();
                    return;
                }
                else
                {
                    Form2 f2 = new Form2();
                    f2.CanhA = double.Parse(txtCanh.Text);
                    double dt = f2.TinhDienTich(f2.CanhA);
                   // MessageBox.Show("Diện tích hình vuông là: " + dt.ToString());
                   
                    f2.ShowDialog();
                }
            }
            if(rdHCN.Checked == true)
            {
                if (txtDai.Text == "" || txtRong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu cho chiều dài hoặc chiều rộng!");
                    if (txtDai.Text == "")
                        txtDai.Focus();
                    else
                        txtRong.Focus();
                    return;
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.dai = double.Parse(txtDai.Text);
                    f3.rong = double.Parse(txtRong.Text);
                    double dt = f3.TinhDienTich(f3.dai, f3.rong);
                    // MessageBox.Show("Diện tích hình chữ nhật là: " + dt.ToString());

                    f3.ShowDialog();
                }
            }
            if (rdHT.Checked == true)
            {
                if (txtBK.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu cho bán kính!");
                    txtBK.Focus();
                    return;
                }
                else
                {
                    Form4 f4 = new Form4();
                    f4.BanKinh = double.Parse(txtBK.Text);
                    double dt = f4.TinhDienTich(f4.BanKinh);
                    // MessageBox.Show("Diện tích hình tròn là: " + dt.ToString());
                    f4.ShowDialog();
                }
            }
        }

        private void thựcHiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThucHien_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }

        private void txtCanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép số, dấu chấm, và phím điều khiển (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép số, dấu chấm, và phím điều khiển (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txtRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép số, dấu chấm, và phím điều khiển (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txtBK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép số, dấu chấm, và phím điều khiển (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

        }
    }
}
