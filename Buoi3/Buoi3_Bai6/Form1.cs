using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            if(this.txtNhap.Text==" ")
            {
                MessageBox.Show("Vui lòng nhập vào tên trước khi thêm!", "Thông báo");this.txtNhap.Focus();
            }
            else
            {
                lstDanhSach.Items.Add(this.txtNhap.Text);
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem != null) {
                lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
                txtHienThi.Clear();
            }
            else
            {
                MessageBox.Show("Vui long nhap muc can xoa!", "Thong bao");
            }
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem != null)
            {
                txtHienThi.Text = lstDanhSach.SelectedItem.ToString();
            }
        }

        private void btnMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.ForeColor = cd.Color;
            }
        }

        private void btnMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                txtHienThi.BackColor = cd.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog cd = new FontDialog();
            if(cd.ShowDialog()==DialogResult.OK )
            {
                txtHienThi.Font = cd.Font;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.OKCancel
               , MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
