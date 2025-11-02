using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean KTSHH(int n)
        {
            int tong = 0;
            if(n<2) return false;
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                    
                }
            }
            return tong==n;
        }
        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.txtNhap.TextChanged -= txtNhap_TextChanged;
            this.txtNhap.Clear();
            this.txtNhap.Focus();
            this.txtKiemTra.Clear();
            this.txtSNTnho.Clear();
            this.txtNhap.TextChanged += txtNhap_TextChanged;
        }

        private void btnKT_Click(object sender, EventArgs e)
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
                if (KTSHH(n))
                {
                    this.txtKiemTra.Text = n.ToString() + " là số hoàn hảo!";
                    // MessageBox.Show(n.ToString() + " là số hoàn hảo!");
                }
                else
                {
                    this.txtKiemTra.Text = n.ToString() + " không phải là số hoàn hảo!";
                    // MessageBox.Show(n.ToString() + " không phải là số hoàn hảo!");
                }
                for (int i = 2; i < n; i++)
                {

                    if (KTSHH(i))
                    {
                        this.txtSNTnho.Text += i.ToString() + " ";
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
