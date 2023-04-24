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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }
        DTO_Hotel dto = new DTO_Hotel();
        DTO_Destina dto_des = new DTO_Destina();
        BUS_Hotel bus = new BUS_Hotel();
        private void Hotel_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from DiemDen";
            cboDiemDen.DataSource = da.GetTable(sql);
            cboDiemDen.DisplayMember = "TenDiemDen";
            cboDiemDen.ValueMember = "maDiemDen";
            dgv.DataSource = bus.ShowHotel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã khách sạn không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên khách sạn không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaKhachSan = txtMa.Text;
                    dto.TenKhachSan = txtTen.Text;
                    dto.DiaChiKS = txtDiaChi.Text;
                    dto.DienThoaiKS = txtDienThoai.Text;
                    dto.EmailKS = txtEmail.Text;
                    dto.GhiChuKS = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.AddHotel(dto.MaKhachSan, dto.TenKhachSan, dto.DiaChiKS, dto.DienThoaiKS, dto.EmailKS, dto.GhiChuKS, dto_des.MaDiemDen);
                    MessageBox.Show("Đã thêm thành công!");
                    Hotel_Load(sender, e);
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
                MessageBox.Show("Bạn cần chọn mã khách sạn để xóa!");
            else
            {
                dto.MaKhachSan = txtMa.Text;
                bus.DelHotel(dto.MaKhachSan);
            }
            MessageBox.Show("Đã xóa thành công!");
            Hotel_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã khách sạn không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên khách sạn không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaKhachSan = txtMa.Text;
                    dto.TenKhachSan = txtTen.Text;
                    dto.DiaChiKS = txtDiaChi.Text;
                    dto.DienThoaiKS = txtDienThoai.Text;
                    dto.EmailKS = txtEmail.Text;
                    dto.GhiChuKS = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.UpdateHotel(dto.MaKhachSan, dto.TenKhachSan, dto.DiaChiKS, dto.DienThoaiKS, dto.EmailKS, dto.GhiChuKS, dto_des.MaDiemDen);
                    MessageBox.Show("Đã sửa thành công!");
                    Hotel_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
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
