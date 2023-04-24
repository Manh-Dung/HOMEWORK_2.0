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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        DTO_Shop dto = new DTO_Shop();
        BUS_Shop bus = new BUS_Shop();
        DTO_Destina dto_des = new DTO_Destina();
        private void Shop_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from DiemDen";
            cboDiemDen.DataSource = da.GetTable(sql);
            cboDiemDen.DisplayMember = "TenDiemDen";
            cboDiemDen.ValueMember = "maDiemDen";
            dgv.DataSource = bus.ShowShop();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã mua sắm không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên mua sắm không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaMuaSam = txtMa.Text;
                    dto.TenMuaSam = txtTen.Text;
                    dto.DiaChiMS = txtDiaChi.Text;
                    dto.DienThoaiMS = txtDienThoai.Text;
                    dto.EmailMS = txtEmail.Text;
                    dto.GhiChuMS = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.AddShop(dto.MaMuaSam, dto.TenMuaSam, dto.DiaChiMS, dto.DienThoaiMS, dto.EmailMS, dto.GhiChuMS, dto_des.MaDiemDen);
                    MessageBox.Show("Đã thêm thành công!");
                    Shop_Load(sender, e);
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
                MessageBox.Show("Mã mua sắm không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên mua sắm không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaMuaSam = txtMa.Text;
                    dto.TenMuaSam = txtTen.Text;
                    dto.DiaChiMS = txtDiaChi.Text;
                    dto.DienThoaiMS = txtDienThoai.Text;
                    dto.EmailMS = txtEmail.Text;
                    dto.GhiChuMS = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.UpdateShop(dto.MaMuaSam, dto.TenMuaSam, dto.DiaChiMS, dto.DienThoaiMS, dto.EmailMS, dto.GhiChuMS, dto_des.MaDiemDen);
                    MessageBox.Show("Đã sửa thành công!");
                    Shop_Load(sender, e);
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
                MessageBox.Show("Bạn cần chọn mã mua sắm để xóa!");
            else
            {
                dto.MaMuaSam = txtMa.Text;
                bus.DelShop(dto.MaMuaSam);
            }
            MessageBox.Show("Đã xóa thành công!");
            Shop_Load(sender, e);
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
