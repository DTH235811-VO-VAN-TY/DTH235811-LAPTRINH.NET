using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Label> DsGhe = new List<Label>();
        private List<int> GheDaChon = new List<int>();
        private int GiaVe = 100000;

        private void Form1_Load(object sender, EventArgs e)
        {
            int soLuongGhe = 30;
            int soCot = 9; // Ví dụ chia thành 6 cột
            int labelWidth = 50;
            int labelHeight = 50;
            int margin = 10;

            for (int i = 0; i < soLuongGhe; i++)
            {
                Label lbl = new Label();
                lbl.Text = (i + 1).ToString();
                lbl.Size = new Size(labelWidth, labelHeight);
                lbl.BackColor = Color.White;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.ForeColor = Color.Red;
                lbl.TextAlign = ContentAlignment.TopLeft;

                // Tính vị trí theo hàng và cột
                int row = i / soCot;
                int col = i % soCot;
                lbl.Location = new Point(margin + col * (labelWidth + margin), margin + row * (labelHeight + margin));

                lbl.Click += LblGhe_Click;
                DsGhe.Add(lbl);
                this.Controls.Add(lbl); // Thêm vào Form
            }

        }
        private void ThanhTien()
        {
            int soGheDangChon = DsGhe.Count(ghe => ghe.BackColor == Color.Blue);
            Label lblThanhTien = this.Controls["lblThanhTien"] as Label;
            if (lblThanhTien.Text!=null)
            {
                lblThanhTien.Text = "Thành tiền: " + (soGheDangChon * GiaVe).ToString("N0") + " VND";
            }

        }

        private void LblGhe_Click(object sender, EventArgs e)
        {
           Label ghe = sender as Label;
            if(ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
                GheDaChon.Add(int.Parse(ghe.Text));
            }
            else if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được đặt. Vui lòng chọn ghế khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
                GheDaChon.Remove(int.Parse(ghe.Text));
            }

            ThanhTien();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GheDaChon.Count; i++)
            {
                int soGhe = GheDaChon[i];
                Label ghe = DsGhe[soGhe - 1];
                ghe.BackColor = Color.Yellow;
            }
            ThanhTien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < GheDaChon.Count; i++)
            {
                int soGhe = GheDaChon[i];
                Label ghe = DsGhe[soGhe - 1];
                ghe.BackColor = Color.White;
            }
            lblThanhTien.Text = "Thành tiền: 0 VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
