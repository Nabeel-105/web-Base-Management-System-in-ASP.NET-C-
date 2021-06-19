using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;

namespace DataAccessLayer
{

   public class SupplierDAL
    {
        dbcon db = new dbcon();
        public bool SupplierInsertDAL(SupplierProps P)
        {

            string query = "INSERT INTO Supplier VALUES('" + P.Sid + "','" + P.Sname + "','" + P.Cell + "','" + P.Itemsupply + "','" + P.Name_of_reciver + "','" + P.Amount + "')";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }



        public bool SupplierDeleteDAL(SupplierProps P)
        {



            string query = "Delete  Supplier Where s_id='" + P.Sid + "'";

            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }

        public bool SupplierUpdateDAL(SupplierProps P)
        {

            String query = "Update Supplier set s_name='" + P.Sname + "',cell='" + P.Cell + "',item_supply='" + P.Itemsupply + "',name_reciver='" + P.Name_of_reciver + "' ,t_amount='" + P.Amount + "' where s_id='" + P.Sid + "'";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;


        }


        public DataTable search_by_id_Dal(SupplierProps p)
        {
            String query = "Select * From Supplier Where s_id='" + p.Sid + "'";
            db.OpenCon();
            DataTable dt = db.Search(query);
            db.CloseCon();
            return dt;
        }

        public DataTable searchallDAL()
        {
            String query = "SELECT * FROM Supplier";
            DataTable dt;
            db.OpenCon();
            dt = db.Search(query);
            db.CloseCon();
            return dt;
        }


    }
}

