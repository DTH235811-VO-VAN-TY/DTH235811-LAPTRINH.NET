using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
{
    public partial class TinhToanDonGian : Form
    {
        public TinhToanDonGian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text)).ToString());
            int Tong = Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Tong + " ";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txtA.Text) - Convert.ToInt32(txtB.Text)).ToString());
            int Hieu = Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Hieu + " ";
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txtA.Text) * Convert.ToInt32(txtB.Text)).ToString());
            int Tich = Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Tich + " ";
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txtA.Text) / Convert.ToInt32(txtB.Text)).ToString());
            int Thuong = Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text);
            lblKetqua.Text = Thuong + " ";
        }
    }
}
