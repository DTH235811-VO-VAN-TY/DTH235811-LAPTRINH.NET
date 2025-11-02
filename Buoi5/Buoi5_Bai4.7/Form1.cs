using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int TinhTong()
        {
            string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            int sum = 0;
            foreach (int num in intArr)
            {
                sum += num;
            }
            return sum;
        }
        public int TinhTongChan()
        {
            string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            int sumChan = 0;
            foreach (int num in intArr)
            {
                if (num % 2 == 0)
                {
                    sumChan += num;
                }
            }
            return sumChan;
        }
        public int TinhTongLe()
        {
            string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            int sumLe = 0;
            foreach (int num in intArr)
            {
                if (num % 2 != 0)
                {
                    sumLe += num;
                }
            }
            return sumLe;
        }
        public int TimMax()
        {
            string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            int max = intArr[0];
            foreach (int num in intArr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        public int TimMin()
        {
            string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            int min = intArr[0];
            foreach (int num in intArr)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (this.txtNhapMang == null || this.txtNhapMang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mảng số nguyên");
                return;
            }
            this.txtTongMang.Text=TinhTong().ToString();
            this.txtTongChan.Text = TinhTongChan().ToString();
            this.txtTongLe.Text = TinhTongLe().ToString();
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            if(this.txtNhapMang== null || this.txtNhapMang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mảng số nguyên");
                return;
            }
            string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            this.txtKQ.Text = string.Join(", ", intArr);
        }

        private void btnTimM_Click(object sender, EventArgs e)
        {
            if(this.txtNhapMang == null || this.txtNhapMang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mảng số nguyên");
                return;
            }
            this.txtMax.Text = TimMax().ToString();
            this.txtMin.Text = TimMin().ToString();
        }

        private void btnSX_Click(object sender, EventArgs e)
        {
            if (this.rdSxGiam.Checked == true)
            {
                string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] intArr = Array.ConvertAll(strArr, int.Parse);
                Array.Sort(intArr);
                Array.Reverse(intArr);
                this.txtKQ.Text = string.Join(", ", intArr);
            }
            else if (this.rdSxTang.Checked == true)
            {
                string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] intArr = Array.ConvertAll(strArr, int.Parse);
                Array.Sort(intArr);
                this.txtKQ.Text = string.Join(", ", intArr);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp");
                return;
            }
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if(this.txtNhapMang == null || this.txtNhapMang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mảng số nguyên");
                return;
            }
            if (this.txtVTthay == null || this.txtVTthay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số cần thay thế");
                return;
            }
            if (this.txtSoThay == null || this.txtSoThay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị thay thế");
                return;
            }
            string[] strArr = this.txtNhapMang.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strArr, int.Parse);
            int vtThay = int.Parse(this.txtVTthay.Text);
            int soThay = int.Parse(this.txtSoThay.Text);
            if (vtThay < 0 || vtThay >= intArr.Length)
            {
                MessageBox.Show("Vị trí thay thế không hợp lệ");
                return;
            }
            MessageBox.Show("Thay thế thành công");
            intArr[vtThay] = soThay;
            this.txtKQ.Text = string.Join(", ", intArr);
        }

        private void txtNhapMang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtNhapMang.Clear();
            this.txtKQ.Clear();
            this.txtMin.Clear();
            this.txtMax.Clear();
            this.txtSoThay.Clear();
            this.txtTongChan.Clear();
            this.txtTongLe.Clear();
            this.txtTongMang.Clear();
            this.txtVTthay.Clear();
        }
    }
}
