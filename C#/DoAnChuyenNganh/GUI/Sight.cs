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
    public partial class Sight : Form
    {
        public Sight()
        {
            InitializeComponent();
        }
        DTO_Sight dto = new DTO_Sight();
        DTO.DTO_Destina dto_des = new DTO_Destina();
        BUS_Sight bus = new BUS_Sight();
        private void Sight_Load(object sender, EventArgs e)
        {
            Data da = new Data();
            string sql = "select * from DiemDen";
            cboDiemDen.DataSource = da.GetTable(sql);
            cboDiemDen.DisplayMember = "TenDiemDen";
            cboDiemDen.ValueMember = "maDiemDen";
            dgv.DataSource = bus.ShowSight();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã điểm tham quan không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên điểm tham quan không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDiemThamQuan = txtMa.Text;
                    dto.TenDiemThamQuan = txtTen.Text;
                    dto.GhiChuDTQ = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.AddSight(dto.MaDiemThamQuan, dto.TenDiemThamQuan, dto.GhiChuDTQ, dto_des.MaDiemDen);
                    MessageBox.Show("Đã thêm thành công!");
                    Sight_Load(sender, e);
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
                MessageBox.Show("Bạn cần chọn mã điểm tham quan để xóa!");
            else
            {
                dto.MaDiemThamQuan = txtMa.Text;
                bus.DelSight(dto.MaDiemThamQuan);
            }
            MessageBox.Show("Đã xóa thành công!");
            Sight_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã điểm tham quan không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên điểm tham quan không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDiemThamQuan = txtMa.Text;
                    dto.TenDiemThamQuan = txtTen.Text;
                    dto.GhiChuDTQ = txtGhiChu.Text;
                    dto_des.MaDiemDen = cboDiemDen.SelectedValue.ToString();
                    bus.UpdateSight(dto.MaDiemThamQuan, dto.TenDiemThamQuan, dto.GhiChuDTQ, dto_des.MaDiemDen);
                    MessageBox.Show("Đã sửa thành công!");
                    Sight_Load(sender, e);
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
            txtGhiChu.Text = dgv.Rows[dong].Cells[2].Value.ToString();
            cboDiemDen.SelectedValue = dgv.Rows[dong].Cells[3].Value.ToString();
        }
    }
}
