using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;

namespace GUI
{
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        DTO_Class dto = new DTO_Class();
        BUS_Class bus = new BUS_Class();
        private void Lop_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from Khoa";
            cboTenKhoa.DataSource = da.GetTable(sql);
            cboTenKhoa.DisplayMember = "tenKhoa";
            cboTenKhoa.ValueMember = "maKhoa";

            string sql1 = "select * from GiangVien";
            cboGiangVien.DataSource = da.GetTable(sql1);
            cboGiangVien.DisplayMember = "tenGV";
            cboGiangVien.ValueMember = "maGV";
            dgvLop.DataSource = bus.ShowLop();
        }
        private void btnThemK_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Tên lớp không được bỏ trống!");
            else if (cboGiangVien.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Giảng viên không được bỏ trống!");
            else if (cboTenKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Tên khoa không được bỏ trống");
            else
            {
                try
                {
                    dto.MaLop = txtMaLop.Text;
                    dto.TenLop = txtTenLop.Text;
                    dto.MaKhoa = cboTenKhoa.SelectedValue.ToString();
                    dto.MaGV = cboGiangVien.SelectedValue.ToString();
                    bus.AddLop(dto.MaLop, dto.TenLop, dto.MaKhoa, dto.MaGV);
                    MessageBox.Show("Đã thêm thành công");
                    Lop_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnXoaK_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã lớp để xóa");
            else
            {
                dto.MaLop = txtMaLop.Text;
                bus.DelLop(dto.MaLop);
            }
            MessageBox.Show("Đã xóa thành công");
            Lop_Load(sender, e);
        }

        private void btnSuaK_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Tên lớp không được bỏ trống!");
            else if (cboTenKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Tên khoa không được bỏ trống");
            else if (cboGiangVien.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Giảng viên không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaLop = txtMaLop.Text;
                    dto.TenLop = txtTenLop.Text;
                    dto.MaKhoa = cboTenKhoa.SelectedValue.ToString();
                    dto.MaGV = cboGiangVien.SelectedValue.ToString();
                    bus.UpdateLop(dto.MaLop, dto.TenLop, dto.MaKhoa, dto.MaGV);
                    MessageBox.Show("Đã sửa thành công!");
                    Lop_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefreshK_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            Lop_Load(sender, e);
        }

        private void btnTimK_Click(object sender, EventArgs e)
        {
            if (txtTim.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvLop.DataSource = bus.SearchLop(txtTim.Text);
            }
        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaLop.Text = dgvLop.Rows[dong].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString();
            cboTenKhoa.SelectedValue = dgvLop.Rows[dong].Cells[2].Value.ToString();
            cboGiangVien.SelectedValue = dgvLop.Rows[dong].Cells[3].Value.ToString();
        }
    }
}
