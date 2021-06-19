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
   public class CustomerBLL
    {
        CustomerDAL obj = new CustomerDAL();
        public bool CustomerInsert(CustomerProps p)
        {

            return obj.CustomerInsertDAL(p);
        }

        public bool CustomerDelete(CustomerProps p)
        {

            return obj.CustomerDeleteDAL(p);
        }

        public bool CustomerUpdate(CustomerProps p)
        {

            return obj.CustomerUpdateDAL(p);
        }

        public DataTable search_by_id(CustomerProps p)
        {

            return obj.search_by_id_Dal(p);
        }
        public DataTable searchallbll()
        {

            return obj.searchallDAL();
        }
    }
}
