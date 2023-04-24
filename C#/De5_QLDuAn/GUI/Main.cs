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
using DTO;
using DAL;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        DTO_Class dto = new DTO_Class();
        BUS_Class bus = new BUS_Class();
        private void themTK_Click(object sender, EventArgs e)
        {
            NewAccAd f = new NewAccAd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thayDoiMK_Click(object sender, EventArgs e)
        {
            ChangePass f = new ChangePass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Load_Combo()
        {
            Data da = new Data();
            string sql = "select * from Lop";
            cboLop.DataSource = da.GetTable(sql);
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";

            string sql1 = "select * from DeTai";
            cboDeTai.DataSource = da.GetTable(sql1);
            cboDeTai.DisplayMember = "tenDeTai";
            cboDeTai.ValueMember = "maDeTai";
        }
        public void Load_Data()
        {
            dgvSinhVien.DataSource = bus.ShowSV();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Load_Combo();
            Load_Data();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khoa f = new Khoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop f = new Lop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiangVien f = new GiangVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeTai f = new DeTai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemK_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống!");
            else if (txtTenSV.TextLength == 0)
                MessageBox.Show("Tên sinh viên không được bỏ trống!");
            else if (txtNgaySinh.TextLength == 0)
                MessageBox.Show("Ngày sinh sinh viên không được bỏ trống!");
            else if (txtSDT.TextLength == 0)
                MessageBox.Show("Số điện thoại không được bỏ trống!");
            else if (txtEmail.TextLength == 0)
                MessageBox.Show("Email giảng viên không được bỏ trống!");
            else if (txtQueQuan.TextLength == 0)
                MessageBox.Show("Quê quán không được bỏ trống!");
            else if (cboLop.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Lớp không được bỏ trống");
            else if (cboDeTai.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Đề tài không được bỏ trống");
            else
            {
                try
                {
                    dto.MaSV = txtMaSinhVien.Text;
                    dto.TenSV = txtTenSV.Text;
                    dto.NgaySinhSV = txtNgaySinh.Text;
                    dto.SdtSV = txtSDT.Text;
                    dto.EmailSV = txtEmail.Text;
                    dto.QueQuan = txtQueQuan.Text;
                    dto.MaLop = cboLop.SelectedValue.ToString();
                    dto.MaDT = cboDeTai.SelectedValue.ToString();
                    bus.AddSV(dto.MaSV, dto.TenSV, dto.NgaySinhSV, dto.SdtSV, dto.EmailSV, dto.QueQuan, dto.MaLop, dto.MaDT);
                    MessageBox.Show("Đã thêm thành công");
                    Main_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSuaK_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống!");
            else if (txtTenSV.TextLength == 0)
                MessageBox.Show("Tên sinh viên không được bỏ trống!");
            else if (txtNgaySinh.TextLength == 0)
                MessageBox.Show("Ngày sinh sinh viên không được bỏ trống!");
            else if (txtSDT.TextLength == 0)
                MessageBox.Show("Số điện thoại không được bỏ trống!");
            else if (txtEmail.TextLength == 0)
                MessageBox.Show("Email giảng viên không được bỏ trống!");
            else if (txtQueQuan.TextLength == 0)
                MessageBox.Show("Quê quán không được bỏ trống!");
            else if (cboLop.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Lớp không được bỏ trống");
            else if (cboDeTai.SelectedValue.ToString().Length == 0)
                MessageBox.Show("Đề tài không được bỏ trống");
            else
            {
                try
                {
                    dto.MaSV = txtMaSinhVien.Text;
                    dto.TenSV = txtTenSV.Text;
                    dto.NgaySinhSV = txtNgaySinh.Text;
                    dto.SdtSV = txtSDT.Text;
                    dto.EmailSV = txtEmail.Text;
                    dto.QueQuan = txtQueQuan.Text;
                    dto.MaLop = cboLop.SelectedValue.ToString();
                    dto.MaDT = cboDeTai.SelectedValue.ToString();
                    bus.UpdateSV(dto.MaSV, dto.TenSV, dto.NgaySinhSV, dto.SdtSV, dto.EmailSV, dto.QueQuan, dto.MaLop, dto.MaDT);
                    MessageBox.Show("Đã sửa thành công");
                    Main_Load(sender, e);
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
            if (txtMaSinhVien.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã sinh viên để xóa");
            else
            {
                dto.MaGV = txtMaSinhVien.Text;
                bus.DelSV(dto.MaSV);
            }
            MessageBox.Show("Đã xóa thành công");
            Main_Load(sender, e);
        }

        private void btnRefreshK_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            Main_Load(sender, e);
        }

        private void btnTimK_Click(object sender, EventArgs e)
        {
            if (txtTim.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvSinhVien.DataSource = bus.SearchSV(txtTim.Text);
                Load_Combo();
            }
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSinhVien.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
            txtTenSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            txtSDT.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            txtEmail.Text = dgvSinhVien.Rows[dong].Cells[4].Value.ToString();
            txtQueQuan.Text = dgvSinhVien.Rows[dong].Cells[5].Value.ToString();
            cboLop.SelectedValue = dgvSinhVien.Rows[dong].Cells[6].Value.ToString();
            cboDeTai.SelectedValue = dgvSinhVien.Rows[dong].Cells[7].Value.ToString();
            
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
                    this.dgvSinhVien,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }
    }
}
