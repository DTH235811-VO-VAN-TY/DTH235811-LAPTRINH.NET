using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_Bai2
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }
        private void From1_Load(object sender, EventArgs e)
        {

        }
        int[] a;
        int n;
        
        public String InMang()
        {
            string chuoi = "";
            for(int i = 0;i < a.Length; i++)
            {
                chuoi += a[i] + " ";
            }return chuoi;
        }
        public void TaoMang()
        {
            n = int.Parse(txtNhap.Text);
            a = new int[n];
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                num1 =rd.Next(-10, 100);
                a[i] = num1;
            }
        }
        private void btnInMang_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            lblKQ.Text += "Các phần tử của mảng là: "+ InMang();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phần tử", "Thong bao");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if(n<0)
                {
                    MessageBox.Show("Bạn vừa nhập m =  "+n+". Số phần từ mảng phải > 0", "Thông báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang();
                    lblKQ.Text = "Mảng với "+n+" phần tử phát sinh ngẫu nhiên vừa tạo là: ";
                    btnInMang.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
