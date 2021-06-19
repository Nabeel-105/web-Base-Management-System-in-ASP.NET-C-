using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrjProps;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;

namespace _3layerweb
{
    public partial class Employee : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                EmpBLL b = new EmpBLL();
                DataTable dt = b.searchallbll();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtcell.Text;
            p.Emp_ads = txtadrs.Text;
            EmpBLL obj = new EmpBLL();
            if (obj.empInsert(p))
            {
                lblout.Text = "inserted";
            }
            else
            {
                lblout.Text = " not inserted";
               
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtcell.Text;
            p.Emp_ads = txtadrs.Text;
            EmpBLL obj = new EmpBLL();
            if (obj.empUpdate(p))
            {
                lblout.Text = "updated";
            }
            else
            {

                lblout.Text = "nai hora";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
           
            EmpBLL obj = new EmpBLL();
            if (obj.empDelete(p))
            {
                lblout.Text = "Deleted";
            }
            else
            {

                lblout.Text = "nai hora";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
            EmpBLL obj = new EmpBLL();
            DataTable dt = obj.search_by_id(p);
            if (dt == null)
            {
                lblout.Text = "nai hora";
            }
            else
            {
                txtid.Text = dt.Rows[0]["empid"].ToString();
                txtname.Text = dt.Rows[0]["name"].ToString();
                txtcell.Text = dt.Rows[0]["cell"].ToString();
                txtadrs.Text = dt.Rows[0]["address"].ToString();
            }


        }
       

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
        }

      

        protected void Button5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Prodmaster.aspx");
            Server.Transfer("Prodmaster.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button8_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customermaster.aspx");
            Server.TransferRequest("Customermaster.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suppliermaster.aspx");
            Server.TransferRequest("Suppliermaster.aspx");
        }
    }
}