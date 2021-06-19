using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class LoginDAL
    {
        public DataTable LoginnDAL(LoginProps p)
        {
           
            dbcon db = new dbcon();
            String query = "Select acesslevel From Registeration Where name='" + p.Username + "' and password='" + p.Password + "'";
            db.OpenCon();
            DataTable dt = db.Loginn(query);
            p.Acesslevel = dt.Rows[0]["acesslevel"].ToString();
            db.CloseCon();
            return dt;

        }
    }
}
