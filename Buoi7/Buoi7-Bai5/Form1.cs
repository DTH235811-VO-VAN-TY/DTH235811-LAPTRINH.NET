using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(pnlMauVien.BackColor, Convert.ToInt32(NumSize.Value));
            SolidBrush sb = new SolidBrush(pnlMauNen.BackColor);
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            if (cboChonHinh.Text == "Hinh Ellipse")
            {
                g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
                g.FillEllipse(sb, x1, y1, x2 - x1, y2 - y1);
            }
            if(cboChonHinh.Text == "Hinh Chu Nhat")
            {
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
                g.FillRectangle(sb, x1, y1, x2 - x1, y2 - y1);
            }
            if (cboChonHinh.Text == "Hinh Tron")
            {
                g.DrawEllipse(p, x1, y1, x2 - x1, x2 - x1);
                g.FillEllipse(sb, x1, y1, x2 - x1, x2 - x1);
            }
            if(cboChonHinh.Text == "Hinh Vuong")
            {
                int canh = Math.Min(x2 - x1, y2 - y1); 
                g.DrawRectangle(p, x1, y1, canh, canh);
                g.FillRectangle(sb, x1, y1, canh, canh);
            }
            if(cboChonHinh.Text == "Hinh Tam Giac")
            {
                Point[] points = { new Point((x1 + x2) / 2, y1), new Point(x1, y2), new Point(x2, y2) };
                g.DrawPolygon(p, points);
                g.FillPolygon(sb, points);
            }
        }
        int x1,x2,y1, y2;

        private void pnlMauVien_Click(object sender, EventArgs e)
        {
            if(colorDialog2.ShowDialog()==DialogResult.OK)
            {
                pnlMauVien.BackColor = colorDialog2.Color;
               
            }
        }

        private void pnlMauNen_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlMauNen.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
        }
    }
}
