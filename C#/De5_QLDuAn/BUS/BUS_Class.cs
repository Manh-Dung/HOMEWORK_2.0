using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Class
    {
        Data dal = new Data();
        DTO_Class dto = new DTO_Class();

        // Account
        public DataTable ShowAcc()
        {
            string sql = "select * from Account";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddAcc(string us, string pw)
        {
            string sql = "insert Account values(N'" + us + "', N'" + pw + "'," + 0 + ")";
            dal.ExcuteNonQuery(sql);
        }
        public void AddAcc(string us, string pw, int per)
        {
            string sql = "insert Account values(N'" + us + "', N'" + pw + "'," + per + ")";
            dal.ExcuteNonQuery(sql);
        }
        public void DelAcc(string us, string pw)
        {
            string sql = "delete Account where username = N'" + us + "' and passWord = N'" + pw + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdatePass(string us, string opw, string npw)
        {
            string sql = "update Account set passWord = N'" + npw + "' where username = N'" + us + "' and passWord = N'" + opw + "'";
            dal.ExcuteNonQuery(sql);
        }
        public bool PassCheck(string us, string pw)
        {
            string sql = "select * from Account where username = N'" + us + "' and passWord = N'" + pw + "'";

            SqlConnection conn = dal.getConnect();
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
        public int PermissionCheck(string us, string pw)
        {
            string sql = "select * from Account where username = N'" + us + "' and password = N'" + pw + "'";

            SqlConnection conn = dal.getConnect();
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dto.Username = reader.GetString(0);
                    dto.Password = reader.GetString(1);
                    dto.Permission = reader.GetInt32(2);
                }
                if (dto.Permission == 1) return 1;
                else return 0;
            }
            else
            {
                return -1;
            }
        }

        // Khoa
        public DataTable ShowKhoa()
        {
            string sql = "SELECT* FROM Khoa";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddKhoa(string mk, string tk)
        {
            string sql = "insert Khoa values(N'" + mk + "', N'" + tk + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelKhoa(string mk)
        {
            string sql = "delete Khoa where maKhoa = N'" + mk + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateKhoa(string mk, string tk)
        {
            string sql = "update Khoa set tenKhoa = N'" + tk + "' where maKhoa = N'" + mk + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchKhoa(string dk)
        {
            string sql = "select * from Khoa where maKhoa like N'%" + dk + "%' OR tenKhoa like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        // Lop
        public DataTable ShowLop()
        {
            string sql = "select l.maLop, l.tenLop, k.maKhoa, gv.maGV from ((Lop l inner join Khoa k on l.maKhoa = k.maKhoa) inner join GiangVien gv on l.maGV = gv.maGV)";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddLop(string ml, string tl, string mk, string mgv)
        {
            string sql = "insert Lop values(N'" + ml + "', N'" + tl + "', N'" + mk + "', N'" + mgv + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelLop(string ml)
        {
            string sql = "delete Lop where maLop = N'" + ml + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateLop(string ml, string tl, string mk, string mgv)
        {
            string sql = "update Lop set tenLop = N'" + tl + "', maKhoa = '" + mk + "', maGV = N'" + mgv + "' where maLop = N'" + ml + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchLop(string dk)
        {
            string sql = "select l.maLop, l.tenLop, k.tenKhoa, gv.tenGV from ((Lop l inner join Khoa k on l.maKhoa = k.maKhoa) inner join GiangVien gv on l.maGV = gv.maGV) where maLop like N'%" + dk + "%' OR tenLop like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        // Giang vien
        public DataTable ShowGV()
        {
            string sql = "select * from GiangVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddGV(string mgv, string tgv, string sdt, string em)
        {
            string sql = "insert GiangVien values(N'" + mgv + "', N'" + tgv + "', N'" + sdt + "', N'" + em + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelGV(string mgv)
        {
            string sql = "delete GiangVien where maGV = N'" + mgv + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateGV(string mgv, string tgv, string sdt, string em)
        {
            string sql = "update GiangVien set tenGV = N'" + tgv + "', soDTGV = '" + sdt + "', emailGV = N'" + em + "' where maGV = N'" + mgv + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchGV(string dk)
        {
            string sql = "select * from GiangVien where maGV like N'%" + dk + "%' OR tenGV like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        // De tai
        public DataTable ShowDT()
        {
            string sql = "SELECT* FROM DeTai";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddDT(string mdt, string tdt)
        {
            string sql = "insert DeTai values(N'" + mdt + "', N'" + tdt + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelDT(string mdt)
        {
            string sql = "delete DeTai where maDeTai = N'" + mdt + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateDT(string mdt, string tdt)
        {
            string sql = "update DeTai set tenDeTai = N'" + tdt + "' where maDeTai = N'" + mdt + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchDT(string dk)
        {
            string sql = "select * from DeTai where maDeTai like N'%" + dk + "%' OR tenDeTai like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        // SinhVien
        public DataTable ShowSV()
        {
            string sql = "SELECT sv.maSV, sv.tenSV, sv.ngaySinh, sv.soDT, sv.email, sv.queQuan, l.maLop, dt.maDeTai from ((SinhVien sv inner join Lop l on sv.maLop = l.maLop)inner join DeTai dt on sv.maDeTai = dt.maDeTai)";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddSV(string msv, string tsv, string ns, string sdt, string em, string qq, string ml, string mdt)
        {
            string sql = "insert SinhVien values(N'" + msv 
                + "', N'" + tsv 
                + "', N'" + ns 
                + "', N'" + sdt 
                + "', N'" + em 
                + "', N'" + qq 
                + "', N'" + ml 
                + "', N'" + mdt + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelSV(string msv)
        {
            string sql = "delete SinhVien where maSV = N'" + msv + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateSV(string msv, string tsv, string ns, string sdt, string em, string qq, string ml, string mdt)
        {
            string sql = "update SinhVien set tenSV = N'" + tsv 
                + "', ngaySinh = N'" + ns 
                + "', soDT = N'" + sdt 
                + "', email = N'" + em 
                + "', queQuan = N'" + qq 
                + "', maLop = N'" + ml
                + "', maDeTai = N'" + mdt
                + "' where maSV = N'" + msv + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchSV(string dk)
        {
            string sql = "select * from SinhVien where maSV like N'%" + dk + "%' OR tenSV like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
