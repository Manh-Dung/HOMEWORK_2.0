using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SV_BUS;
using SV_DAL;
using SV_DTO;

namespace SV_GUI
{
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }
        ClassSV_DTO sv_DTO = new ClassSV_DTO();
        ClassSV_BUS sv_BUS = new ClassSV_BUS();
        private void fSinhVien_Load(object sender, EventArgs e)
        {
            ClassSV_Data da = new ClassSV_Data();
            string sql = "select * from Lop";
            cboMaLop.DataSource = da.GetTable(sql);
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "TenLop";
            dgvSinhVien.DataSource = sv_BUS.ShowSV();
        }
        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            //if (dgvSinhVien.Rows[dong].Cells[1].Value == null)
            //{
            //    dgvSinhVien.Rows[dong].Cells[1].Value = DBNull.Value;
            //    txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            //}
            //else
            //{
            //    txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            //}
            txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString(); // Van duoc

            if (dgvSinhVien.Rows[dong].Cells[2].Value == null)
            {
                dgvSinhVien.Rows[dong].Cells[2].Value = DBNull.Value;
                txtHoten.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            }
            else
            {
                txtHoten.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            }

            if (dgvSinhVien.Rows[dong].Cells[3].Value == null)
            {
                dgvSinhVien.Rows[dong].Cells[3].Value = DBNull.Value;
                txtQueQuan.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            }
            else
            {
                txtQueQuan.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            }

            if (dgvSinhVien.Rows[dong].Cells[4].Value == null)
            {
                dgvSinhVien.Rows[dong].Cells[4].Value = DBNull.Value;
                cboMaLop.SelectedValue = dgvSinhVien.Rows[dong].Cells[4].Value.ToString();
            }
            else
            {
                cboMaLop.SelectedValue = dgvSinhVien.Rows[dong].Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống");
            else if (txtHoten.TextLength == 0)
                MessageBox.Show("Họ tên sinh viên không được bỏ trống");
            else if (txtQueQuan.TextLength == 0)
                MessageBox.Show("Quê quán không được bỏ trống");
            else if (cboMaLop.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Mã lớp không được bỏ trống");
            else
            {
                try
                {
                    sv_DTO.MaSV = txtMaSV.Text;
                    sv_DTO.HoTen = txtHoten.Text; 
                    sv_DTO.QueQuan = txtQueQuan.Text;
                    sv_DTO.MaLop = cboMaLop.SelectedValue.ToString();
                    sv_BUS.InsertSV(sv_DTO.MaSV, sv_DTO.HoTen, sv_DTO.QueQuan, sv_DTO.MaLop);
                    MessageBox.Show("Đã thêm thành công");
                    fSinhVien_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear(); 
            txtHoten.Clear(); 
            txtQueQuan.Clear(); 
            txtMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống");
            else if (txtHoten.TextLength == 0)
                MessageBox.Show("Họ tên sinh viên không được bỏ trống");
            else if (txtQueQuan.TextLength == 0)
                MessageBox.Show("Quê quán không được bỏ trống");
            else if (cboMaLop.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Mã lớp không được bỏ trống");
            else
            {
                try
                {
                    sv_DTO.MaSV = txtMaSV.Text;
                    sv_DTO.HoTen = txtHoten.Text;
                    sv_DTO.QueQuan = txtQueQuan.Text;
                    sv_DTO.MaLop = cboMaLop.SelectedValue.ToString();
                    sv_BUS.UpdateSV(sv_DTO.MaSV, sv_DTO.HoTen, sv_DTO.QueQuan, sv_DTO.MaLop);
                    MessageBox.Show("Đã sửa thành công");
                    fSinhVien_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã sinh viên để xóa ");
            else
            {
                sv_DTO.MaSV = txtMaSV.Text;
                sv_BUS.DeleteSV(sv_DTO.MaSV);
            } 
            MessageBox.Show("Đã xóa thành công");
            fSinhVien_Load(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvSinhVien.DataSource = sv_BUS.SearchSV(txtTimKiem.Text);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            fSinhVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void dgvSinhVien_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            {
                for (int i = 0; i < dgvSinhVien.RowCount; i++)
                    dgvSinhVien.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
