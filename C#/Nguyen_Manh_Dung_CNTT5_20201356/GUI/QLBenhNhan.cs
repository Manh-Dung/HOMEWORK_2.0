using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Xml.Linq;
using BUS;
using DAL;
using DTO;

namespace GUI
{
    public partial class QLBenhNhan : Form
    {
        public QLBenhNhan()
        {
            InitializeComponent();
        }
        Lop_BUS bus = new Lop_BUS();
        Lop_DTO dto = new Lop_DTO();
        public void LoadComboMaKhoa()
        {
            dbDataContext data = new dbDataContext();
            var k = from p in data.KhoaKhams
                     select p;
            cboTenKhoa.DataSource = k;
            cboTenKhoa.DisplayMember = "tenKhoa";
            cboTenKhoa.ValueMember = "maKhoa";
        }
        public void LoadBenhNhan()
        {
            dbDataContext data = new dbDataContext();
            var bn = from p in data.BenhNhans
                     select p;
            dgvBenhNhan.DataSource = bn;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBenhNhan();
            LoadComboMaKhoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbDataContext data = new dbDataContext();
                BenhNhan them = new BenhNhan();
                them.maBN = txtMaBN.Text.Trim();
                them.hoTen = txtHoTen.Text;
                them.ngayNV = Convert.ToDateTime(txtNgayNV.Text);
                them.maKhoa = cboTenKhoa.SelectedValue.ToString();
                data.BenhNhans.InsertOnSubmit(them);
                data.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Không thể nhập trùng lặp mã bệnh nhân! Mời bạn nhập lại!");
                MessageBox.Show(ex.Message);
            }
            LoadBenhNhan();
        }
        //LINQ//
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBN.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã bệnh nhân để xóa! ");
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dlr == DialogResult.OK)
                {
                    dto.MaBN = txtMaBN.Text;
                    bus.DeleteBN(dto.MaBN);
                }      
            }
            MessageBox.Show("Đã xóa thành công");
            Form1_Load(sender, e);
        }
        //LINQ//
        private void btnTim_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            var search = from s in data.BenhNhans
                         where s.maBN == txtTimKiem.Text
                         select s;
            dgvBenhNhan.DataSource = search;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBenhNhan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaBN.Text = dgvBenhNhan.Rows[dong].Cells[0].Value.ToString();
            txtHoTen.Text = dgvBenhNhan.Rows[dong].Cells[1].Value.ToString();
            txtNgayNV.Text = dgvBenhNhan.Rows[dong].Cells[2].Value.ToString();
            cboTenKhoa.SelectedValue = dgvBenhNhan.Rows[dong].Cells[3].Value.ToString();
        }
    }
}
