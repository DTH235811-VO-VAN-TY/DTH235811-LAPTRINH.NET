using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienTT_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (this.rdNam.Checked == true)
                gt = "Nam";
            if (this.rdNu.Checked == true)
                gt = "Nu";
            string tt = "";
            if(this.chbHoc.Checked==true)
                tt = chbHoc.Text;
            if(this.chBLam.Checked==true)
                tt = chBLam.Text;
            MessageBox.Show("Ho Ten: " + txtHoTen.Text + "\n" + "Gioi tinh: " + gt+
                "\n"+"Ngay Sinh: "+txtNgaySinh.Text+"\n"+
                "Dia chi: "+txtDiaChi.Text+"\n"+
                "Dien thoai: "+txtDt.Text+"\n"+
                "Email: "+txtEmail.Text+"\n"+
                "Tinh Trang: "+tt);
        }
    }
}
