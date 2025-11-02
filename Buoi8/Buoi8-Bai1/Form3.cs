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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public double dai, rong;
        public double TinhDienTich(double dai, double rong)
        {
            return dai * rong;
        }
        public double TinhChuVi(double dai, double rong)
        {
            return (dai + rong) * 2;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCV.Text = TinhChuVi(dai, rong).ToString();
            txtDT.Text = TinhDienTich(dai, rong).ToString();
        }
    }
}
