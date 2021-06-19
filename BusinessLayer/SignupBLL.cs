using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using DataAccessLayer;
namespace BusinessLayer
{
   public class SignupBLL
    {
        SignupDAL obj = new SignupDAL();
        public bool RegisterBLL(SignupProps p)
        {

            return obj.RegisterDAL(p);
        }
    }
}
