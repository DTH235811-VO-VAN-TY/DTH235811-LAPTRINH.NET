using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (this.rdLopA.Checked == true)
                {
                    if(lbLopA.Items.Contains(txtHoTen.Text))
                    {
                        MessageBox.Show("Học sinh đã tồn tại trong lớp A", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else 
                        lbLopA.Items.Add(txtHoTen.Text);
                }
                else if (this.rdLopB.Checked == true)
                {
                    if(lbLopB.Items.Contains(txtHoTen.Text))
                    {
                        MessageBox.Show("Học sinh đã tồn tại trong lớp B", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                        lbLopB.Items.Add(txtHoTen.Text);
                }
            }
        }

        private void btnMoveAB_Click(object sender, EventArgs e)
        {
            if (this.lbLopA.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh cần chuyển", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<string> toMove = new List<string>();
                foreach (string item in lbLopA.SelectedItems)
                {
                    string ten = item.ToString();
                    if (lbLopB.Items.Contains(ten))
                    {
                        MessageBox.Show("Sinh viên đã tồn tại trong lớp B", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lbLopB.Items.Add(ten);
                        toMove.Add(ten);
                    }
                }

                foreach (string ten in toMove)
                {
                    lbLopA.Items.Remove(ten);
                }
            }
           }
        private void btnMoveBA_Click(object sender, EventArgs e)
        {
            if(this.lbLopB.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh cần chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<string> toMove = new List<string>();
                foreach (string item in lbLopB.SelectedItems)
                {
                    string ten = item.ToString();
                    if (lbLopA.Items.Contains(ten))
                    {
                        MessageBox.Show("Sinh viên đã tồn tại trong lớp A", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lbLopA.Items.Add(ten);
                        toMove.Add(ten);
                    }
                }
                foreach (string ten in toMove)
                {
                    lbLopB.Items.Remove(ten);
                }
            }
        }
        private void MoveAll(ListBox nguon, ListBox dich)
        {
            List<string> itemsToMove = new List<string>();
            foreach (string item in nguon.Items)
            {
                string value = item.ToString();
                if (!dich.Items.Contains(value))
                {
                    itemsToMove.Add(value);
                }
                else MessageBox.Show($" Ten {value} da ton tai trong danh sach dich", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (string item in itemsToMove)
            {
                dich.Items.Add(item);

            }
            foreach (string item in itemsToMove)
            {
                nguon.Items.Remove(item);
            }
        }
        private void btnMoveAll_AB_Click(object sender, EventArgs e)
        {
            if (this.lbLopA.SelectedItems == null)
            {
                MessageBox.Show("Lớp A không có học sinh để chuyển", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MoveAll(lbLopA, lbLopB);
            }
        }

        private void btnMoveAll_BA_Click(object sender, EventArgs e)
        {
            if (this.lbLopB.SelectedItems == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MoveAll(lbLopB, lbLopA);
            }
        }

        private void btnTongSV_Click(object sender, EventArgs e)
        {
            int sum = lbLopA.Items.Count + lbLopB.Items.Count;
            MessageBox.Show("Tổng số sinh viên trong cả hai lớp là: " + sum.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
