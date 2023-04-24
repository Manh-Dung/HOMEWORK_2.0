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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }
        DTO_Class dto = new DTO_Class();
        BUS_Class bus = new BUS_Class();

        private void Khoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = bus.ShowKhoa();
        }

        private void btnThemK_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Mã khoa không được bỏ trống!");
            else if (txtTenKhoa.TextLength == 0)
                MessageBox.Show("Tên khoa không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaKhoa = txtMaKhoa.Text;
                    dto.TenKhoa = txtTenKhoa.Text;
                    bus.AddKhoa(dto.MaKhoa, dto.TenKhoa);
                    MessageBox.Show("Đã thêm thành công");
                    Khoa_Load(sender, e);
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
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã khoa để xóa");
            else
            {
                dto.MaKhoa = txtMaKhoa.Text;
                bus.DelKhoa(dto.MaKhoa);
            }
            MessageBox.Show("Đã xóa thành công");
            Khoa_Load(sender, e);
        }

        private void btnSuaK_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
                MessageBox.Show("Mã khoa không được bỏ trống!");
            else if (txtTenKhoa.TextLength == 0)
                MessageBox.Show("Tên khoa không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaKhoa = txtMaKhoa.Text;
                    dto.TenKhoa = txtTenKhoa.Text;
                    bus.UpdateKhoa(dto.MaKhoa, dto.TenKhoa);
                    MessageBox.Show("Đã sửa thành công");
                    Khoa_Load(sender, e);
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
            txtTimK.Clear();
            dgvKhoa.DataSource = bus.ShowKhoa();
        }

        private void btnTimK_Click(object sender, EventArgs e)
        {
            if (txtTimK.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvKhoa.DataSource = bus.SearchKhoa(txtTimK.Text);
            }
        }

        private void dgvKhoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[dong].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
