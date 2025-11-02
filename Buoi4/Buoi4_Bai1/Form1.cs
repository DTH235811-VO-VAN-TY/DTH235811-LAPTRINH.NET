using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_Bai1
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }
        int[]a = new int [10];
        int sopt = 0;
        int[] b = new int[10];
        
        public String InMang()
        {
            String chuoi = "";
            for(int i=0;i<sopt;i++)
            {
                chuoi += a[i] + " "; 
            }return chuoi;
        }
        public String InMang2()
        {
            
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                chuoi += b[i] + " ";
            }
            return chuoi;
        }
        public int TimMax()
        {
            int max= a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for(int i=0;i<sopt;i++)
            {
                sum += a[i];
            }
            tb = (double)sum/(double)sopt;
            tb = Math.Round(tb, 2);
            return tb;
        }
        public double TTongMang()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                sum += a[i];
            }
            
            return sum;
        }
        
        public void SapXepTang()
        {
           // int[] b = new int[10];
            Array.Copy(a, b, sopt);

            Array.Sort(b,0,sopt);
        }
        public void SapXepGiam()
        {
            Array.Copy(a, b, sopt);
            Array.Sort (b,0,sopt);
            Array.Reverse (b,0,sopt);
        }
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public Boolean kiemTraSNT(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for(int i=2;i<=Math.Sqrt(n);i++)
                {
                    if(n%i==0)
                         return false; 
                }
                return true;
            }
        }
        public int DemSNT()
        {
            int dem = 0;
            for(int i=0; i<sopt;i++)
            {
                if (kiemTraSNT(a[i]) == true)
                    dem++;
            }
            return dem;
        }
        public String InSNT()
        {
            String chuoi = "";
            for(int i=0;i<sopt;i++)
            {
                if (kiemTraSNT(a[i]) == true)
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        public Boolean kiemTraSHH(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n)
                return true;
            else
                return false;
        }
        public String InSHH()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]) == true)
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        public int DemSHH()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]) == true)
                    dem++;
            }
            return dem;
        }
        public int DemSoLe()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }
        public int DemSoChan()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                    dem++;
            }
            return dem;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {

            try
            {
                int n = int.Parse(txtNhap.Text);    
                if (sopt < 10)
                {
                    a[sopt] = n;
                    sopt++;
                    lblKQ.Text +=n + " ";
                    txtNhap.Clear();
                    txtNhap.Focus();
                }
                else
                {
                    lblKQ.Text = "Mảng đã đầy";
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            if(sopt>0)
                this.btnInMang.Enabled = true;

        }

        private void btnInMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();
            }
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                SapXepTang();
                this.lblKQ.Text = "Đã sắp xếp mảng tăng dần\n" + InMang2();
            }
        }

        private void btnSXgiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                SapXepGiam();
                this.lblKQ.Text = "Đã sắp xếp mảng giảm dần\n"+ InMang2();
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {

                lblKQ.Text = "Tổng các phần tử trong mảng là: " + TTongMang();
            }
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                lblKQ.Text = "Phần tử lớn nhất trong mảng là: " + TimMax();
            }
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                lblKQ.Text = "Trung bình cộng các phần tử trong mảng là: " + TrungBinhMang();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                
                lblKQ.Text = "Phần tử nhỏ nhất trong mảng là: " + TimMin();
            }
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            if(sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                int dem = DemSHH();
                if (dem == 0)
                    lblKQ.Text = "Không có số hoàn hảo trong mảng";
                else
                    lblKQ.Text = "Có " + dem.ToString() + " số hoàn hảo trong mảng\n" + InSHH();
            }
        }

        private void btnSNT_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                int dem = DemSNT();
                if (dem == 0)
                    lblKQ.Text = "Không có số nguyên tố trong mảng";
                else
                    lblKQ.Text = "Có " + dem + " số nguyên tố trong mảng\n" + InSNT();
            }
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if(sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                lblKQ.Text = "Có " + DemSoLe() + " số lẻ trong mảng";
            }
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            if(sopt == 0)
            {
                lblKQ.Text = "Mảng rỗng";
            }
            else
            {
                lblKQ.Text = "Có " + DemSoChan() + " số chẵn trong mảng";
            }
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if(sopt < 2)
            {
                lblKQ.Text = "Phải có ít nhất 2 phần tử trong mảng";
            }
            else
            {
                lblKQ.Text = "ước chung lớn nhất của 2 phần tử đầu " + a[0]+ " và " + a[1] + " là: " + timUCLN(a[0], a[1]).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtNhap.Focus();
            lblKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
