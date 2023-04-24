using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SV_DTO;
using SV_DAL;

namespace SV_BUS
{
    public class ClassSV_BUS
    {
        ClassSV_Data da = new ClassSV_Data();
        ClassSV_DTO L = new ClassSV_DTO();

        public DataTable ShowSV()
        {
            string sql = "select SinhVien.MaSV, SinhVien.HoTen, SinhVien.QueQuan, Lop.TenLop from SinhVien, Lop where SinhVien.MaLop = Lop.MaLop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertSV(string msv, string ht, string qq, string ml)
        {
            string sql = "insert SinhVien values(N'" + msv + "', N'" + ht + "', N'" + qq + "', N'" + ml + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateSV(string msv, string ht, string qq, string ml)
        {
            string sql = "update SinhVien set HoTen = N'" + ht + "', QueQuan = N'" + qq + "', MaLop = N'" + ml + "' where MaSV = N'" + msv + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteSV(string msv)
        {
            string sql = "delete SinhVien where MaSV = N'" + msv + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchSV(string dk)
        {
            string sql = "select * from SinhVien where MaSV like N'%" + dk + "%' OR HoTen like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
