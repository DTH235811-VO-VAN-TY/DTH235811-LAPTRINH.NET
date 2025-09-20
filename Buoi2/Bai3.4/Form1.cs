using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int ngay = Convert.ToInt32(txtNgay.Text);
            int thang = Convert.ToInt32(txtThang.Text);
            int nam = Convert.ToInt32(txtNam.Text);
            if ((thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10) && (1<= ngay && ngay <= 31))
            {

                MessageBox.Show("Ngay Hop Le!");
                
            }
            else if(thang == 2 &&( 1<=ngay&&ngay <= 28))
            {
                MessageBox.Show("Ngay Hop Le");
            }
            else if((thang == 4 || thang == 6 || thang == 9 || thang == 11)&& (1<=ngay && ngay <= 30))
            {
                MessageBox.Show("Ngay hop le!");
            }
            else
            {
                MessageBox.Show("Ngay KHONG hop le!");
            }
        }
    }
}
