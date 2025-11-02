using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi8_Bai1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public double BanKinh;
        public double TinhDienTich(double BanKinh)
        {
            return Math.PI * BanKinh * BanKinh;
        }
        public double TinhChuVi(double BanKinh)
        {
            return 2 * Math.PI * BanKinh;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            txtCV.Text = TinhChuVi(BanKinh).ToString("F2");
            txtDT.Text = TinhDienTich(BanKinh).ToString("F2");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }
    }
}
