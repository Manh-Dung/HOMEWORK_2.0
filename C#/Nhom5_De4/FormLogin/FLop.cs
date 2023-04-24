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

namespace FormLogin
{
    public partial class FLop : Form
    {
        public FLop()
        {
            InitializeComponent();
        }
        LopDTO gv_DTO = new LopDTO();
        LopBUS gv_BUS = new LopBUS();
        private void FLop_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from Khoa";
            cboTenKhoa.DataSource = da.GetTable(sql);
            cboTenKhoa.DisplayMember = "tenKhoa";
            cboTenKhoa.ValueMember = "maKhoa";
            dgvLop.DataSource = gv_BUS.ShowLop();
        }

        private void btnThemL_Click_1(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Tên lớp không được bỏ trống!");
            else if (txtSiSo.TextLength == 0)
                MessageBox.Show("Sĩ số lớp không được bỏ trống!");
            else if (cboTenKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Tên khoa không được bỏ trống");
            else
            {
                try
                {
                    gv_DTO.MaLop = txtMaLop.Text;
                    gv_DTO.TenLop = txtTenLop.Text;
                    gv_DTO.SiSo = txtSiSo.Text;
                    gv_DTO.MaKhoa = cboTenKhoa.SelectedValue.ToString();
                    gv_BUS.ThemLop(gv_DTO.MaLop, gv_DTO.TenLop, gv_DTO.SiSo, gv_DTO.MaKhoa);
                    MessageBox.Show("Đã thêm thành công");
                    FLop_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoaL_Click_1(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã lớp để xóa");
            else
            {
                gv_DTO.MaLop = txtMaLop.Text;
                gv_BUS.XoaLop(gv_DTO.MaLop);
            }
            MessageBox.Show("Đã xóa thành công");
            FLop_Load(sender, e);
        }

        private void btnSuaL_Click_1(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Tên lớp không được bỏ trống!");
            else if (txtSiSo.TextLength == 0)
                MessageBox.Show("Sĩ số lớp không được bỏ trống!");
            else if (cboTenKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Mã khoa không được bỏ trống");
            else
            {
                try
                {
                    gv_DTO.MaLop = txtMaLop.Text;
                    gv_DTO.TenLop = txtTenLop.Text;
                    gv_DTO.SiSo = txtSiSo.Text;
                    gv_DTO.MaKhoa = cboTenKhoa.SelectedValue.ToString();
                    gv_BUS.SuaLop(gv_DTO.MaLop, gv_DTO.TenLop, gv_DTO.SiSo, gv_DTO.MaKhoa);
                    MessageBox.Show("Đã sửa thành công");
                    FLop_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefreshL_Click_1(object sender, EventArgs e)
        {
            txtTimL.Clear();
            FLop_Load(sender, e);
        }

        private void btnTimL_Click_1(object sender, EventArgs e)
        {
            if (txtTimL.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvLop.DataSource = gv_BUS.TimLop(txtTimL.Text);
            }
        }

        private void dgvLop_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaLop.Text = dgvLop.Rows[dong].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString();
            txtSiSo.Text = dgvLop.Rows[dong].Cells[2].Value.ToString();
            cboTenKhoa.SelectedValue = dgvLop.Rows[dong].Cells[3].Value.ToString();
        }
    }
}
