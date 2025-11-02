using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapMangSoNguyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập dãy số nguyên");
                return;
            }
            else
            {
                string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
                int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
                this.txtKQ.Text = string.Join(", ", intArr);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
            this.txtNhap.Clear();
            this.txtMax.Clear();
            this.txtMin.Clear();
            this.txtTongChan.Clear();
            this.txtTongLe.Clear();
            this.txtTongMang.Clear();
            this.txtSoThay.Clear();
            this.txtVTthay.Clear();
        }
        private int TongMang()
        {
            string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
            int sum = 0;
            foreach(int num in intArr)
            {
                sum += num;
            }
            return sum;
        }
        private int TongChan()
        {
            string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
            int sum = 0;
            foreach (int num in intArr)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        private int TongLe()
        {
            string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
            int sum = 0;
            foreach (int num in intArr)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        private int MaxMang()
        {
            string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
            return intArr.Max();
        }
        private int MinMang()
        {
            string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
            return intArr.Min();
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập dãy số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.txtTongMang.Text = TongMang().ToString();
                this.txtTongChan.Text = TongChan().ToString();
                this.txtTongLe.Text = TongLe().ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập dãy số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.txtMax.Text = MaxMang().ToString();
                this.txtMin.Text = MinMang().ToString();
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập dãy số nguyên", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(chBTang.Checked==true)
                {
                    string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ', ',' },
                        StringSplitOptions.RemoveEmptyEntries);
                    int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
                    Array.Sort(intArr);
                    this.txtKQ.Text = string.Join(", ", intArr);
                }
                else if(chBGiam.Checked==true)
                {
                    string[] strNumbers = this.txtNhap.Text.Split(new char[] { ' ',','},
                        StringSplitOptions.RemoveEmptyEntries);
                    int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
                    Array.Sort(intArr);
                    Array.Reverse(intArr);
                    this.txtKQ.Text = string.Join(", ", intArr);
                }
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            
            if (this.txtNhap == null || this.txtNhap.Text=="") { 
                MessageBox.Show("Vui lòng nhập dãy số nguyên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtVTthay == null || this.txtVTthay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vị trí cần thay thế", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;            
            }
            if (this.txtSoThay == null || this.txtSoThay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số cần thay thế", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nguonKQ;
            if (string.IsNullOrWhiteSpace(txtKQ.Text))
            {
                nguonKQ=txtNhap.Text;
            }
            else nguonKQ = txtKQ.Text;

            string[] strNumbers = nguonKQ.Split(new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            int[] intArr = Array.ConvertAll(strNumbers, int.Parse);
            int soThayThe = int.Parse(txtSoThay.Text);
            int vtThayThe = int.Parse(txtVTthay.Text);
            if (vtThayThe < 0 || vtThayThe >= intArr.Length)
            {
                MessageBox.Show("Vị trí thay thế không hợp lệ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int[]b = new int[intArr.Length];
                Array.Copy(intArr, b, intArr.Length);
                b[vtThayThe] = soThayThe;
                this.txtKQ.Text = string.Join(", ", b);
            }
        }

        private void groupBox4_TextChanged(object sender, EventArgs e)
        {
            if (chBTang.Checked == true)
            {
                chBGiam.Checked = false;
            }
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=' ' && e.KeyChar!=',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
