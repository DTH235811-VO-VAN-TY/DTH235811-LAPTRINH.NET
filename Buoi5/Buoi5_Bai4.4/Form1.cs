using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void An()
        {
            this.groChuNhat.Visible = false;
            this.groTamGiac.Visible = false;
            this.groTron.Visible = false;
            this.groVuong.Visible = false;
        }

        private void rdVuong_CheckedChanged(object sender, EventArgs e)
        {
            An();
            this.groVuong.Visible = true;
        }

        private void rdTron_CheckedChanged(object sender, EventArgs e)
        {
            An();
            this.groTron.Visible = true;
        }

        private void rdChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            An();
            this.groChuNhat.Visible = true;
        }

        private void rdTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            An();
            this.groTamGiac.Visible = true;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(this.rdVuong.Checked==true)
            {
                double a = double.Parse(this.txtVuong.Text);
                double cv = 4 * a;
                double dt = a * a;
                txtCVvuong.Text = cv.ToString();
                txtDTvuong.Text = dt.ToString();
            }
            if(this.rdTamGiac.Checked == true)
            {
                double a = double.Parse(this.txtA.Text);
                double b = double.Parse(this.txtB.Text);
                double c = double.Parse(this.txtC.Text);
                double cv = a + b + c;
                double p = cv / 2;
                double dt = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                if (a == b && a == c && b == c)
                {
                    this.txtLoaiTG.Text = "Tam Giác Đều";
                }
                else if (a == b || a == c || b == c)
                {
                    this.txtLoaiTG.Text = "Tam Giác Cân";
                }
                else if(Math.Pow(a,2)+Math.Pow(b,2)==Math.Pow(c,2))
                {
                    this.txtLoaiTG.Text = "Tam Giác Vuông";
                }
                else if(Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)&& (a == b || a == c || b == c))
                {
                    this.txtLoaiTG.Text = "Tam Giác Vuông Cân";
                }
                else
                {
                    this.txtLoaiTG.Text = "Tam Giác Thường";
                }
                txtCVtg.Text = cv.ToString();
                txtDTtg.Text = dt.ToString();

            }
            if(this.rdTron.Checked == true)
            {
                double r = double.Parse(this.txtBKtron.Text);
                double cv = (double)(2 * Math.PI * r);
                double dt = (double)(Math.PI * r * r);
                txtCVtron.Text = cv.ToString();
                txtDTtron.Text = dt.ToString();
            }
            if (this.rdChuNhat.Checked == true)
            {
                double a = double.Parse(this.txtAcn.Text);
                double b = double.Parse(this.txtBcn.Text);
                double cv = (a + b) * 2;
                double dt = a * b;
                txtCVcn.Text = cv.ToString();
                txtDTcn.Text = dt.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           this.txtA.Clear();
            this.txtAcn.Clear();
            this.txtB.Clear();
            this.txtBcn.Clear();
            this.txtBKtron.Clear();
            this.txtCVcn.Clear();
            this.txtCVtg.Clear();
            this.txtCVtron.Clear();
            this.txtCVvuong.Clear();
            this.txtDTcn.Clear();
            this.txtDTtg.Clear();
            this.txtDTtron.Clear();
            this.txtDTvuong.Clear();
            this.txtLoaiTG.Clear();
            this.txtVuong.Clear();
            this.txtC.Clear();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
