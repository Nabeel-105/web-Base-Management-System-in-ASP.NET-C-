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
  public  class EmpBLL
    {
        EmpDAL obj = new EmpDAL();
        public bool empInsert(EmpProps p)
        {
            
            return obj.empInsertDAL(p);
        }

        public bool empDelete(EmpProps p)
        {
            
            return obj.empDeleteDAL(p);
        }

        public bool empUpdate(EmpProps p)
        {
            
            return obj.empUpdateDAL(p);
        }

        public DataTable search_by_id(EmpProps p)
        {
           
            return obj.search_by_id_Dal(p);
        }
        public DataTable searchallbll()
        {
           
            return obj.searchallDAL();
        }
    }
}
