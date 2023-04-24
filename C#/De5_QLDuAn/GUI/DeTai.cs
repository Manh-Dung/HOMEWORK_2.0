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
    public partial class DeTai : Form
    {
        public DeTai()
        {
            InitializeComponent();
        }
        DTO_Class dto = new DTO_Class();
        BUS_Class bus = new BUS_Class();
        private void DeTai_Load(object sender, EventArgs e)
        {
            dgvDeTai.DataSource = bus.ShowDT();
        }
        private void btnThemK_Click(object sender, EventArgs e)
        {
            if (txtMaDT.TextLength == 0)
                MessageBox.Show("Mã đề tài không được bỏ trống!");
            else if (txtTenDT.TextLength == 0)
                MessageBox.Show("Tên đề tài không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDT = txtMaDT.Text;
                    dto.TenDT = txtTenDT.Text;
                    bus.AddDT(dto.MaDT, dto.TenDT);
                    MessageBox.Show("Đã thêm thành công");
                    DeTai_Load(sender, e);
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
            if (txtMaDT.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã đề tài để xóa");
            else
            {
                dto.MaDT = txtMaDT.Text;
                bus.DelDT(dto.MaDT);
            }
            MessageBox.Show("Đã xóa thành công");
            DeTai_Load(sender, e);
        }

        private void btnSuaK_Click(object sender, EventArgs e)
        {
            if (txtMaDT.TextLength == 0)
                MessageBox.Show("Mã đề tài không được bỏ trống!");
            else if (txtTenDT.TextLength == 0)
                MessageBox.Show("Tên đề tài không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDT = txtMaDT.Text;
                    dto.TenDT = txtTenDT.Text;
                    bus.UpdateDT(dto.MaDT, dto.TenDT);
                    MessageBox.Show("Đã sửa thành công");
                    DeTai_Load(sender, e);
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
            dgvDeTai.DataSource = bus.ShowDT();
        }

        private void btnTimK_Click(object sender, EventArgs e)
        {
            if (txtTimK.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvDeTai.DataSource = bus.SearchDT(txtTimK.Text);
            }
        }

        private void dgvDeTai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaDT.Text = dgvDeTai.Rows[dong].Cells[0].Value.ToString();
            txtTenDT.Text = dgvDeTai.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
