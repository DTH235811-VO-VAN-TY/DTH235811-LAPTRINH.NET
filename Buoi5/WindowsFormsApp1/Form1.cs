using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int[] a;
        public void TaoMang()
        {
            a = new int[10];
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-10, 100);
            }
        }
        public String InMang()
        {
            String s = "";
            for(int i = 0; i < a.Length; i++)
            {
                s += a[i] + " ";
            }
            return s;
        }
        public String InMang2()
        {
            String s = "";
            for (int i = 0; i < c.Length; i++)
            {
                s += c[i] + " ";
            }
            return s;
        }
        public int TongMang()
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }
        public int DemSoLe()
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }
        public int TongSoLe()
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    s += a[i];
            }
            return s;
        }
        public int MinMang()
        {
            int min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
        public int MaxMang()
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
        int[] c;
        public void SapXepTang()
        {
            c = new int[a.Length];
            Array.Copy(a, c, a.Length);
            Array.Sort(c);
        }
        public void SapXepGiam()
        {
            c = new int[a.Length];
            Array.Copy(a, c, a.Length);
            Array.Sort(c);
            Array.Reverse(c);
        }
        private void btnRandomMang_Click(object sender, EventArgs e)
        {
            TaoMang();
            lblGoc.Text = InMang().ToString();
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            TongMang();
            lblKQ.Text = "Tổng Mảng = "+TongMang().ToString();
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            DemSoLe();
            lblKQ.Text = "Số phần tử lẻ là = "+DemSoLe().ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            TongSoLe();
            lblKQ.Text = "Tổng gía trị các phần tử lẻ = "+TongSoLe().ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MinMang();
            lblKQ.Text = "Giá trị nhỏ nhất trong mảng = " + MinMang().ToString();
        }
        int[] b;

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                b = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    b[i] = a[i] + 2;
                }
                String s = "";
                for (int i = 0; i < b.Length; i++)
                {
                    s += b[i] + " ";
                }
                lblKQ.Text = "Mảng sau khi tăng 2 là: " + s;
            }
            else
            {
                MessageBox.Show("Bạn chưa tạo mảng");
            }
        }

        private void btnSXtang_Click(object sender, EventArgs e)
        {
            SapXepTang();
            lblKQ.Text = "Mảng sau khi sắp xếp tăng dần: " + InMang2().ToString();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            SapXepGiam();
            lblKQ.Text = "Mảng sau khi sắp xếp giảm dần: " + InMang2().ToString();
        }
    }
}
