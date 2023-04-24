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
    public partial class Destina : Form
    {
        public Destina()
        {
            InitializeComponent();
        }
        DTO_Destina dto = new DTO_Destina();
        BUS_Destina bus = new BUS_Destina();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã điểm đến không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên điểm đến không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDiemDen = txtMa.Text;
                    dto.TenDiemDen = txtTen.Text;
                    dto.GhiChuDiemDen = txtGhiChu.Text;
                    bus.AddDestina(dto.MaDiemDen, dto.TenDiemDen, dto.GhiChuDiemDen);
                    MessageBox.Show("Đã thêm thành công!");
                    Destina_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Destina_Load(object sender, EventArgs e)
        {
            dgv.DataSource = bus.ShowDestina();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Mã điểm đến không được bỏ trống!");
            else if (txtTen.TextLength == 0)
                MessageBox.Show("Tên điểm đến không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaDiemDen = txtMa.Text;
                    dto.TenDiemDen = txtTen.Text;
                    dto.GhiChuDiemDen = txtGhiChu.Text;
                    bus.UpdateDestina(dto.MaDiemDen, dto.TenDiemDen, dto.GhiChuDiemDen);
                    MessageBox.Show("Đã sửa thành công!");
                    Destina_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMa.Text = dgv.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dgv.Rows[dong].Cells[1].Value.ToString();
            txtGhiChu.Text = dgv.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMa.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã điểm đến để xóa!");
            else
            {
                dto.MaDiemDen = txtMa.Text;
                bus.DelDestina(dto.MaDiemDen);
            }
            MessageBox.Show("Đã xóa thành công!");
            Destina_Load(sender, e);
        }
    }
}
