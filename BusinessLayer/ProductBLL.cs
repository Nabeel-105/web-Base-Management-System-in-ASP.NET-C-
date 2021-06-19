using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class ProductBLL
    {

        ProductDAL obj = new ProductDAL();
        public bool ProductInsert(ProductProps p)
        {

            return obj.ProductInsertDAL(p);
        }

        public bool ProductDelete(ProductProps p)
        {

            return obj.ProductDeleteDAL(p);
        }

        public bool ProductUpdate(ProductProps p)
        {

            return obj.ProductUpdateDAL(p);
        }

        public DataTable search_by_id(ProductProps p)
        {

            return obj.search_by_id_Dal(p);
        }
        public DataTable searchallbll()
        {

            return obj.searchallDAL();
        }
    }
}
