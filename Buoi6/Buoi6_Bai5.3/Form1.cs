using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDanhSachSV.Columns.Add("Ma SV", 100);
            lstDanhSachSV.Columns.Add("Ho Va Ten", 240);
            lstDanhSachSV.Columns.Add("Ngày Sinh", 110);
            lstDanhSachSV.Columns.Add("Phai", 100);
            lstDanhSachSV.Columns.Add("Dien Thoai", 200);
            lstDanhSachSV.Columns.Add("Que Quan", 250);

        }
        private bool KtrMaSV(string maSV)
        {
            foreach (ListViewItem item in lstDanhSachSV.Items)
            {
                if (item.Text == maSV)
                    return true;
            }
            return false;
        }
        private bool KtrDT(string dt)
        {
            foreach (ListViewItem item in lstDanhSachSV.Items)
            {
                if (item.SubItems[4].Text == dt)
                    return true;
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Bạn vui lòng nhập đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(KtrMaSV(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = new ListViewItem(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(dtNgay.Value.ToShortDateString());
            if(rdNam.Checked)
                item.SubItems.Add("Nam");
            else
                item.SubItems.Add("Nữ");
            if (KtrDT(txtDT.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            item.SubItems.Add(txtDT.Text);
            item.SubItems.Add(cbQueQuan.Text);
            lstDanhSachSV.Items.Add(item);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Bạn vui lòng nhập đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstDanhSachSV.SelectedItems.Count > 0)
            {
                ListViewItem item = lstDanhSachSV.SelectedItems[0];
                item.SubItems[0].Text = txtMaSV.Text;
                item.SubItems[1].Text = txtHoTen.Text;
                item.SubItems[2].Text = dtNgay.Value.ToShortDateString();
                if (rdNam.Checked)
                    item.SubItems[3].Text = "Nam";
                else
                    item.SubItems[3].Text = "Nữ";
                item.SubItems[4].Text = txtDT.Text;
                item.SubItems[5].Text = cbQueQuan.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lstDanhSachSV.Update();
            
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lstDanhSachSV.SelectedItems.Count > 0)
            {
                var xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(xacnhan == DialogResult.Yes)
                {
                    foreach(ListViewItem item in lstDanhSachSV.SelectedItems)
                    {
                        lstDanhSachSV.Items.Remove(item);
                    }
                }
            }
            else MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtDT_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (txtDT.Text.Length != 10 || !txtDT.Text.All(char.IsDigit))
            {
                errorProvider.SetError(txtDT, "Số điện thoại phải gồm đúng 10 chữ số.");
                e.Cancel = true; // Ngăn người dùng chuyển sang control khác
            }
            else
            {
                errorProvider.SetError(txtDT, "");
            }

        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void txtMaSV_Validating(object sender, CancelEventArgs e)
        {
            if(this.txtMaSV.Text== "")
            {
                errorProvider.SetError(txtMaSV, "Mã sinh viên không được để trống.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtMaSV, "");
            }
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if(this.txtHoTen.Text == "")
            {
                errorProvider.SetError(txtHoTen, "Họ và tên không được để trống.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtHoTen, "");
            }
        }

        private void cbQueQuan_Validating(object sender, CancelEventArgs e)
        {
            if(this.cbQueQuan.Text == "")
            {
                errorProvider.SetError(cbQueQuan, "Quê quán không được để trống.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbQueQuan, "");
            }
        }

        private void lstDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstDanhSachSV.SelectedItems.Count > 0)
            {
                ListViewItem item = lstDanhSachSV.SelectedItems[0];
                txtMaSV.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                dtNgay.Value = DateTime.Parse(item.SubItems[2].Text);
                if (item.SubItems[3].Text == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtDT.Text = item.SubItems[4].Text;
                cbQueQuan.Text = item.SubItems[5].Text;
            }
        }
    }
}
