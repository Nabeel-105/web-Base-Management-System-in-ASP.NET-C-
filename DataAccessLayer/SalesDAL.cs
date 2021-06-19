using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using System.Data;

namespace DataAccessLayer
{
   public class SalesDAL
    {
        dbcon db = new dbcon();
        public bool SalesInsertDAL(SalesProps P)
        {

            string query = "INSERT INTO Sales VALUES('" + P.Reciept + "','" + P.Product_name + "','" + P.Price + "','" + P.Quantity + "','" + P.Date + "','" + P.Soldby + "')";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }



        public bool SalesDeleteDAL(SalesProps P)
        {



            string query = "Delete  Sales Where recipt_no='" + P.Reciept + "'";

            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }

        public bool SalesUpdateDAL(SalesProps P)
        {

            String query = "Update Sales set p_name='" + P.Product_name + "', price='" + P.Price + "', quantity='" + P.Quantity + "', date='" + P.Date + "', sold_by='" + P.Soldby+ "' where recipt_no='" + P.Reciept + "'";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;


        }

        public bool ProductUpdateDAL(SalesProps P)
        {

            String query = "Update Product set  stock='" + P.Stock + "' where title='" + P.Product_name + "'";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;


        }


        public DataTable search_by_id_Dal(SalesProps p)
        {
            String query = "Select * From Sales Where recipt_no='" + p.Reciept + "'";
            db.OpenCon();
            DataTable dt = db.Search(query);
            db.CloseCon();
            return dt;
        }

        public DataTable searchallDAL()
        {
            String query = "SELECT * FROM Sales";

            db.OpenCon();
            DataTable dt = db.Search(query);
            db.CloseCon();
            return dt;
        }


        public DataTable loadsalesproductnameDAL()
        {

            String query = "Select title from Product";
            db.OpenCon();
            DataTable dt = db.Search(query);
            db.CloseCon();
            return dt;
        }

        public DataTable loadsalesempnameDAL()
        {

            String query = "Select name from Employee";
            db.OpenCon();
            DataTable dtt = db.Search(query);
            db.CloseCon();
            return dtt;
        }

      





    }
}
