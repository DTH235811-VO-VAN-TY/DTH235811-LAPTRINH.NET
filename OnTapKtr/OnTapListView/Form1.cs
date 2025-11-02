using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KtrMaSV(string maSV)
        {
            foreach (ListViewItem item in lstDanhSachSV.Items)
            {
                if (item.Text == maSV)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KtrMaSV(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại, vui lòng nhập mã khác",
                    "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Vui lòng sửa các lỗi nhập liệu", 
                    "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            ListViewItem item = new ListViewItem(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(dtNgaySinh.Value.ToShortDateString());
            if(rdNam.Checked)
            {
                item.SubItems.Add(rdNam.Text);
            }
            else
            {
                item.SubItems.Add(rdNu.Text);
            }
            item.SubItems.Add(txtDT.Text);
            item.SubItems.Add(cboQueQuan.Text);
            lstDanhSachSV.Items.Add(item);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Vui lòng sửa các lỗi nhập liệu", "Thông báo");
                return;
            }
            if (this.lstDanhSachSV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lstDanhSachSV.SelectedItems[0];
                item.SubItems[0].Text = txtMaSV.Text;
                item.SubItems[1].Text = txtHoTen.Text;
                item.SubItems[2].Text = dtNgaySinh.Value.ToShortDateString();
                if (rdNam.Checked)
                {
                    item.SubItems[3].Text = rdNam.Text;
                }
                else
                {
                    item.SubItems[3].Text = rdNu.Text;
                }
                item.SubItems[4].Text = txtDT.Text;
                item.SubItems[5].Text = cboQueQuan.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa","Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(this.lstDanhSachSV.SelectedItems.Count > 0)
            {
                var xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.No)
                    return;
                else
                {
                    foreach (ListViewItem item in this.lstDanhSachSV.SelectedItems)
                    {
                        this.lstDanhSachSV.Items.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", 
                "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lstDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstDanhSachSV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lstDanhSachSV.SelectedItems[0];
                txtMaSV.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(item.SubItems[2].Text);
                if (item.SubItems[3].Text == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtDT.Text = item.SubItems[4].Text;
                cboQueQuan.Text = item.SubItems[5].Text;
            }
        }
        ErrorProvider errorProvider1 =new ErrorProvider();
        private void txtMaSV_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMaSV, null);
            }
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHoTen, null);
            }
        }

        private void txtDT_Validating(object sender, CancelEventArgs e)
        {
            if(this.txtDT.TextLength != 10 || !txtDT.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDT, "Số điện thoại phải đủ 10 chữ số và chỉ chứa chữ số");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDT, null);
            }
        }

        private void cboQueQuan_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cboQueQuan.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cboQueQuan, "Quê quán không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboQueQuan, null);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            List<ListViewItem> items = lstDanhSachSV.Items.Cast<ListViewItem>().ToList();

            var sortedItems = items.OrderBy(item =>int.Parse(item.Text.Substring(2))).ToList(); // item.Text là Mã SV

            lstDanhSachSV.Items.Clear();
            foreach (var item in sortedItems)
            {
                lstDanhSachSV.Items.Add(item);
            }

        }
    }
}
