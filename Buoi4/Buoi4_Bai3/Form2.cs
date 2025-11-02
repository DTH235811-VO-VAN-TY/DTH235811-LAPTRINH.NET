using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_Bai3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int[] b;
        public int TongMang()
        {
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            return sum;
        }
        public Form2(int[]a):this()
        {
            int n = a.Length;
            b = new int[n];
            Array.Copy(a, b, a.Length);
           lblToong.Text = "Tổng các phần tử trong mảng là: " + TongMang().ToString();

        }

        private void lblToong_Click(object sender, EventArgs e)
        {

        }
    }
}
