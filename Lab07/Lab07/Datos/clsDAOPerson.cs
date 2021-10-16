using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDAOPerson :clsDAO
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            con.Open();
            string sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            con.Close();

            return dt;
        }
        public DataTable GetOne(string id)
        {
            DataTable dt = new DataTable();

            con.Open();
            string sql = "select * from Person where PersonID = " + id;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            con.Close();

            return dt;
        }
    }
}
