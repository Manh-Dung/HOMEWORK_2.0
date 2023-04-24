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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        DTO_Service dto = new DTO_Service();
        BUS_Service bus = new BUS_Service();
        DTO_Destina dto_des = new DTO_Destina();
        private void Service_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from DiemDen";
            cboDiemDen.DataSource = da.GetTable(sql);
            cboDiemDen.DisplayMember = "TenDiemDen";
            cboDiemDen.ValueMember = "maDiemDen";
            dgv.DataSource = bus.ShowService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã dịch vụ không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên dịch vụ không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDichVu = txtMa.Text;
                    dto.TenDichVu = txtTen.Text;
                    dto.DiaChiDV = txtDiaChi.Text;
                    dto.DienThoaiDV = txtDienThoai.Text;
                    dto.EmailDV = txtEmail.Text;
                    dto.GhiChuDV = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.AddService(dto.MaDichVu, dto.TenDichVu, dto.DiaChiDV, dto.DienThoaiDV, dto.EmailDV, dto.GhiChuDV, dto_des.MaDiemDen);
                    MessageBox.Show("Đã thêm thành công!");
                    Service_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã dịch vụ không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên dịch vụ không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDichVu = txtMa.Text;
                    dto.TenDichVu = txtTen.Text;
                    dto.DiaChiDV = txtDiaChi.Text;
                    dto.DienThoaiDV = txtDienThoai.Text;
                    dto.EmailDV = txtEmail.Text;
                    dto.GhiChuDV = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.UpdateService(dto.MaDichVu, dto.TenDichVu, dto.DiaChiDV, dto.DienThoaiDV, dto.EmailDV, dto.GhiChuDV, dto_des.MaDiemDen);
                    MessageBox.Show("Đã sửa thành công!");
                    Service_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã dịch vụ để xóa!");
            else
            {
                dto.MaDichVu = txtMa.Text;
                bus.DelService(dto.MaDichVu);
            }
            MessageBox.Show("Đã xóa thành công!");
            Service_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMa.Text = dgv.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dgv.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dgv.Rows[dong].Cells[2].Value.ToString();
            txtDienThoai.Text = dgv.Rows[dong].Cells[3].Value.ToString();
            txtEmail.Text = dgv.Rows[dong].Cells[4].Value.ToString();
            txtGhiChu.Text = dgv.Rows[dong].Cells[5].Value.ToString();
            cboDiemDen.SelectedValue = dgv.Rows[dong].Cells[6].Value.ToString();
        }
    }
}
