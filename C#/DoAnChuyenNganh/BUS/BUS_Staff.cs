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
    public class BUS_Staff
    {
        Data dal = new Data();
        DTO_Staff dto = new DTO_Staff();
        public DataTable ShowStaff()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddStaff(string mnv, string tnv, string dc, string gc)
        {
            string sql = "insert NhanVien values(N'" 
                + mnv + "', N'" 
                + tnv + "', N'"
                + dc + "', N'"
                + gc + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelStaff(string mnv)
        {
            string sql = "delete NhanVien where maNhanVien = N'" + mnv + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateStaff(string mnv, string tnv, string dc, string gc)
        {
            string sql = "update NhanVien set tenNhanVien = N'" 
                + tnv + "', diaChiNV = N'"
                + dc + "', ghiChuNV = N'"
                + gc + "' where maNhanVien = N'" + mnv + "'";
            dal.ExcuteNonQuery(sql);
        }
    }
}
