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

namespace NguyenManhDung_20201356_De2
{
    public partial class Form1 : Form
    {
        List<VienChuc> ds = new List<VienChuc>();
        int row;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            VienChuc vc = new VienChuc();
            int ma = int.Parse(txtMaVC.Text);
            string ten = txtHoTen.Text;
            string chucVu = txtMaChucVu.Text;
            int bac = int.Parse(txtBacLuong.Text);
            vc.nhapThongTin(ma, ten, chucVu, bac);
            ds.Add(vc);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            listView1.Items.RemoveAt(row);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var i in ds)
            {
                row = listView1.Items.Count;
                listView1.Items.Add(i.maVienChuc.ToString());
                listView1.Items[row].SubItems.Add(i.hoTen);
                listView1.Items[row].SubItems.Add(i.maChucVu);
                listView1.Items[row].SubItems.Add(i.bacLuong.ToString());
                listView1.Items[row].SubItems.Add(i.tinhThuNhap().ToString());
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            row = e.ItemIndex;
            txtMaVC.Text = listView1.Items[row].SubItems[0].Text;
            txtHoTen.Text = listView1.Items[row].SubItems[1].Text;
            txtMaChucVu.Text = listView1.Items[row].SubItems[2].Text;
            txtBacLuong.Text = listView1.Items[row].SubItems[3].Text;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var i in ds)
            {
                if(i.maChucVu == txtMaChucVu.Text)
                {
                    row = listView1.Items.Count;
                    listView1.Items.Add(i.maVienChuc.ToString());
                    listView1.Items[row].SubItems.Add(i.hoTen);
                    listView1.Items[row].SubItems.Add(i.maChucVu);
                    listView1.Items[row].SubItems.Add(i.bacLuong.ToString());
                    listView1.Items[row].SubItems.Add(i.tinhThuNhap().ToString());
                }

            }
        }
    }

    class VienChuc
    {
        public int maVienChuc { get; set; }
        public string hoTen { get; set; }
        public string maChucVu { get; set; }
        public int bacLuong { get; set; }

        public void nhapThongTin(int a, string b, string c, int d)
        {
            maVienChuc = a;
            hoTen = b;
            maChucVu = c;
            bacLuong = d;
        }

        public double tinhThuNhap()
        {
            int x = 0;
            if(maChucVu == "GD")
            {
                x = bacLuong * 800000 + 500000;
            }

            else if(maChucVu == "TP")
            {
                x = bacLuong * 800000 + 300000;
            }
            else if(maChucVu == "NV")
            {
                x = bacLuong * 800000;
            }
            return x;
        }
    }
}
