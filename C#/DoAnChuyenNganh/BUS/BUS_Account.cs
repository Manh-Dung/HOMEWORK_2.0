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
    public class BUS_Account
    {
        Data dal = new Data();
        DTO_Account dto = new DTO_Account();

        public DataTable ShowAcc()
        {
            string sql = "select * from Account";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void AddAcc(string us, string pw)
        {
            string sql = "insert Account values(N'" + us + "', N'" + pw + "'," + 0 + ")";
            dal.ExcuteNonQuery(sql);
        }
        public void AddAcc(string us, string pw, int per)
        {
            string sql = "insert Account values(N'" + us + "', N'" + pw + "'," + per + ")";
            dal.ExcuteNonQuery(sql);
        }
        public void DelAcc(string us, string pw)
        {
            string sql = "delete Account where userName = N'" + us + "' and passWord = N'" + pw + "'";
            dal.ExcuteNonQuery(sql);
        }
        public void UpdatePass(string us, string opw, string npw)
        {
            string sql = "update Account set passWord = N'" + npw + "' where userName = N'" + us + "' and passWord = N'" + opw + "'";
            dal.ExcuteNonQuery(sql);
        }
        public bool PassCheck(string us, string pw)
        {
            string sql = "select * from Account where userName = N'" + us + "' and passWord = N'" + pw + "'";

            SqlConnection conn = dal.getConnect();
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int PermissionCheck(string us, string pw)
        {
            string sql = "select * from Account where userName = N'" + us + "' and passWord = N'" + pw + "'";

            SqlConnection conn = dal.getConnect();
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dto.UserName = reader.GetString(0);
                    dto.PassWord = reader.GetString(1);
                    dto.Permission = reader.GetInt32(2);
                }
                if (dto.Permission == 1) return 1;
                else return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
