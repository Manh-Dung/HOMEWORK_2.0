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
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
        }
        DTO_Restaurant dto = new DTO_Restaurant();
        BUS_Restaurant bus = new BUS_Restaurant();
        DTO_Destina dto_des = new DTO_Destina();

        private void Restaurant_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from DiemDen";
            cboDiemDen.DataSource = da.GetTable(sql);
            cboDiemDen.DisplayMember = "TenDiemDen";
            cboDiemDen.ValueMember = "maDiemDen";
            dgv.DataSource = bus.ShowRestau();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã nhà hàng không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên nhà hàng không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaNhaHang = txtMa.Text;
                    dto.TenNhaHang = txtTen.Text;
                    dto.DiaChiNH = txtDiaChi.Text;
                    dto.DienThoaiNH = txtDienThoai.Text;
                    dto.EmailNH = txtEmail.Text;
                    dto.GhiChuNH = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.AddRestau(dto.MaNhaHang, dto.TenNhaHang, dto.DiaChiNH, dto.DienThoaiNH, dto.EmailNH, dto.GhiChuNH, dto_des.MaDiemDen);
                    MessageBox.Show("Đã thêm thành công!");
                    Restaurant_Load(sender, e);
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
                MessageBox.Show("Mã nhà hàng không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên nhà hàng không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaNhaHang = txtMa.Text;
                    dto.TenNhaHang = txtTen.Text;
                    dto.DiaChiNH = txtDiaChi.Text;
                    dto.DienThoaiNH = txtDienThoai.Text;
                    dto.EmailNH = txtEmail.Text;
                    dto.GhiChuNH = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.UpdateRestau(dto.MaNhaHang, dto.TenNhaHang, dto.DiaChiNH, dto.DienThoaiNH, dto.EmailNH, dto.GhiChuNH, dto_des.MaDiemDen);
                    MessageBox.Show("Đã sửa thành công!");
                    Restaurant_Load(sender, e);
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
                MessageBox.Show("Bạn cần chọn mã nhà hàng để xóa!");
            else
            {
                dto.MaNhaHang = txtMa.Text;
                bus.DelRestau(dto.MaNhaHang);
            }
            MessageBox.Show("Đã xóa thành công!");
            Restaurant_Load(sender, e);
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
