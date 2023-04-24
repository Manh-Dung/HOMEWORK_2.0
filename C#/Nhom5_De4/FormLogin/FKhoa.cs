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
    public partial class FKhoa : Form
    {
        public FKhoa()
        {
            InitializeComponent();
        }
        LopDTO gv_DTO = new LopDTO();
        LopBUS gv_BUS = new LopBUS();
        private void FQuanLy_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = gv_BUS.ShowKhoa();
        }

        private void btnThemK_Click_1(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Mã khoa không được bỏ trống!");
            else if (txtTenKhoa.TextLength == 0)
                MessageBox.Show("Tên khoa không được bỏ trống!");
            else
            {
                try
                {
                    gv_DTO.MaKhoa = txtMaKhoa.Text;
                    gv_DTO.TenKhoa = txtTenKhoa.Text;
                    gv_BUS.ThemKhoa(gv_DTO.MaKhoa, gv_DTO.TenKhoa);
                    MessageBox.Show("Đã thêm thành công");
                    FQuanLy_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoaK_Click_1(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã khoa để xóa");
            else
            {
                gv_DTO.MaKhoa = txtMaKhoa.Text;
                gv_BUS.XoaKhoa(gv_DTO.MaKhoa);
            }
            MessageBox.Show("Đã xóa thành công");
            FQuanLy_Load(sender, e);
        }

        private void btnSuaK_Click_1(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Mã khoa không được bỏ trống!");
            else if (txtTenKhoa.TextLength == 0)
                MessageBox.Show("Tên khoa không được bỏ trống!");
            else
            {
                try
                {
                    gv_DTO.MaKhoa = txtMaKhoa.Text;
                    gv_DTO.TenKhoa = txtTenKhoa.Text;
                    gv_BUS.SuaKhoa(gv_DTO.MaKhoa, gv_DTO.TenKhoa);
                    MessageBox.Show("Đã sửa thành công");
                    FQuanLy_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTimK_Click_1(object sender, EventArgs e)
        {
            if (txtTimK.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvKhoa.DataSource = gv_BUS.TimKhoa(txtTimK.Text);
            }
        }

        private void btnRefreshK_Click_1(object sender, EventArgs e)
        {
            txtTimK.Clear();
            dgvKhoa.DataSource = gv_BUS.ShowKhoa();
        }

        private void dgvKhoa_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[dong].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
