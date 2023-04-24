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
    public class BUS_SampleTour
    {
        Data dal = new Data();
        DTO_SampleTour dto = new DTO_SampleTour();
        public DataTable ShowSample()
        {
            string sql = "select * from TourMau";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddSample(string mt, string tt, string ht, float kc, float cp)
        {
            string sql = "insert TourMau values(N'"
                + mt + "', N'"
                + tt + "', N'"
                + ht + "', "
                + kc + ", "
                + cp + ")";
            dal.ExcuteNonQuery(sql);
        }
        public void DelSample(string mt)
        {
            string sql = "delete TourMau where maTourMau = N'" + mt + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateSample(string mt, string tt, string ht, float kc, float cp)
        {
            string sql = "update TourMau set tenTour = N'"
                + tt + "', hanhTrinh = N'"
                + ht + "', khoangCach = "
                + kc + ", chiPhi = "
                + cp + " where maTourMau = N'" + mt + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchSample(string dk)
        {
            string sql = "select * from TourMau where maTourMau like N'%" + dk + "%' OR tenTour like N'%" + dk + "%' OR hanhTrinh like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
