using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using DataAccessLayer;
namespace BusinessLayer
{
   public class SalesBLL
    {
        SalesDAL obj = new SalesDAL();
        public bool SalesInsert(SalesProps p)
        {

            return obj.SalesInsertDAL(p);
        }

        public bool SalesDelete(SalesProps p)
        {

            return obj.SalesDeleteDAL(p);
        }

        public bool SalesUpdate(SalesProps p)
        {

            return obj.SalesUpdateDAL(p);
        }

        public DataTable search_by_id(SalesProps p)
        {

            return obj.search_by_id_Dal(p);
        }
        public DataTable searchallbll()
        {

            return obj.searchallDAL();
        }

        public DataTable loadsalesproductname()
        {

            return obj.loadsalesproductnameDAL();
        }

        public DataTable loadsalesempname()
        {

            return obj.loadsalesempnameDAL();
        }

        public bool ProductUpdateBLL(SalesProps P)
        {
            return obj.ProductUpdateDAL(P);
        }
}

}
