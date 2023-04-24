using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class LopBUS
    {
        Data da = new Data();
        LopDTO l = new LopDTO();

        public DataTable showLop()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public BindingSource
        public void insertLop(string ml, string tl, int ssv)
        {
            string sql = "insert Lop values(N'" + ml + "', N'" + tl + "', N'" + ssv + "')";
            da.ExcuteNonQuery(sql);
        }
        public void updateLop(string ml, string tl, int ssv)
        {
            string sql = "update Lop set TenLop = N'" + tl + "', SoSV = N'" + ssv + "'where MaLop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public void deleteLop(string ml)
        {
            string sql = "delete Lop where MaLop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable timKiem(string dk)
        {
            string sql = "select * from Lop where MaLop like N'%" + dk + "%' or TenLop like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
    }
}