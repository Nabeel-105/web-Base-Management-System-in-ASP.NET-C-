using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class EmpDAL
    {
        dbcon db = new dbcon();
        public bool empInsertDAL(EmpProps P)
        {
            
            string query = "INSERT INTO Employee VALUES('" + P.Emp_code + "','" + P.Emp_name + "','" + P.Emp_cell + "','" + P.Emp_ads + "')";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;         
        }



        public bool empDeleteDAL(EmpProps P)
        {


            
            string query = "Delete  Employee Where empid='" + P.Emp_code + "'";

            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }

        public bool empUpdateDAL(EmpProps P)
        {

            String query = "Update Employee set name='" + P.Emp_name + "',cell='" +P.Emp_cell + "',address='" + P.Emp_ads + "' where empid='" + P.Emp_code + "'";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;


        }


       public DataTable search_by_id_Dal(EmpProps p)
        {
            String query = "Select * From Employee Where empid='" + p.Emp_code + "'";
            db.OpenCon();
            DataTable dt = db.Search(query);
            db.CloseCon();
            return dt;
        }

        public DataTable searchallDAL()
        {
            String query = "SELECT * FROM Employee";
            DataTable dt;
            db.OpenCon();
            dt = db.Search(query);
            db.CloseCon();
            return dt;
        }





    }
    
}
