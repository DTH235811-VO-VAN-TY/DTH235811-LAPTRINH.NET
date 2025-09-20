using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._1
{
    public partial class from1 : Form
    {
        public from1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            double sum = 0;
            for(int i=1;i<=n;i++)
            {
                sum += i;
            }
            txtS.Text = sum.ToString();
            lblDeBai.Text = " S = 1 + 2 + 3 + ... + n = " + sum;
        }

        private void btnTinh4_2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i*i;
            }
            txtS.Text = sum.ToString();
            lblDeBai.Text = "S = 12 + 22 + 32 + ...+ n2 = " + sum;
        }

        private void btnTinh4_3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1/i;
            }
            txtS.Text = sum.ToString();
            lblDeBai.Text = "S = 1 + 1/2 + 1/3 + 1/4 +...+1/n = " + sum;
        }

        private void btnTinh4_4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            double sum = 0;
            for (int i = 1; i <= 2*n+1; i+=2)
            {
                sum +=i;
            }
            txtS.Text = sum.ToString();
            lblDeBai.Text = "S = 1 + 3 + 5 + ... + (2n-1) + (2n+1) = " + sum;
        }

        private void btnTinh4_5_Click(object sender, EventArgs e)
        {
             int n = Convert.ToInt32(txtN.Text);
            double sum = 0;
            for (int i = 2; i <= 2*n; i+=2)
            {
                sum += i;
            }
            txtS.Text = sum.ToString();
            lblDeBai.Text = "S = 2 + 4 + 6 + ... + (2n-2) + 2n = " + sum;
        }

        private void btnTinh4_6_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1/2*i-1;
            }
            txtS.Text = sum.ToString();
            lblDeBai.Text = "1 + 1/3 + 1/5 +..1/2n-1 = "+sum;
        }

        private void btnTinh4_7_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            txtS.Text = sum.ToString();
            lblDeBai.Text = "S = n! = 1*2*3*...*(n-1)*n = " + sum;
        }
    }
}
