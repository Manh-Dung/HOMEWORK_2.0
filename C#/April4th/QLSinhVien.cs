using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace April4th
{
    public partial class QLSinhVien : Form
    {
        string strConnectionString = @"Data Source=MOTHER-FUCKER;Initial Catalog=QLSinhVien;Integrated Security=True";

        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public QLSinhVien()
        {
            InitializeComponent();
        }

        void loadData()
        {
            da = new SqlDataAdapter("select sv.MaSV, sv.HoTen, sv.QueQuan, l.MaLop, l.TenLop, l.SoSV " +
            "from SinhVien sv, Lop l where sv.MaLop = l.MaLop", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvSinhVien.DataSource = dt;
        }
        void loadCombo()
        {
            da = new SqlDataAdapter("select * from Lop", conn);
            dt = new DataTable();
            da.Fill(dt);
            comboTenLop.DataSource = dt;
            comboTenLop.DisplayMember = "TenLop";
            comboTenLop.ValueMember = "MaLop";
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            loadData();
            loadCombo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                String updateSQL = "Update Lop set SoSV = SoSV + 1 where TenLop = '" + comboTenLop.SelectedValue + "'";
                cmd = new SqlCommand(updateSQL, conn);
                cmd.ExecuteNonQuery();
                String sql = "Insert into SinhVien values ('" + txtMaSV.Text + "', '" + txtHoTen.Text
                + "', '" + txtQueQuan.Text + "', '" + comboTenLop.SelectedValue + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Không thể nhập trùng lặp mã sinh viên! Mời bạn nhập lại!");
                MessageBox.Show(ex.Message);
            }
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            if(dlr == DialogResult.OK)
            {
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                string sql = "Delete from SinhVien where MaSV = '" + txtMaSV.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                loadData();
                conn.Close();
            }     
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            string sql = "Update SinhVien set SinhVien.HoTen = '" + txtHoTen.Text + "', " + "SinhVien.QueQuan = '"
            + txtQueQuan.Text + "' " + "where MaSV = '" + txtMaSV.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
            conn.Close();
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dgvSinhVien.Rows[dong].Cells[0].Value == null)
            {
                dgvSinhVien.Rows[dong].Cells[0].Value = DBNull.Value;
                txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
            }
            else
            {
                txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
            }

            if (dgvSinhVien.Rows[dong].Cells[1].Value == null)
            {
                dgvSinhVien.Rows[dong].Cells[1].Value = DBNull.Value;
                txtHoTen.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            }
            else
            {
                txtHoTen.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            }

            if (dgvSinhVien.Rows[dong].Cells[2].Value == null)
            {
                dgvSinhVien.Rows[dong].Cells[2].Value = DBNull.Value;
                txtQueQuan.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            }
            else
            {
                txtQueQuan.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            }

            if (dgvSinhVien.Rows[dong].Cells[3].Value == null)
            {
                dgvSinhVien.Rows[dong].Cells[3].Value = DBNull.Value;
                comboTenLop.SelectedValue = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            }
            else
            {
                comboTenLop.SelectedValue = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            }
        }
    }
}
