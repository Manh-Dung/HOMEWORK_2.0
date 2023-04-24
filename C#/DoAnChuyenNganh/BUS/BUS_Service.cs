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
    public class BUS_Service
    {
        Data dal = new Data();
        DTO_Service dto = new DTO_Service();
        public DataTable ShowService()
        {
            string sql = "select * from DichVuKhac";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable ShowService(string mdd)
        {
            string sql = "select maDichVu, tenDichVu, diaChiDV, dienThoaiDV, emailDV, ghiChuDV from DichVuKhac where maDiemDen = N'" + mdd + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void AddService(string mdv, string tdv, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "insert DichVuKhac values(N'"
                + mdv + "', N'"
                + tdv + "', N'"
                + dc + "', N'"
                + dt + "', N'"
                + em + "', N'"
                + gc + "', N'"
                + mdd + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelService(string mdv)
        {
            string sql = "delete DichVuKhac where maDichVu = N'" + mdv + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateService(string mdv, string tdv, string dc, string dt, string em, string gc, string mdd)
        {
            string sql = "update DichVuKhac set tenDichVu = N'"
                + tdv + "', diaChiDV = N'"
                + dc + "', dienThoaiDV = N'"
                + dt + "', emailDV = N'"
                + em + "', ghiChuDV = N'"
                + gc + "', maDiemDen = N'"
                + mdd + "' where maDichVu = N'" + mdv + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchService(string dk)
        {
            string sql = "select maDichVu, tenDichVu, diaChiDV, dienThoaiDV, emailDV, ghiChuDV from DichVuKhac where tenDichVu like N'%" + dk + "%' or  diaChiDV like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
