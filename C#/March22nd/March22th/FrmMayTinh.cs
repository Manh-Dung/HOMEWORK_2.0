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
    public partial class frmMayTinh : Form
    {
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes) this.Close();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float ketQua = a + b;
            txtKetQua.Text = ketQua.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float ketQua = a - b;
            txtKetQua.Text = ketQua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float ketQua = a * b;
            txtKetQua.Text = ketQua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);

            if(b == 0)
            {
                DialogResult dlr = MessageBox.Show("Bạn phải nhập giá trị khác 0 cho b", "Cảnh báo!", MessageBoxButtons.OK);
                if(dlr != DialogResult.OK) this.Close();
            }
            float ketQua = a / b;
            txtKetQua.Text = ketQua.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
        }
    }
}
