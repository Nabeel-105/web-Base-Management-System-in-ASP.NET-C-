using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
   public class SignupProps
    {


        private String name;
        private String email;
        private String password;
        private String confirmpassword;
        private String accesslevel;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public string Confirmpassword
        {
            get
            {
                return confirmpassword;
            }

            set
            {
                confirmpassword = value;
            }
        }

        public string Accesslevel
        {
            get
            {
                return accesslevel;
            }

            set
            {
                accesslevel = value;
            }
        }
    }
}
