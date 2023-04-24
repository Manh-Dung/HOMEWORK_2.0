using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=MOTHER-FUCKER;Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        public DataTable getTable(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);
        }

        public BindingSource
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
