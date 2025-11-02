using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Boolean KTSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            // Remove the incorrect attempt to assign to the method group
            this.txtNhap.TextChanged -= txtNhap_TextChanged_1; // Unsubscribe the event handler
            this.txtNhap.Clear();
            this.txtNhap.Focus();
            this.txtKiemTra.Clear();
            this.txtSNTnho.Clear();
           this.txtNhap.TextChanged += txtNhap_TextChanged_1; // Resubscribe the event handler
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
        public Boolean KTSHH(int n)
        {
            int tong = 0;
            if (n < 2) return false;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;

                }
            }
            return tong == n;
        }

        private void txtNhap_TextChanged_1(object sender, EventArgs e)
        {
            this.txtKiemTra.Clear();
            this.txtSNTnho.Clear();
            if (this.txtNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!");
                this.txtNhap.Focus();
                return;
            }
            else
            {
                int n = int.Parse(this.txtNhap.Text);
                if (KTSNT(n))
                {
                    this.txtKiemTra.Text = n.ToString() + " là số nguyên tố!";
                    // MessageBox.Show(n.ToString() + " là số hoàn hảo!");
                }
                else
                {
                    this.txtKiemTra.Text = n.ToString() + " không phải là số nguyên tố!";
                    // MessageBox.Show(n.ToString() + " không phải là số hoàn hảo!");
                }
                for (int i = 2; i < n; i++)
                {

                    if (KTSNT(i))
                    {
                        this.txtSNTnho.Text += i.ToString() + " ";
                    }
                }
            }
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }   
        }
    }
}
