using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        List<NhanVien> ds = new List<NhanVien>();
        int row;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //txtHoTen.Clear();
            //txtMaNhanVien.Clear();
            //txtSoNgayLamViec.Clear();
            //txtTienLuongNgay.Clear();
            listView1.Items.RemoveAt(row);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            int ma = int.Parse(txtMaNhanVien.Text);
            string ten = txtHoTen.Text;
            double lNgay = double.Parse(txtTienLuongNgay.Text);
            int sNgay = int.Parse(txtSoNgayLamViec.Text);
            nv.nhapThongTin(ma, ten, lNgay, sNgay);
            ds.Add(nv);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var i in ds)
            {
                row = listView1.Items.Count;
                listView1.Items.Add(i.maNV.ToString());
                listView1.Items[row].SubItems.Add(i.hoTen);
                listView1.Items[row].SubItems.Add(i.luongNgay.ToString());
                listView1.Items[row].SubItems.Add(i.soNgay.ToString());
                listView1.Items[row].SubItems.Add(i.tinhLuong().ToString());
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            row = e.ItemIndex;
            txtMaNhanVien.Text = listView1.Items[row].SubItems[0].Text;
            txtHoTen.Text = listView1.Items[row].SubItems[1].Text;
            txtTienLuongNgay.Text = listView1.Items[row].SubItems[2].Text;
            txtSoNgayLamViec.Text = listView1.Items[row].SubItems[3].Text;
        }
    }

    class NhanVien
    {
        public int maNV { get; set; }
        public string hoTen { get; set; }
        public double luongNgay { get; set; }
        public int soNgay { get; set; }

        public void nhapThongTin(int MaNV, string HoTen, double LuongNgay, int SoNgay)
        {
            maNV = MaNV;
            hoTen = HoTen;
            luongNgay = LuongNgay;
            soNgay = SoNgay;
        }

        public double tinhLuong()
        {
            double x = 0;
            if(soNgay <= 24) 
            { 
                x = soNgay * luongNgay; 
            }
            else
            {
                x = (24 + (soNgay - 24) * 2) * luongNgay;
            }
            return x;
        }
    }
}
