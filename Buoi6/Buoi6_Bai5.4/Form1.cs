using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buoi6_Bai5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*lstDanhSachSV.Columns.Add("Ma SV", 200);
            lstDanhSachSV.Columns.Add("Ho Va Ten", 220);
            lstDanhSachSV.Columns.Add("Địa chỉ", 200);
            lstDanhSachSV.Columns.Add("Ngày Sinh", 200);
            lstDanhSachSV.Columns.Add("Lớp", 200);*/
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Bạn vui lòng nhập đẩy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (KtrMaSV(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = new ListViewItem(txtMaSV.Text);
            //item.SubItems.Add(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(txtDC.Text);
            if (dtNgaySinh.Value != null)
                item.SubItems.Add(dtNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(cbLop.Text);
            lstDanhSachSV.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSachSV.SelectedItems.Count > 0)
            {
                var xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lstDanhSachSV.SelectedItems)
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
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lstDanhSachSV.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống!", "Thông báo");
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // Ghi tiêu đề với độ rộng cố định
                    sw.WriteLine(
                        "Mã SV".PadRight(10) +
                        "Họ Tên".PadRight(20) +
                        "Địa Chỉ".PadRight(20) +
                        "Ngày Sinh".PadRight(15) +
                        "Lớp".PadRight(10)
                    );

                    // Ghi từng dòng sinh viên
                    foreach (ListViewItem item in lstDanhSachSV.Items)
                    {
                        string dong =
                            item.Text.PadRight(10) +
                            item.SubItems[1].Text.PadRight(20) +
                            item.SubItems[2].Text.PadRight(20) +
                            item.SubItems[3].Text.PadRight(15) +
                            item.SubItems[4].Text.PadRight(10);

                        sw.WriteLine(dong);
                    }
                }

                MessageBox.Show("Đã lưu danh sách sinh viên vào file!", "Thông báo");
            }
        }
        ErrorProvider errorProvider = new ErrorProvider();  
        private void txtMaSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMaSV, "Mã sinh viên không được để trống.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMaSV, null);
            }
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtHoTen, "Họ và tên không được để trống.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtHoTen, null);
            }
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDC.Text))
            {
                errorProvider.SetError(txtDC, "Địa chỉ không được để trống.");
            }
            else
            {
                errorProvider.SetError(txtDC, null);
            }
        }

        private void cbLop_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbLop.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cbLop, "Lớp không được để trống.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cbLop, null);
            }
        }

        private void lstDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstDanhSachSV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lstDanhSachSV.SelectedItems[0];
                txtMaSV.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                txtDC.Text = item.SubItems[2].Text;
                DateTime NgaySinh;
                if (DateTime.TryParse(item.SubItems[3].Text, out NgaySinh))
                {
                    dtNgaySinh.Value = NgaySinh;
                }
               // dtNgaySinh.Text = item.SubItems[3].Text;
                cbLop.Text = item.SubItems[4].Text;
            }
        }
    }
}
