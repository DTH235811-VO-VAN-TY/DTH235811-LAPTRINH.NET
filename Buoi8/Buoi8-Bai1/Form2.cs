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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public double CanhA;
        public double TinhDienTich(double CanhA)
        {
            return CanhA * CanhA;
        }
        public double TinhChuVi(double CanhA)
        {
            return 4 * CanhA;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            txtDT.Text = TinhDienTich(CanhA).ToString();
            txtCV.Text = TinhChuVi(CanhA).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }
    }
}
