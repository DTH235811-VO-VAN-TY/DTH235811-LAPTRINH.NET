using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool TryGetInputs(out double a, out double b)
        {
            a = 0; b = 0;
            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Vui lòng nhập cả hai số a và b.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool okA = double.TryParse(txtA.Text.Trim(), out a);
            bool okB = double.TryParse(txtB.Text.Trim(), out b);
            if (!okA || !okB)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void tổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double r = a - b;
                txtKQ.Text = r.ToString();
            }
        }

        private void tichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double r = a * b;
                txtKQ.Text = r.ToString();
            }
        }

        private void thuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double r = a / b;
                txtKQ.Text = r.ToString();
            }
        }

        private void tongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double r = a + b;
                txtKQ.Text = r.ToString();
            }
        }
    }
}
