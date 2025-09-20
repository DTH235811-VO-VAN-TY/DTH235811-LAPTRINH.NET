using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int Tong = Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Tong + " ";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int Hieu = Convert.ToInt32(txtA.Text) - Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Hieu + " ";
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int Tich = Convert.ToInt32(txtA.Text) * Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Tich + " ";
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int Thuong
                = Convert.ToInt32(txtA.Text) / Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Thuong + " ";
        }

        private void lblKetqua_Click(object sender, EventArgs e)
        {

        }
    }
}
