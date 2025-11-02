using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            if (cbNhap.SelectedItem != null)
            {
                string hoten = cbNhap.SelectedItem.ToString();
                MessageBox.Show("Xin chào, " + hoten +" Chúc 1 ngày vui vẽ!"
                    
                   );
            }
        }
    }
}
