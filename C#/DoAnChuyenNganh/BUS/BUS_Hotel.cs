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
    public class BUS_Hotel
    {
        Data dal = new Data();
        DTO_Hotel dto = new DTO_Hotel();
        public DataTable ShowHotel()
        {
            string sql = "select * from KhachSan";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable ShowHotel(string mdd)
        {
            string sql = "select maKhachSan, tenKhachSan, diaChiKS, dienThoaiKS, emailKS, ghiChukS from KhachSan where maDiemDen = N'" + mdd + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void AddHotel(string mks, string tks, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "insert KhachSan values(N'"
                + mks + "', N'"
                + tks + "', N'"
                + dc + "', N'"
                + dt + "', N'"
                + em + "', N'"
                + gc + "', N'"
                + mdd + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelHotel(string mks)
        {
            string sql = "delete KhachSan where maKhachSan = N'" + mks + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateHotel(string mks, string tks, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "update KhachSan set tenKhachSan = N'"
                + tks + "', diaChiKS = N'"
                + dc + "', dienThoaiKS = N'"
                + dt + "', emailKS = N'"
                + em + "', ghiChuKS = N'"
                + gc + "', maDiemDen = N'"
                + mdd + "' where maKhachSan = N'" + mks + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchHotel(string dk)
        {
            string sql = "select maKhachSan, tenKhachSan, diaChiKS, dienThoaiKS, emailKS, ghiChuKS from KhachSan where tenKhachSan like N'%" + dk + "%' or  diaChiKS like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
