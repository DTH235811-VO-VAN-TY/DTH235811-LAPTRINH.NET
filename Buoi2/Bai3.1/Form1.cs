using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double kq;
            double x = Convert.ToDouble(textX.Text);
            if (x >= 2)
            {
                kq = -8 * Math.Pow(x, 3) - 12 * x - 1; 
            }
            else if (x > 1 && x < 2)
            {
                kq = Math.Pow(x, 2) - 6 * x - 19;
            }
            else // x ≤ 1
            {
                kq = 7 * x;
            }
            txtKetqua.Text = kq.ToString("F0");


        }
    }
}
