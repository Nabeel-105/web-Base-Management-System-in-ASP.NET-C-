using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
   public class LoginProps
    {
        private string username;
        private string password;
        private string acesslevel;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Acesslevel
        {
            get
            {
                return acesslevel;
            }

            set
            {
                acesslevel = value;
            }
        }
    }
}
