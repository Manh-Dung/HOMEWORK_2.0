using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class LopBUS
    {
        Data da = new Data();
        LopDTO L = new LopDTO();

        // Table Giang vien
        public DataTable ShowGV()
        {
            string sql = "select gv.maGV, gv.tenGV, gv.ngaySinhGV, gv.queQuanGV, gv.sdt, gv.email, k.maKhoa, l.maLop, mh.maMonHoc" + " from (((GiangVien gv inner join Khoa k on gv.maKhoa = k.maKhoa) inner join Lop l on gv.maLop = l.MaLop) inner join MonHoc mh on gv.maMonHoc = mh.maMonHoc)";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void ThemGV(string mgv, string tgv, string ns, string qq, string mk, string mm, string ml, string sdt, string em)
        {
            string sql = "insert GiangVien values(N'" + mgv +
                "', N'" + tgv +
                "', N'" + ns +
                "', N'" + qq +
                "', N'" + mk +
                "', N'" + mm +
                "', N'" + ml +
                "', N'" + sdt +
                "', N'" + em + "')";
            da.ExcuteNonQuery(sql);
        }
        public void SuaGV(string mgv, string tgv, string ns, string qq, string mk, string mm, string ml, string sdt, string em)
        {
            string sql = "update GiangVien set tenGV = N'"
                + tgv + "', ngaySinhGV = N'"
                + ns + "', queQuanGV = N'"
                + qq + "', maKhoa = N'"
                + mk + "', maMonHoc = N'"
                + mm + "', maLop = N'"
                + ml + "', sdt = N'"
                + sdt + "', email = N'"
                + em + "' where maGV = N'" + mgv + "'";
            da.ExcuteNonQuery(sql);
        }
        public void XoaGV(string mgv)
        {
            string sql = "delete GiangVien where maGV = N'" + mgv + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimGV(string dk)
        {
            string sql = "select * from GiangVien where maGV like N'%" + dk + "%' OR tenGV like N'%" + dk + "%'OR queQuanGV like N'%" + dk + "%' OR email like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        // Table Account
        public void ThemAcc(string us, string pw)
        {
            string sql = "insert Account values(N'" + us + "', N'" + pw + "'," + 0 + ")";
            da.ExcuteNonQuery(sql);
        }
        public void ThemAcc(string us, string pw, int pq)
        {
            string sql = "insert Account values(N'" + us + "', N'" + pw + "'," + pq + ")";
            da.ExcuteNonQuery(sql);
        }
        public void SuaMK(string us, string opw, string npw)
        {
            string sql = "update Account set passWord = N'" + npw + "' where userName = N'" + us + "' and passWord = N'" + opw + "'";
            da.ExcuteNonQuery(sql);
        }
        public bool CheckAccount(string us, string pw)
        {
            string sql = "select * from Account where userName = N'" + us + "' and passWord = N'" + pw + "'";

            SqlConnection conn = da.getConnect();
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CheckQuyen(string us, string pw)
        {
            string sql = "select * from Account where userName = N'" + us + "' and passWord = N'" + pw + "'";

            SqlConnection conn = da.getConnect();
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    L.UserName = reader.GetString(0);
                    L.PassWord = reader.GetString(1);
                    L.QuyenHan = reader.GetInt32(2);
                }
                if (L.QuyenHan == 1) return 1;
                else return 0;
            }
            else
            {
                return -1;
            }
        }


        // Table Khoa
        public DataTable ShowKhoa()
        {
            string sql = "select * from Khoa";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void ThemKhoa(string mk, string tk)
        {
            string sql = "insert Khoa values(N'" + mk + "', N'" + tk + "')";
            da.ExcuteNonQuery(sql);
        }
        public void XoaKhoa(string mk)
        {
            string sql = "delete Khoa where maKhoa = N'" + mk + "'";
            da.ExcuteNonQuery(sql);
        }
        public void SuaKhoa(string mk, string tk)
        {
            string sql = "update Khoa set tenKhoa = N'" + tk + "' where maKhoa = N'" + mk + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimKhoa(string dk)
        {
            string sql = "select * from Khoa where maKhoa like N'%" + dk + "%' OR tenKhoa like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        // Table Lop
        public DataTable ShowLop()
        {
            string sql = "select l.maLop, l.tenLop, l.siSo, k.maKhoa from Lop l join Khoa k on l.maKhoa = k.maKhoa";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void ThemLop(string ml, string tl, string ss, string mk)
        {
            string sql = "insert Lop values(N'" + ml + "', N'" + tl + "', N'" + ss + "', N'" + mk + "')";
            da.ExcuteNonQuery(sql);
        }
        public void XoaLop(string ml)
        {
            string sql = "delete Lop where maLop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public void SuaLop(string ml, string tl, string ss, string mk)
        {
            string sql = "update Lop set tenLop = N'" + tl + "', siSo = " + ss + ", maKhoa = N'" + mk + "' where maLop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimLop(string dk)
        {
            string sql = "select l.maLop, l.tenLop, l.siSo, k.maKhoa from Lop l join Khoa k on l.maKhoa = k.maKhoa where maLop like N'%" + dk + "%' OR tenLop like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        // Table MonHoc
        public DataTable ShowMon()
        {
            string sql = "select mh.maMonHoc, mh.tenMonHoc, k.maKhoa from MonHoc mh join Khoa k on mh.MaKhoa = k.maKhoa";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void ThemMon(string mm, string tm, string mk)
        {
            string sql = "insert MonHoc values(N'" + mm + "', N'" + tm + "', N'" + mk + "')";
            da.ExcuteNonQuery(sql);
        }
        public void XoaMon(string mm)
        {
            string sql = "delete MonHoc where maMonHoc = N'" + mm + "'";
            da.ExcuteNonQuery(sql);
        }
        public void SuaMon(string mm, string tm, string mk)
        {
            string sql = "update MonHoc set tenMonHoc = N'" + tm + "', MaKhoa = N'" + mk + "' where maMonHoc = N'" + mm + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable TimMon(string dk)
        {
            string sql = "select mh.maMonHoc, mh.tenMonHoc, k.maKhoa from MonHoc mh join Khoa k on mh.MaKhoa = k.maKhoa where maMonHoc like N'%" + dk + "%' OR tenMonHoc like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
