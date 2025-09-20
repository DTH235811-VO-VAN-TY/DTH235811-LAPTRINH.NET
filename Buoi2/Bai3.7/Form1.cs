using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int c = Convert.ToInt32(txtC.Text);
            int delta = (int)Math.Pow(b, 2) - (4 * a * c);
            if (delta < 0)
            {
                lblKetqua.Text = "Phương trình vô nghiêm!";
            }
            else if (delta == 0) {
                int x = 0;
                x = -b / 2 * a;
                lblKetqua.Text = "Phuong trinh co nghiem kep x1 = x2 = "+x;
            }
            else
            {
                int x1 = (int)(-b + Math.Sqrt(delta)) / (2 * a);
                int x2 = (int)(-b - Math.Sqrt(delta)) / (2 * a);
                lblKetqua.Text = "PT co 2 ngiem x1 = " + x1 + ", x2 = " + x2;
            }
        }
    }
}
