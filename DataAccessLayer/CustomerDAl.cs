using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;


namespace DataAccessLayer
{
   public class CustomerDAL
    {
        
            dbcon db = new dbcon();
            public bool CustomerInsertDAL(CustomerProps P)
            {

                string query = "INSERT INTO Customer VALUES('" + P.Cid + "','" + P.Cname+ "','" + P.Cell + "','" + P.No_of_item + "','" + P.T_bill + "')";
                db.OpenCon();
                db.UDI(query);
                db.CloseCon();
                return true;
            }



            public bool CustomerDeleteDAL(CustomerProps P)
            {



                string query = "Delete  Customer Where c_id='" + P.Cid + "'";

                db.OpenCon();
                db.UDI(query);
                db.CloseCon();
                return true;
            }

            public bool CustomerUpdateDAL(CustomerProps P)
            {

                String query = "Update Customer set c_name='" + P.Cname + "',cell='" + P.Cell + "',no_item='" + P.No_of_item + "',t_bill='" + P.T_bill + "' where c_id='" + P.Cid + "'";
                db.OpenCon();
                db.UDI(query);
                db.CloseCon();
                return true;


            }


            public DataTable search_by_id_Dal(CustomerProps p)
            {
                String query = "Select * From Customer Where c_id='" + p.Cid + "'";
                db.OpenCon();
                DataTable dt = db.Search(query);
                db.CloseCon();
                return dt;
            }

            public DataTable searchallDAL()
            {
                String query = "SELECT * FROM Customer";
                DataTable dt;
                db.OpenCon();
                dt = db.Search(query);
                db.CloseCon();
                return dt;
            }


        }
    }

