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
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
        }
        DTO_SampleTour dto = new DTO_SampleTour();
        BUS_SampleTour bus = new BUS_SampleTour();
        private void addAcc_Click(object sender, EventArgs e)
        {
            AdNewAcc f = new AdNewAcc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            ChangePass f = new ChangePass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            dgvTourMau.DataSource = bus.ShowSample();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaTour.TextLength == 0)
                MessageBox.Show("Mã tour không được bỏ trống!");
            else if (txtTenTour.TextLength == 0)
                MessageBox.Show("Tên tour không được bỏ trống!");
            else if (txtKhoangCach.TextLength == 0)
                MessageBox.Show("Khoảng cách không được bỏ trống!");
            else if (txtChiPhi.TextLength == 0)
                MessageBox.Show("Chi phí không được bỏ trống!");
            else if (txtHanhTrinh.TextLength == 0)
                MessageBox.Show("Hành trình không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaTourMau = txtMaTour.Text;
                    dto.TenTour = txtTenTour.Text;
                    dto.HanhTrinh = txtHanhTrinh.Text;
                    dto.KhoangCach = float.Parse(txtKhoangCach.Text);
                    dto.ChiPhi = float.Parse(txtChiPhi.Text);
                    bus.AddSample(dto.MaTourMau, dto.TenTour, dto.HanhTrinh, dto.KhoangCach, dto.ChiPhi);
                    MessageBox.Show("Đã thêm thành công!");
                    Main_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtMaTour.TextLength == 0)
                MessageBox.Show("Bạn cần chọn tour để xóa!?");
            else
            {
                dto.MaTourMau = txtMaTour.Text;
                bus.DelSample(dto.MaTourMau);
            }
            MessageBox.Show("Đã xóa thành công!");
            Main_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaTour.TextLength == 0)
                MessageBox.Show("Mã tour không được bỏ trống!");
            else if (txtTenTour.TextLength == 0)
                MessageBox.Show("Tên tour không được bỏ trống!");
            else if (txtKhoangCach.TextLength == 0)
                MessageBox.Show("Khoảng cách không được bỏ trống!");
            else if (txtChiPhi.TextLength == 0)
                MessageBox.Show("Chi phí không được bỏ trống!");
            else if (txtHanhTrinh.TextLength == 0)
                MessageBox.Show("Hành trình không được bỏ trống!");
            else
            {
                try
                {
                    dto.MaTourMau = txtMaTour.Text;
                    dto.TenTour = txtTenTour.Text;
                    dto.HanhTrinh = txtHanhTrinh.Text;
                    dto.KhoangCach = float.Parse(txtKhoangCach.Text);
                    dto.ChiPhi = float.Parse(txtChiPhi.Text);
                    bus.UpdateSample(dto.MaTourMau, dto.TenTour, dto.HanhTrinh, dto.KhoangCach, dto.ChiPhi);
                    MessageBox.Show("Đã sửa thành công!");
                    Main_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            Main_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvTourMau.DataSource = bus.SearchSample(txtSearch.Text);
            }
        }

        private void dgvTourMau_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaTour.Text = dgvTourMau.Rows[dong].Cells[0].Value.ToString();
            txtTenTour.Text = dgvTourMau.Rows[dong].Cells[1].Value.ToString();
            txtHanhTrinh.Text = dgvTourMau.Rows[dong].Cells[2].Value.ToString();
            txtKhoangCach.Text = dgvTourMau.Rows[dong].Cells[3].Value.ToString();
            txtChiPhi.Text = dgvTourMau.Rows[dong].Cells[4].Value.ToString();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locate f = new Locate();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
                    this.dgvTourMau,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }
    }
}
