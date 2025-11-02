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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.cmbWeb.Items.Add("Tuổi trẻ");
            this.cmbWeb.Items.Add("Thanh niên");
            this.cmbWeb.Items.Add("VNExpress");
            this.cmbWeb.Items.Add("Dân trí");
            this.cmbWeb.Items.Add("Công an");
            this.cmbWeb.Items.Add("24h");
            this.cmbWeb.Items.Add("Zingme");
            this.cmbWeb.Items.Add("Kênh 14");
            this.cmbWeb.Items.Add("Sài Gòn Tiếp Thị");
            this.cmbWeb.SelectedItem = "VNExpress";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Ban chon Web ";
            this.txtKQ.Text += this.cmbWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cmbWeb.SelectedItem = "VNExpress";this.txtKQ.Clear();
        }
    }
}
