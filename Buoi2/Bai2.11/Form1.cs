using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuvi_Click(object sender, EventArgs e)
        {
            MessageBox.Show((2 * (Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text))).ToString());
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txtA.Text) * Convert.ToInt32(txtB.Text)).ToString());
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Math.Sqrt(Math.Pow(Convert.ToInt32(txtA.Text), 2)
                + Math.Pow(Convert.ToInt32(txtB.Text), 2))).ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
