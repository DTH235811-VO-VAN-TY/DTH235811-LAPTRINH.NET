using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if(this.txtHoten.Text == " ")
            {
                MessageBox.Show("Vui long nhap ho va ten!", "Thông báo");this.txtHoten.Focus();
            }
            else
            {
                string hoten = this.txtHoten.Text;
                if(this.rad1.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if(this.rad2.Checked == true) 
                {
                        this.txtKQ.Text = hoten.ToUpper();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoten.Clear();
            this.txtKQ.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",MessageBoxButtons.OKCancel
               ,MessageBoxIcon.Question);
            if(traloi ==DialogResult.OK)
                Application.Exit();
        }
    }
}
