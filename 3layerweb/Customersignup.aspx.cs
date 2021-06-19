using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrjProps;
using BusinessLayer;

namespace _3layerweb
{
    public partial class Customersignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SignupProps p = new SignupProps();
            p.Name = txtname.Text;
            p.Email = txtemail.Text;
            p.Password = txtpass.Text;
            p.Confirmpassword = txtcpass.Text;
            p.Accesslevel = "Customer";
            SignupBLL obj = new SignupBLL();
            if (p.Password == p.Confirmpassword)
            {
                if (obj.RegisterBLL(p))
                {
                    lblout.Text = "Registered";
                }
            }
            else
            {
                lblout.Text = " not Register bcz your password not match";

            }

        }
    }
}