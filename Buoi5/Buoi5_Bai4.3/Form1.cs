using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (this.txtTu1.Text == "" || this.txtTu2.Text == ""||
                this.txtMau1.Text == "" || this.txtMau2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tử số và mẫu số");
                this.txtTu1.Focus();
                return;
            }
            
            int tu1 = int.Parse(this.txtTu1.Text);
            int mau1 = int.Parse(this.txtMau1.Text);
            int tu2 = int.Parse(this.txtTu2.Text);
            int mau2 = int.Parse(this.txtMau2.Text);
            
            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0");
                return;
            }
            int tuso = tu1 * mau2 + tu2 * mau1;
            int mauso = mau1 * mau2;
            int ucln = UCLN(tuso, mauso);
            tuso /= ucln;
            mauso /= ucln;
            this.txtTuKQ.Text = tuso.ToString();
            this.txtMauKQ.Text = mauso.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (this.txtTu1.Text == "" || this.txtTu2.Text == "" ||
                this.txtMau1.Text == "" || this.txtMau2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tử số và mẫu số");
                this.txtTu1.Focus();
                return;
            }

            int tu1 = int.Parse(this.txtTu1.Text);
            int mau1 = int.Parse(this.txtMau1.Text);
            int tu2 = int.Parse(this.txtTu2.Text);
            int mau2 = int.Parse(this.txtMau2.Text);

            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0");
                return;
            }
            int tuso = tu1 * mau2 - tu2 * mau1;
            int mauso = mau1 * mau2;
            int ucln = UCLN(tuso, mauso);
            tuso /= ucln;
            mauso /= ucln;
            this.txtTuKQ.Text = tuso.ToString();
            this.txtMauKQ.Text = mauso.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (this.txtTu1.Text == "" || this.txtTu2.Text == "" ||
                this.txtMau1.Text == "" || this.txtMau2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tử số và mẫu số");
                this.txtTu1.Focus();
                return;
            }

            int tu1 = int.Parse(this.txtTu1.Text);
            int mau1 = int.Parse(this.txtMau1.Text);
            int tu2 = int.Parse(this.txtTu2.Text);
            int mau2 = int.Parse(this.txtMau2.Text);

            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0");
                return;
            }
            int tuso = tu1 * tu2;
            int mauso = mau1 * mau2;
            int ucln = UCLN(tuso, mauso);
            tuso /= ucln;
            mauso /= ucln;
            this.txtTuKQ.Text = tuso.ToString();
            this.txtMauKQ.Text = mauso.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (this.txtTu1.Text == "" || this.txtTu2.Text == "" ||
                this.txtMau1.Text == "" || this.txtMau2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tử số và mẫu số");
                this.txtTu1.Focus();
                return;
            }

            int tu1 = int.Parse(this.txtTu1.Text);
            int mau1 = int.Parse(this.txtMau1.Text);
            int tu2 = int.Parse(this.txtTu2.Text);
            int mau2 = int.Parse(this.txtMau2.Text);

            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0");
                return;
            }
            int tuso = tu1 * mau2 ;
            int mauso = mau1 * tu2;
            int ucln = UCLN(tuso, mauso);
            tuso /= ucln;
            mauso /= ucln;
            this.txtTuKQ.Text = tuso.ToString();
            this.txtMauKQ.Text = mauso.ToString();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            this.txtTu1.Clear();
            this.txtMau1.Clear();
            this.txtTu2.Clear();
            this.txtMau2.Clear();
            this.txtTuKQ.Clear();
            this.txtMauKQ.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (DialogResult.OK == traloi)
                Application.Exit();
        }
    }
}
