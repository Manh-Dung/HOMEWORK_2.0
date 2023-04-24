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
    public class BUS_Shop
    {
        Data dal = new Data();
        DTO_Shop dto = new DTO_Shop();
        public DataTable ShowShop()
        {
            string sql = "select * from MuaSam";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable ShowShop(string mdd)
        {
            string sql = "select maMuaSam, tenMuaSam, diaChiMS, dienThoaiMS, emailMS, ghiChuMS from MuaSam where maDiemDen = N'" + mdd + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void AddShop(string mms, string tms, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "insert MuaSam values(N'"
                + mms + "', N'"
                + tms + "', N'"
                + dc + "', N'"
                + dt + "', N'"
                + em + "', N'"
                + gc + "', N'"
                + mdd + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelShop(string mms)
        {
            string sql = "delete MuaSam where maMuaSam = N'" + mms + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateShop(string mms, string tms, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "update MuaSam set tenMuaSam = N'"
                + tms + "', diaChiMS = N'"
                + dc + "', dienThoaiMS = N'"
                + dt + "', emailMS = N'"
                + em + "', ghiChuMS = N'"
                + gc + "', maDiemDen = N'"
                + mdd + "' where maMuaSam = N'" + mms + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchShop(string dk)
        {
            string sql = "select maMuaSam, tenMuaSam, diaChiMS, dienThoaiMS, emailMS, ghiChuMS from MuaSam where tenMuaSam like N'%" + dk + "%' or  diaChiMS like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
