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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        int n;
        public String InMang()
        {
            string chuoi = "";
            for (int i = 0; i < a.Length; i++)
            {
                chuoi += a[i] + " ";
            }
            return chuoi;
        }
        public void TaoMang()
        {
            n = int.Parse(txtNhap.Text);
            a = new int[n];
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if(txtNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phần tử", "Thong bao");
                txtNhap.Focus();
            }
           
            else if(Convert.ToInt32(txtNhap.Text) < 0)
            {
                n = Convert.ToInt32(txtNhap.Text);
                MessageBox.Show("Bạn vừa nhập n = "+n+". Số phần tử phải > 0", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập m =  " + n + ". Số phần từ mảng phải > 0", "Thông báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang();
                     MessageBox.Show("Mảng có "+n+"phần tử phát sinh ngẫu nhiên vừa tạo "+InMang(),"Thông Báo!");
                    btnTong.Enabled = true;
                    btnMax.Enabled = true;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Các phần tử của mảng là: "+InMang()+"\n\rBạn có muốn tính tổng các phần tử trong mảng không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            { 
                Form2 f2 = new Form2(a);
                f2.ShowDialog();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Các phần tử của mảng là: " + InMang() + "\n\rBạn có muốn tìm phần tử lớn nhất trong mảng không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Form3 f3 = new Form3(a);
                f3.ShowDialog();
            }
        }
    }
}
