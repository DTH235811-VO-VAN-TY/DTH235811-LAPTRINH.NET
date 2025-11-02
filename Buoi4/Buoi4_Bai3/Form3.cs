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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        int[] c;
        public int TimMax()
        {
            int max = c[0];
            for (int i = 1; i < c.Length; i++)
            {
                if (c[i] > max)
                    max = c[i];
            }
            return max;
        }
        public Form3(int[]a) : this()
        {
            int n = a.Length;
            c = new int[n];
            Array.Copy(a, c, a.Length);
            lblMax.Text = "Phần tử lớn nhất trong mảng là: " + TimMax().ToString();
        }
    }
}
