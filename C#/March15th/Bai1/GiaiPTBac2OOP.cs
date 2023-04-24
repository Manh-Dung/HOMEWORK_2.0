using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class GiaiPTBac2OOP : Form
    {
        public GiaiPTBac2OOP()
        {
            InitializeComponent();
        }
        public void Nhap(out double a, out double b, out double c)
        {
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);
        }
        private void btnGiaiPt_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            XuLy xl = new XuLy();
            Nhap(out a, out b, out c);
            txtNghiem.Text = xl.GiaiPt(a, b, c).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban co thuc su muon thoat ko?", "Thong bao!!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }
    }

    class XuLy
    {
        public string GiaiPt(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            string nghiem = "";

            if (a != 0)
            {
                if (delta < 0)
                {
                    nghiem = "Phuong trinh vo nghiem!";
                }
                else if (delta == 0)
                {
                    nghiem = "x1 = x2 = " + (-b / (2 * a)).ToString();
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    nghiem = "x1 = " + x1.ToString() + ".x2 = " + x2.ToString();
                }
            }
            if (a == 0)
            {
                if (b != 0)
                {
                    nghiem = "x = " + (-c / b).ToString();
                }
                else if (c == 0)
                {
                    nghiem = "Phuong trinh vo so nghiem!";
                }
                else
                    nghiem = "Phuong trinh vo nghiem!";
            }

            return (nghiem);
        }
    }


}
