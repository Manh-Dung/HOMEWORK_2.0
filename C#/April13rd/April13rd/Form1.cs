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

namespace April13rd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbDataContext db = new DbDataContext();

        private void btn1_Click(object sender, EventArgs e)
        {
            // Cach 1
            //var nv = from x in db.NhanViens
            //         select x;
            //dataGridView1.DataSource = nv;

            // Cach 2
            var nv = db.NhanViens
                .Select(x => x);
            dataGridView1.DataSource = nv;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Cach 1
            //var nv = from x in db.NhanViens
            //         select new { x.MaNV, x.HoTen, x.NgaySinh, x.HSLuong };
            //dataGridView1.DataSource = nv;

            // Cach 2
            var nv = db.NhanViens
                .Select(x => new { x.MaNV, x.HoTen, x.NgaySinh, x.HSLuong });
            dataGridView1.DataSource = nv;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Cach 1
            //var nv = (from x in db.NhanViens
            //          orderby x.HSLuong descending
            //          select new { x.MaNV, x.HoTen, x.NgaySinh, x.HSLuong }).Skip(0).Take(3);
            //dataGridView1.DataSource = nv;

            // Cach 2
            var nv = db.NhanViens
                .OrderByDescending(x => x.HSLuong)
                .Select(x => new { x.MaNV, x.HoTen, x.NgaySinh, x.HSLuong })
                .Skip(0).Take(3);
            dataGridView1.DataSource = nv;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            var nv = from x in db.NhanViens
                     join y in db.DonVis
                     on x.MaDV equals y.MaDV
                     select new { x.MaNV, x.HoTen, x.NgaySinh, x.GioiTinh, y.TenDV };
            dataGridView1.DataSource = nv;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            var nv = from x in db.NhanViens
                     join y in db.DonVis on x.MaDV equals y.MaDV 
                     join z in db.ChucVus on x.MaCV equals z.MaVC
                     select new { x.MaNV, x.HoTen, x.NgaySinh, x.HSLuong, y.TenDV, z.PhuCap};
            dataGridView1.DataSource = nv;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            var nv = from x in db.NhanViens
                     join z in db.ChucVus on x.MaCV equals z.MaVC
                     select new { x.MaNV, x.HoTen, x.NgaySinh, x.HSLuong, Luong = ((x.HSLuong * 830000) * (1 + z.PhuCap)) };
            dataGridView1.DataSource = nv;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            var nv = from x in db.NhanViens
                     join y in db.DonVis on x.MaDV equals y.MaDV
                     orderby x.HSLuong descending
                     where x.TrinhDo == "12"
                     select new { x.MaNV, x.HoTen, x.GioiTinh, x.HSLuong, x.TrinhDo, y.TenDV };
            dataGridView1.DataSource = nv;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            var nv = from x in db.NhanViens
                     join y in db.DonVis on x.MaDV equals y.MaDV
                     group x by x.MaDV into kq
                     select new { MaDV = kq.Key, SoNguoi = kq.Count() };
            dataGridView1.DataSource = nv;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //var nv = from x in db.NhanViens
            //         join y in db.DonVis on x.MaDV equals y.MaDV
            //         join z in db.ChucVus on x.MaCV equals z.MaVC
            //         group x by x.MaDV into kq
            //         select new { MaDV = kq.Key, TongLuong = kq.Sum(t => (t.HSLuong * 830000) * (1 + t.)) };
            //dataGridView1.DataSource = nv;
        }
    }
}
