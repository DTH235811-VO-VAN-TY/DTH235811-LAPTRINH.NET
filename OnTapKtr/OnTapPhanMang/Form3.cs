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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int[] c;
        public int Max()
        {
            int max = 0;
            for(int i=0;i<c.Length; i++)
            {
                if (c[i] > max)
                {
                    max = c[i];
                }
            }
            return max;
        }
        public Form3(int[] a) : this()
        {
            c = new int[a.Length];
            Array.Copy(a, c, a.Length);
            label1.Text = "Phần tử lớn nhất trong mảng là : " + Max().ToString();
        }
    }
}
