using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrjProps;
using BusinessLayer;
using System.Data;

namespace _3layerweb
{
    public partial class MainDisplay1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeSignUp.aspx");
            Server.Transfer("EmployeeSignUp.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customersignup.aspx");
            Server.Transfer("Customersignup.aspx");
        }



        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suppliersignup.aspx");
            Server.Transfer("Suppliersignup.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adminsignup.aspx");
            Server.Transfer("Adminsignup.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customermaster2.aspx");
            Server.Transfer("Customermaster2.aspx");
        }

        protected void Button7_Click1(object sender, EventArgs e)
        {
            try
            {
                LoginProps p = new LoginProps();
                p.Username = txtname.Text;
                p.Password = txtpassword.Text;

                LoginBLL obj = new LoginBLL();
                  obj.LoginnBLL(p);
                if (p.Acesslevel == "Employee")
                {
                    
                        Session["name"] = txtname.Text;
                        Session["password"] = txtpassword.Text;
                        Response.Redirect("Employee.aspx");
                        Server.Transfer("Employee.aspx");
                    

                }
                else if (p.Acesslevel == "Customer")
                {
                    Session["name"] = txtname.Text;
                    Session["password"] = txtpassword.Text;
                    Response.Redirect("Customermaster.aspx");
                    Server.Transfer("Customermaster.aspx");

                }

                else if (p.Acesslevel == "Admin")
                {
                    Session["name"] = txtname.Text;
                    Session["password"] = txtpassword.Text;
                    Response.Redirect("Admin.aspx");
                    Server.Transfer("Admin.aspx");

                }
                if (p.Acesslevel == "Supplier")
                {
                    Session["name"] = txtname.Text;
                    Session["password"] = txtpassword.Text;
                    Response.Redirect("Suppliermaster.aspx");
                    Server.Transfer("Suppliermaster.aspx");

                }
                else
                {

                    lblout.Text = ("not login");
                }
            }
            catch (Exception ex)
            {
                lblout.Text = ("not login"+ex);
            }

        }
    }
}