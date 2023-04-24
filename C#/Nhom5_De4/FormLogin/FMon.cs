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
    public partial class FMon : Form
    {
        public FMon()
        {
            InitializeComponent();
        }
        LopDTO gv_DTO = new LopDTO();
        LopBUS gv_BUS = new LopBUS();

        private void FMon_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from Khoa";
            cboTenKhoa.DataSource = da.GetTable(sql);
            cboTenKhoa.DisplayMember = "tenKhoa";
            cboTenKhoa.ValueMember = "maKhoa";
            dgvMon.DataSource = gv_BUS.ShowMon();
        }
        private void btnThemM_Click(object sender, EventArgs e)
        {
            if (txtMaMH.TextLength == 0)
                MessageBox.Show("Mã môn học không được bỏ trống!");
            else if (txtTenMH.TextLength == 0)
                MessageBox.Show("Tên môn học không được bỏ trống!");
            else if (cboTenKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Tên khoa không được bỏ trống");
            else
            {
                try
                {
                    gv_DTO.MaMonHoc = txtMaMH.Text;
                    gv_DTO.TenMonHoc = txtTenMH.Text;
                    gv_DTO.MaKhoa = cboTenKhoa.SelectedValue.ToString();
                    gv_BUS.ThemMon(gv_DTO.MaMonHoc, gv_DTO.TenMonHoc, gv_DTO.MaKhoa);
                    MessageBox.Show("Đã thêm thành công");
                    FMon_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoaM_Click(object sender, EventArgs e)
        {
            if (txtMaMH.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã môn học để xóa");
            else
            {
                gv_DTO.MaMonHoc = txtMaMH.Text;
                gv_BUS.XoaMon(gv_DTO.MaMonHoc);
            }
            MessageBox.Show("Đã xóa thành công");
            FMon_Load(sender, e);
        }

        private void btnSuaM_Click(object sender, EventArgs e)
        {
            if (txtMaMH.TextLength == 0)
                MessageBox.Show("Mã môn học không được bỏ trống!");
            else if (txtTenMH.TextLength == 0)
                MessageBox.Show("Tên môn học không được bỏ trống!");
            else if (cboTenKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Tên khoa không được bỏ trống");
            else
            {
                try
                {
                    gv_DTO.MaMonHoc = txtMaMH.Text;
                    gv_DTO.TenMonHoc = txtTenMH.Text;
                    gv_DTO.MaKhoa = cboTenKhoa.SelectedValue.ToString();
                    gv_BUS.SuaMon(gv_DTO.MaMonHoc, gv_DTO.TenMonHoc, gv_DTO.MaKhoa);
                    MessageBox.Show("Đã sửa thành công");
                    FMon_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefreshM_Click(object sender, EventArgs e)
        {
            txtTimM.Clear();
            FMon_Load(sender, e);
        }

        private void btnTimM_Click(object sender, EventArgs e)
        {
            if (txtTimM.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvMon.DataSource = gv_BUS.TimMon(txtTimM.Text);
            }
        }

        private void dgvMon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaMH.Text = dgvMon.Rows[dong].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMon.Rows[dong].Cells[1].Value.ToString();
            cboTenKhoa.SelectedValue = dgvMon.Rows[dong].Cells[2].Value.ToString();
        }
    }
}
