using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapPhanMang
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
            for(int i=0;i<b.Length;i++)
            {
                sum += b[i];
            }
            return sum;
        }
        public Form2(int[]a):this()
        {
            b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            label1.Text = "Tổng các phần tử là : " + TongMang().ToString();
        }
    }
}
