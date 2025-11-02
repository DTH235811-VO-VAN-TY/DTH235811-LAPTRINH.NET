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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.listWeb.Items.Add("Tuổi trẻ");
            this.listWeb.Items.Add("Thanh niên");
            this.listWeb.Items.Add("VNExpress");
            this.listWeb.Items.Add("Dân trí");
            this.listWeb.Items.Add("Công an");
            this.listWeb.SelectedItem = "Tuổi trẻ";
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
