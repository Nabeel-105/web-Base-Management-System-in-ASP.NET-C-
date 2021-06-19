using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3layerweb
{
    public partial class Admin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null && Session["password"] != null)
            {
                lblout1.Text = ("you are login");
                lblout1.Visible = true;

            }
            else
            {
                Response.Redirect("MainDisplay1.aspx");
            }
        }
    }
}