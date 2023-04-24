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
    public class BUS_Sight
    {
        Data dal = new Data();
        DTO_Sight dto = new DTO_Sight();
        public DataTable ShowSight()
        {
            string sql = "select * from DiemThamQuan";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public DataTable ShowSight(string mdd)
        {
            string sql = "select maDiemThamQuan, tenDiemThamQuan, ghiChuDTQ from DiemThamQuan where maDiemDen = N'" + mdd + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void AddSight(string mtq, string ttq, string gc, string mdd)
        {
            string sql = "insert DiemThamQuan values(N'"
                + mtq + "', N'"
                + ttq + "', N'"
                + gc + "', N'"
                + mdd + "')";
            dal.ExcuteNonQuery(sql);
        }
        public void DelSight(string mtq)
        {
            string sql = "delete DiemThamQuan where maDiemThamQuan = N'" + mtq + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdateSight(string mtq, string ttq, string gc, string mdd)
        {
            string sql = "update DiemThamQuan set tenDiemThamQuan = N'"
                + ttq + "', ghiChuDTQ = N'"
                + gc + "', maDiemDen = N'"
                + mdd + "' where maDiemThamQuan = N'" + mtq + "'";
            dal.ExcuteNonQuery(sql);
        }
        public DataTable SearchSight(string dk)
        {
            string sql = "select maDiemThamQuan, tenDiemThamQuan, ghiChuDTQ from DiemThamQuan where maDiemThamQuan like N'%" + dk + "%' or tenDiemThamQuan like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}
