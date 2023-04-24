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
    public class BUS_Restaurant
    {
        Data dal = new Data();
        DTO_Restaurant dto = new DTO_Restaurant();
        public DataTable ShowRestau()
        {
            string sql = "select * from NhaHang";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable ShowRestau(string mdd)
        {
            string sql = "select maNhaHang, tenNhaHang, diaChiNH, dienThoaiNH, emailNH, ghiChuNH from NhaHang where maDiemDen = N'" + mdd + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void AddRestau(string mnh, string tnh, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "insert NhaHang values(N'"
                + mnh + "', N'"
                + tnh + "', N'"
                + dc + "', N'"
                + dt + "', N'"
                + em + "', N'"
                + gc + "', N'"
                + mdd + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelRestau(string mnh)
        {
            string sql = "delete NhaHang where maNhaHang = N'" + mnh + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateRestau(string mnh, string tnh, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "update NhaHang set tenNhaHang = N'"
                + tnh + "', diaChiNH = N'"
                + dc + "', dienThoaiNH = N'"
                + dt + "', emailNH = N'"
                + em + "', ghiChuNH = N'"
                + gc + "', maDiemDen = N'"
                + mdd + "' where maNhaHang = N'" + mnh + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchRestau(string dk)
        {
            string sql = "select maNhaHang, tenNhaHang, diaChiNH, dienThoaiNH, emailNH, ghiChuNH from NhaHang where tenNhaHang like N'%" + dk + "%' or  diaChiNH like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
