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
    public class BUS_Destina
    {
        Data dal = new Data();
        DTO_Destina dto = new DTO_Destina();
        public DataTable ShowDestina()
        {
            string sql = "select * from DiemDen";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddDestina(string mdd, string tdd, string gc)
        {
            string sql = "insert DiemDen values(N'"
                + mdd + "', N'"
                + tdd + "', N'"
                + gc + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelDestina(string mdd)
        {
            string sql = "delete DiemDen where maDiemDen = N'" + mdd + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateDestina(string mdd, string tdd, string gc)
        {
            string sql = "update DiemDen set tenDiemDen = N'"
                + tdd + "', ghiChuDD = N'"
                + gc + "' where maDiemDen = N'" + mdd + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchDestina(string dk)
        {
            string sql = "select * from DiemDen where tenDiemDen like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
