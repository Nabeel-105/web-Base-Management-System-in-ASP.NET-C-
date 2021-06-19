using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class dbcon
    {
        SqlConnection con;
        public dbcon()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-MHFFI2S;Initial Catalog=db_ofc;Integrated Security=True");
        }
        public void OpenCon()
        {
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }

        public bool UDI(String query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable Search(String query)
        {

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            else
            {
                return dt;
            }
        }


        public DataTable Searchstockprice(String query)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return dt;

            }
            else
            {
                return dt;
            }
        }

        public DataTable Loginn(String query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            else
            {
                return dt;
            }



        }
    }
}
