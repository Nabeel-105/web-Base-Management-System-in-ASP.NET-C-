using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using PrjProps;

namespace BusinessLayer
{
    public class SupplierBLL
    {
        SupplierDAL obj = new SupplierDAL();
        public bool SupplierInsert(SupplierProps p)
        {

            return obj.SupplierInsertDAL(p);
        }

        public bool SupplierDelete(SupplierProps p)
        {

            return obj.SupplierDeleteDAL(p);
        }

        public bool SupplierUpdate(SupplierProps p)
        {

            return obj.SupplierUpdateDAL(p);
        }

        public DataTable search_by_id(SupplierProps p)
        {

            return obj.search_by_id_Dal(p);
        }
        public DataTable searchallbll()
        {

            return obj.searchallDAL();
        }
    }
}
