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
        int n;
        public void TaoMang()
        {
            a = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(-10, 100);
            }
        }
        public String InMang()
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += a[i].ToString() + " ";
            }
            return str;
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if(this.txtSoPT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phần tử");
                return;
            }
            else
            {
                n = int.Parse(this.txtSoPT.Text);
                TaoMang();
                MessageBox.Show("Mảng có " + n + " phát sinh ngẫu nhiên vừa tạo " + InMang());
            }
            btnMax.Enabled = true;
            btnTongMang.Enabled = true;
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Các phần tử của mảng là "+InMang()+"\n\rBạn có muốn tính tổng mảng không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi==DialogResult.OK)
            {
                Form2 f2 = new Form2(a);
                f2.ShowDialog();
            }

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Các phần tử của mảng là " + InMang() + "\n\rBạn có muốn tìm giá trị lớn nhất không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Form3 form3 = new Form3(a);
                form3.ShowDialog();
            }
        }
    }
}
