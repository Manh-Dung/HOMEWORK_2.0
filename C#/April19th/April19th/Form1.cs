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

namespace April19th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadComboLoaiSP()
        {
            dbDataContext data = new dbDataContext();
            var sp = from p in data.LoaiSPs
                      select p;
            cboLoaiSP.DataSource = sp;
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
        }

        public void LoadSanPham()
        {
            dbDataContext data = new dbDataContext();
            var sp = from p in data.SanPhams
                     select p;
            dgvSanPham.DataSource = sp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboLoaiSP();
            LoadSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            SanPham them = new SanPham();
            them.MaSP = txtMaSP.Text.Trim();
            them.TenSP = txtTenSP.Text;
            them.MaLoai = cboLoaiSP.SelectedValue.ToString();
            them.DonGia = Convert.ToInt32(txtDonGia.Text);
            data.SanPhams.InsertOnSubmit(them);
            data.SubmitChanges();
            LoadSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            var xoa = from sp in data.SanPhams
                      where sp.MaSP == txtMaSP.Text
                      select sp;
            foreach(var i in xoa)
            {
                data.SanPhams.DeleteOnSubmit(i);
                data.SubmitChanges();
            }
            LoadSanPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            var update = data.SanPhams.Single(sp => sp.MaSP == txtMaSP.Text);
            update.TenSP = txtTenSP.Text;
            update.MaLoai = cboLoaiSP.SelectedValue.ToString();
            update.DonGia = Convert.ToInt32(txtDonGia.Text);
            data.SubmitChanges();
            LoadSanPham();
        }

        private void dgvSanPham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[dong].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[dong].Cells[1].Value.ToString();
            cboLoaiSP.SelectedValue = dgvSanPham.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            var search = from s in data.SanPhams
                          where s.MaLoai == cboLoaiSP.SelectedValue
                          select s;
            dgvSanPham.DataSource = search;
        }
    }
}
