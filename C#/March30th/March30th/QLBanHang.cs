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

namespace March30th
{
    public partial class QLBanHang : Form
    {
        string strConnectionString = @"Data Source=MOTHER-FUCKER;Initial Catalog=QLBanHang;Integrated Security=True";
        // Data Source=MOTHER-FUCKER;Initial Catalog=QLBanHang;Integrated Security=True

        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public QLBanHang()
        {
            InitializeComponent();
        }
        void loadData()
        {
            da = new SqlDataAdapter("select * from SanPham", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void loadCombo()
        {
            da = new SqlDataAdapter("select * from LoaiSP", conn);
            dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenLoai";
            comboBox1.ValueMember = "MaLoai";
        }
        private void QLBanHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            loadCombo();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                String sql = "Insert into SanPham values ('" + txtMaSP.Text + "', '" + txtTenSP.Text
                + "', '" + comboBox1.SelectedValue + "', '" + txtDonGia.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error!");
                MessageBox.Show(ex.Message);
            }
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            string sql = "Delete from SanPham where MaSP = '" + txtMaSP.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            string sql = "Update SanPham set TenSP = '" + txtTenSP.Text + "', " + "MaLoai = '"
            + comboBox1.SelectedValue + "', " + "DonGia = '" + txtDonGia.Text + "'" + "where MaSP = '" + txtMaSP.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "Select * from SanPham where MaLoai = '" + comboBox1.SelectedValue + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dataGridView1.Rows[dong].Cells[0].Value == null)
            {
                dataGridView1.Rows[dong].Cells[0].Value = DBNull.Value;
                txtMaSP.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            }
            else
            {
                txtMaSP.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            }

            if (dataGridView1.Rows[dong].Cells[1].Value == null)
            {
                dataGridView1.Rows[dong].Cells[1].Value = DBNull.Value;
                txtTenSP.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            }
            else
            {
                txtTenSP.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            }

            if (dataGridView1.Rows[dong].Cells[2].Value == null)
            {
                dataGridView1.Rows[dong].Cells[2].Value = DBNull.Value;
                comboBox1.SelectedValue = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            }
            else
            {
                comboBox1.SelectedValue = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            }

            if (dataGridView1.Rows[dong].Cells[3].Value == null)
            {
                dataGridView1.Rows[dong].Cells[3].Value = DBNull.Value;
                txtDonGia.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            }
            else
            {
                txtDonGia.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            }
        }
    }
}
