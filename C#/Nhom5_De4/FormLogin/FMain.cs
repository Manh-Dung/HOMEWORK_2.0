using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace FormLogin
{
    public partial class FMain : Form
    {
        public FMain()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
        }
        LopDTO gv_DTO = new LopDTO();
        LopBUS gv_BUS = new LopBUS();
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCreNewAccAd f = new FCreNewAccAd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChangePass f = new FChangePass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKhoa f = new FKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mônHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FMon f = new FMon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lớpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FLop f = new FLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void LoadCombo()
        {
            // ComboBox Khoa
            Data daK = new Data();
            string sqlK = "select * from Khoa";
            cboKhoa.DataSource = daK.GetTable(sqlK);
            cboKhoa.DisplayMember = "tenKhoa";
            cboKhoa.ValueMember = "maKhoa";

            // ComboBox Lop
            Data daL = new Data();
            string sqlL = "select * from Lop";
            cboLop.DataSource = daL.GetTable(sqlL);
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";

            // ComboBox MonHoc
            Data daM = new Data();
            string sqlM = "select * from MonHoc";
            cboMon.DataSource = daM.GetTable(sqlM);
            cboMon.DisplayMember = "tenMonHoc";
            cboMon.ValueMember = "maMonHoc";
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            LoadCombo();
            dgvGiangVien.DataSource = gv_BUS.ShowGV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else if (txtTenGV.TextLength == 0)
                MessageBox.Show("Tên giảng viên không được bỏ trống!");
            else if (txtNgaySinh.TextLength == 0)
                MessageBox.Show("Ngày sinh giảng viên không được bỏ trống!");
            else if (txtQueQuan.TextLength == 0)
                MessageBox.Show("Quê quán không được bỏ trống!");
            else if (txtSDT.TextLength == 0)
                MessageBox.Show("Số điện thoại không được bỏ trống!");
            else if (txtEmail.TextLength == 0)
                MessageBox.Show("Email giảng viên không được bỏ trống!");
            else if (cboKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Khoa không được bỏ trống");
            else if (cboLop.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Lớp không được bỏ trống");
            else if (cboMon.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Môn dạy không được bỏ trống");
            else
            {
                try
                {
                    gv_DTO.MaGV = txtMaGV.Text;
                    gv_DTO.TenGV = txtTenGV.Text;
                    gv_DTO.NgaySinhGiangVien = txtNgaySinh.Text;
                    gv_DTO.QueQuanGV = txtQueQuan.Text;
                    gv_DTO.Sdt = txtSDT.Text;
                    gv_DTO.Email = txtEmail.Text;
                    gv_DTO.MaKhoa = cboKhoa.SelectedValue.ToString();
                    gv_DTO.MaLop = cboLop.SelectedValue.ToString();
                    gv_DTO.MaMonHoc = cboMon.SelectedValue.ToString();
                    gv_BUS.ThemGV(gv_DTO.MaGV, gv_DTO.TenGV, gv_DTO.NgaySinhGiangVien, gv_DTO.QueQuanGV, gv_DTO.MaKhoa, gv_DTO.MaLop, gv_DTO.MaMonHoc, gv_DTO.Sdt, gv_DTO.Email);
                    MessageBox.Show("Đã thêm thành công");
                    FMain_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else if (txtTenGV.TextLength == 0)
                MessageBox.Show("Tên giảng viên không được bỏ trống!");
            else if (txtNgaySinh.TextLength == 0)
                MessageBox.Show("Ngày sinh giảng viên không được bỏ trống!");
            else if (txtQueQuan.TextLength == 0)
                MessageBox.Show("Quê quán không được bỏ trống!");
            else if (txtSDT.TextLength == 0)
                MessageBox.Show("Số điện thoại không được bỏ trống!");
            else if (txtEmail.TextLength == 0)
                MessageBox.Show("Email giảng viên không được bỏ trống!");
            else if (cboKhoa.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Khoa không được bỏ trống");
            else if (cboLop.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Lớp không được bỏ trống");
            else if (cboMon.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Môn dạy không được bỏ trống");
            else
            {
                try
                {
                    gv_DTO.MaGV = txtMaGV.Text;
                    gv_DTO.TenGV = txtTenGV.Text;
                    gv_DTO.NgaySinhGiangVien = txtNgaySinh.Text;
                    gv_DTO.QueQuanGV = txtQueQuan.Text;
                    gv_DTO.Sdt = txtSDT.Text;
                    gv_DTO.Email = txtEmail.Text;
                    gv_DTO.MaKhoa = cboKhoa.SelectedValue.ToString();
                    gv_DTO.MaLop = cboLop.SelectedValue.ToString();
                    gv_DTO.MaMonHoc = cboMon.SelectedValue.ToString();
                    gv_BUS.SuaGV(gv_DTO.MaGV, gv_DTO.TenGV, gv_DTO.NgaySinhGiangVien, gv_DTO.QueQuanGV, gv_DTO.MaKhoa, gv_DTO.MaLop, gv_DTO.MaMonHoc, gv_DTO.Sdt, gv_DTO.Email);
                    MessageBox.Show("Đã sửa thành công");
                    FMain_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã giảng viên để xóa");
            else
            {
                gv_DTO.MaGV = txtMaGV.Text;
                gv_BUS.XoaGV(gv_DTO.MaGV);
            }
            MessageBox.Show("Đã xóa thành công");
            FMain_Load(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            FMain_Load(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvGiangVien.DataSource = gv_BUS.TimGV(txtTim.Text);
                LoadCombo();
            }
        }

        private void dgvGiangVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaGV.Text = dgvGiangVien.Rows[dong].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGiangVien.Rows[dong].Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvGiangVien.Rows[dong].Cells[2].Value.ToString();
            txtQueQuan.Text = dgvGiangVien.Rows[dong].Cells[3].Value.ToString();
            txtSDT.Text = dgvGiangVien.Rows[dong].Cells[4].Value.ToString();
            txtEmail.Text = dgvGiangVien.Rows[dong].Cells[5].Value.ToString();
            cboKhoa.SelectedValue = dgvGiangVien.Rows[dong].Cells[6].Value.ToString();
            cboLop.SelectedValue = dgvGiangVien.Rows[dong].Cells[7].Value.ToString();
            cboMon.SelectedValue = dgvGiangVien.Rows[dong].Cells[8].Value.ToString();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "XLS (*.xls)|*.xls|" +
                "XLT (*.xlt)|*.xlt|" +
                "XLSX (*.xlsx)|*.xlsx|" +
                "XLSM (*.xlsm)|*.xlsm|" +
                "XLTX (*.xltx)|*.xltx|" +
                "XLTM (*.xltm)|*.xltm|" +
                "ODS (*.ods)|*.ods|" +
                "OTS (*.ots)|*.ots|" +
                "CSV (*.csv)|*.csv|" +
                "TSV (*.tsv)|*.tsv|" +
                "HTML (*.html)|*.html|" +
                "MHTML (.mhtml)|*.mhtml|" +
                "PDF (*.pdf)|*.pdf|" +
                "XPS (*.xps)|*.xps|" +
                "BMP (*.bmp)|*.bmp|" +
                "GIF (*.gif)|*.gif|" +
                "JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png|" +
                "TIFF (*.tif)|*.tif|" +
                "WMP (*.wdp)|*.wdp";

            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(
                    worksheet,
                    this.dgvGiangVien,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }

    }
}
