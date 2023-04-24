using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        LopBUS loph = new LopBUS();
        LopDTO l = new LopDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgvLop.DataSource = loph.showLop();
            dgvLop.DataSource = loph.showLopBS();
        }

        private void dgvLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvLop.RowCount; i++)
            {
                dgvLop.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[2].Value.ToString();
            txtSoSV.Text = dgvLop.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0) MessageBox.Show("Mã lớp ko được bỏ trống!");
            else if (txtTenLop.TextLength == 0) MessageBox.Show("Tên lớp ko được bỏ trống!");
            else if (txtSoSV.TextLength == 0) MessageBox.Show("Số sinh viên ko được bỏ trống!");
            else
            {
                try
                {
                    l.MaLop = txtMaLop.Text;
                    l.TenLop = txtTenLop.Text;
                    l.SoSV = Int32.Parse(txtSoSV.Text);
                    loph.insertLop(l.MaLop, l.TenLop, l.SoSV);
                    MessageBox.Show("Đã thêm thành công!");
                    Form1_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!!"); }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSoSV.Clear();
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0) MessageBox.Show("Mã lớp ko được bỏ trống!");
            else if (txtTenLop.TextLength == 0) MessageBox.Show("Tên lớp ko được bỏ trống!");
            else if (txtSoSV.TextLength == 0) MessageBox.Show("Số sinh viên ko được bỏ trống!");
            else
            {
                try
                {
                    l.MaLop = txtMaLop.Text;
                    l.TenLop = txtTenLop.Text;
                    l.SoSV = Int32.Parse(txtSoSV.Text);
                    loph.updateLop(l.MaLop, l.TenLop, l.SoSV);
                    MessageBox.Show("Đã sửa thành công!!!");
                    Form1_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!!!!"); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0) MessageBox.Show("Bạn cần chọn mã lớp để xóa!");
            else
            {
                l.MaLop = txtMaLop.Text;
                loph.deleteLop(l.MaLop);
            }
            MessageBox.Show("Đã xóa thành công!!!");
            Form1_Load(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0) MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm! ");
            else
            {
                //dgvLop.DataSource = loph.timKiem(txtTimKiem.Text);
                dgvLop.DataSource = loph.timKiemBS(txtTimKiem.Text);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
