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
    public class Lop_BUS
    {
        Data da = new Data();
        Lop_DTO l = new Lop_DTO();

        public DataTable ShowBN()
        {
            string sql = "select BenhNhan.maBN, BenhNhan.hoTen, BenhNhan.ngayNV, KhoaKham.tenKhoa from BenhNhan, KhoaKham where BenhNhan.maKhoa = KhoaKham.maKhoa";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void DeleteBN(string mbn)
        {
            string sql = "delete BenhNhan where maBN = N'" + mbn + "'";
            da.ExcuteNonQuery(sql);
        }
    }
    
}
