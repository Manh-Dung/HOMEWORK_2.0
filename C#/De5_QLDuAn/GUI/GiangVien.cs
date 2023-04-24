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
    public partial class GiangVien : Form
    {
        public GiangVien()
        {
            InitializeComponent();
        }
        BUS_Class bus = new BUS_Class();
        DTO_Class dto = new DTO_Class();
        private void GiangVien_Load(object sender, EventArgs e)
        {
            dgvGV.DataSource = bus.ShowGV();
        }
        private void btnThemK_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else if (txtTenGV.TextLength == 0)
                MessageBox.Show("Tên giảng viên không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaGV = txtMaGV.Text;
                    dto.TenGV = txtTenGV.Text;
                    dto.EmailGV = txtEmailGV.Text;
                    dto.SdtGV = txtSDTGV.Text;
                    bus.AddGV(dto.MaGV, dto.TenGV, dto.SdtGV, dto.EmailGV);
                    MessageBox.Show("Đã thêm thành công");
                    GiangVien_Load(sender, e);
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
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã giảng viên để xóa");
            else
            {
                dto.MaGV = txtMaGV.Text;
                bus.DelGV(dto.MaGV);
            }
            MessageBox.Show("Đã xóa thành công");
            GiangVien_Load(sender, e);
        }

        private void btnSuaK_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else if (txtTenGV.TextLength == 0)
                MessageBox.Show("Tên giảng viên không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaGV = txtMaGV.Text;
                    dto.TenGV = txtTenGV.Text;
                    dto.EmailGV = txtEmailGV.Text;
                    dto.SdtGV = txtSDTGV.Text;
                    bus.UpdateGV(dto.MaGV, dto.TenGV, dto.SdtGV, dto.EmailGV);
                    MessageBox.Show("Đã sửa thành công");
                    GiangVien_Load(sender, e);
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
            GiangVien_Load(sender, e);
        }

        private void btnTimK_Click(object sender, EventArgs e)
        {
            if (txtTim.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvGV.DataSource = bus.SearchGV(txtTim.Text);
            }
        }

        private void dgvGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaGV.Text = dgvGV.Rows[dong].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGV.Rows[dong].Cells[1].Value.ToString();
            txtSDTGV.Text = dgvGV.Rows[dong].Cells[2].Value.ToString();
            txtEmailGV.Text = dgvGV.Rows[dong].Cells[3].Value.ToString();
        }
    }
}
