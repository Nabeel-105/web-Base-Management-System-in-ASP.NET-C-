using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using PrjProps;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class LoginBLL
    {
        LoginDAL obj = new LoginDAL();
        public DataTable LoginnBLL(LoginProps p)
        {

            return obj.LoginnDAL(p);
        }
    }
}
