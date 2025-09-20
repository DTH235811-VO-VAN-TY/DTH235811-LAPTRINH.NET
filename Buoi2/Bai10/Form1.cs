using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuvi_Click(object sender, EventArgs e)
        {
            int Chuvi = 2*(Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text));
            lblKetqua.Text = Chuvi + " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int DienTich
                = Convert.ToInt32(txtA.Text) * Convert.ToInt32(txtB.Text);
            lblKetqua.Text = DienTich + " ";
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double Cheo = Math.Sqrt(Math.Pow(Convert.ToInt32(txtA.Text),2) 
                + Math.Pow(Convert.ToInt32(txtB.Text),2));
            lblKetqua.Text = Cheo + " ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
