using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Bạn đã chon Website ";
            this.txtKQ.Text += this.listWeb.SelectedItem.ToString(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
        }
    }
}
