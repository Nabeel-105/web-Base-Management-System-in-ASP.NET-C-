using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrjProps;
namespace DataAccessLayer
{
    public class SignupDAL
    {
        dbcon db = new dbcon();
        public bool RegisterDAL(SignupProps P)
        {

            string query = "INSERT INTO Registeration VALUES('" + P.Name + "','" + P.Email + "','" + P.Password + "','" + P.Confirmpassword + "','" + P.Accesslevel + "')";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }
    }
}
