using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            public int TimMax(int s1, int s2)
        {
            if (s1 < s2)
            {
                return s1;
            }
            else return s2;
        }
        public String TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            String Chuoi = "";
            for (int i = 1; i <= max; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    Chuoi += " " + i.ToString();
                }
            }
            return Chuoi;
        }
        public int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else b -= a;
            }
            return a;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(this.txtN.Text);
            b = int.Parse(this.txtM.Text);
            if (this.rad1.Checked == true)
                this.txtKQ.Text = TimUocChung(a, b);
            if (this.rad2.Checked == true)
                this.txtKQ.Text = TimUCLN(a, b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtN.Clear();
            this.txtM.Clear();
            this.txtKQ.Clear();
            this.txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.OKCancel
               , MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
