using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string ten = textNhap.Text;
            if(this.textNhap.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu");
            }
            else if(rdLopA.Checked)
            {
                if(this.lstLopA.Items.Contains(this.textNhap.Text))
                    MessageBox.Show("Tên đã tồn tại trong lớp A");
                else this.lstLopA.Items.Add(this.textNhap.Text);
            }
            else if (rdLopB.Checked)
            {
                if (this.lstLopB.Items.Contains(this.textNhap.Text))
                    MessageBox.Show("Tên đã tồn tại trong lớp B");
                else this.lstLopB.Items.Add(this.textNhap.Text);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn lớp");
            }
        }

        private void btnChuyenAB_Click(object sender, EventArgs e)
        {
            if(this.lstLopA.SelectedItems.Count>0)
            {
                if(this.lstLopB.Items.Contains(this.lstLopA.Text))
                    MessageBox.Show("Ten da ton tai trong lop B");
                else
                {
                    List<string> selctItems = new List<string>();
                    foreach (var item in lstLopA.SelectedItems)
                    {
                        selctItems.Add(item.ToString());
                    }
                    foreach (string item in selctItems)
                    {
                        lstLopB.Items.Add(item);
                        lstLopA.Items.Remove(item);
                    }
                }
            }
            else MessageBox.Show("Chưa chọn sinh viên để chuyển");
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnChuyenBA_Click(object sender, EventArgs e)
        {
            if(this.lstLopB.SelectedItems.Count > 0)
            {
                if (this.lstLopA.Items.Contains(this.lstLopB.Text))
                    MessageBox.Show("Ten da ton tai trong lop A");
                else
                {
                    List<string> selctItems = new List<string>();
                    foreach (var item in lstLopB.SelectedItems)
                    {
                        selctItems.Add(item.ToString());
                    }
                    foreach(string item in selctItems)
                    {
                        lstLopA.Items.Add(item);
                        lstLopB.Items.Remove(item);
                    }
                }
            }
            else MessageBox.Show("Chưa chọn sinh viên để chuyển");
        }

        private void MoveAll(ListBox nguon, ListBox dich)
        {
            List<string> toMove = new List<string>();
            foreach (var item in nguon.Items)
            {
                string value = item.ToString();
                if(!dich.Items.Contains(value))
                {
                    toMove.Add(value);
                }
                else MessageBox.Show($"Tên \" {value}\" da ton tai trong lop dich");

            }
            foreach (var value in toMove)
            {
                dich.Items.Add(value);
                
            }
            foreach(var value in toMove)
            {
                nguon.Items.Remove(value);
            }

        }
        private void btnAll_AB_Click(object sender, EventArgs e)
        {
               /* if (this.lstLopB.Items.Contains(this.lstLopA.Text))
                {
                    MessageBox.Show("Ten da ton tai trong lop B");
                    return;
                }
                else*/ MoveAll(this.lstLopA, this.lstLopB);
            
        }

        private void btnAll_BA_Click(object sender, EventArgs e)
        {
            
                if (this.lstLopA.Items.Contains(this.lstLopB.Text))
                {
                    MessageBox.Show("Ten da ton tai trong lop A");
                    return;
                }
                else MoveAll(this.lstLopB, this.lstLopA);
            
        }

        private void btnTongSV_Click(object sender, EventArgs e)
        {
            int Sum = this.lstLopA.Items.Count + this.lstLopB.Items.Count;
            MessageBox.Show("Tổng số sinh viên là: " + Sum.ToString());
        }
    }
}
