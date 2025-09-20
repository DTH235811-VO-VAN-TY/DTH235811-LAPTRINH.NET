using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(txtThang.Text);
            if (month == 1 || month == 2 || month == 3)
            {
                MessageBox.Show("Mùa Xuân!");
            }
            else if(month == 4 || month == 5 || month == 6)
            {
                MessageBox.Show("Mùa hạ!");
            }
            else if(month == 7 || month == 8 || month == 9)
            {
                MessageBox.Show("Mùa thu!");
            }
            else
            {
                MessageBox.Show("Mùa đông!");
            }
        }
    }
}
