using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
namespace DataAccessLayer
{
    public class ProductDAL
    {
        dbcon db = new dbcon();
        public bool ProductInsertDAL(ProductProps P)
        {

            string query = "INSERT INTO Product VALUES('" + P.Pid + "','" + P.Title + "','" + P.Price + "','" + P.Stock + "','" + P.Expiry + "','" + P.Manufacturor + "')";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }



        public bool ProductDeleteDAL(ProductProps P)
        {



            string query = "Delete  Product Where pid='" + P.Pid + "'";

            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;
        }

        public bool ProductUpdateDAL(ProductProps P)
        {

            String query = "Update Product set title='" + P.Title + "', price='" + P.Price + "', stock='" + P.Stock + "', Expiry='" + P.Expiry + "', Manuf='" + P.Manufacturor + "' where pid='" + P.Pid + "'";
            db.OpenCon();
            db.UDI(query);
            db.CloseCon();
            return true;


        }


        public DataTable search_by_id_Dal(ProductProps p)
        {
            String query = "Select * From Product Where pid='" + p.Pid + "'";
            db.OpenCon();
            DataTable dt = db.Search(query);
            db.CloseCon();
            return dt;
        }

        public DataTable searchallDAL()
        {
            String query = "SELECT * FROM Product";
            
            db.OpenCon();
            DataTable dt = db.Search(query);
            db.CloseCon();
            return dt;
        }



    }
}
