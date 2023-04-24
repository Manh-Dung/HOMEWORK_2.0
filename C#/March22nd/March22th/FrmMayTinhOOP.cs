using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace March22th
{
    public partial class frmMayTinhOOP : Form
    {
        public frmMayTinhOOP()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes) this.Close();
        }

        public void Nhap(out float a, out float b)
        {
            a = float.Parse(txtA.Text);
            b = float.Parse(txtB.Text);
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;

            xuLy xl = new xuLy();
            Nhap(out a, out b);
            txtKetQua.Text = xl.cong(a, b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;

            xuLy xl = new xuLy();
            Nhap(out a, out b);
            txtKetQua.Text = xl.tru(a, b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;

            xuLy xl = new xuLy();
            Nhap(out a, out b);
            txtKetQua.Text = xl.nhan(a, b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;

            xuLy xl = new xuLy();
            Nhap(out a, out b);

            if (b == 0)
            {
                DialogResult dlr = MessageBox.Show("Bạn phải nhập giá trị khác 0 cho b", "Cảnh báo!", MessageBoxButtons.OK);
                if (dlr != DialogResult.OK) this.Close();
            }
            txtKetQua.Text = xl.chia(a, b).ToString();
        }
    }

    class xuLy
    {
        public float cong(float a, float b)
        {
            return a + b;
        }

        public float tru(float a, float b)
        {
            return a - b;
        }

        public float nhan(float a, float b)
        {
            return a * b;
        }

        public float chia(float a, float b)
        {
            return a / b;
        }
    }
}
