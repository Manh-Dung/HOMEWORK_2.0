using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SV_DAL
{
    public class ClassSV_Data
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=MOTHER-FUCKER;Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        public DataTable GetTable(string sql) 
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql) 
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
