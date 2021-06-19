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
    public partial class Customermaster : System.Web.UI.Page
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
                CustomerBLL b = new CustomerBLL();
                DataTable dt = b.searchallbll();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
            Server.Transfer("Employee.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Prodmaster.aspx");
            Server.Transfer("Prodmaster.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suppliermaster.aspx");
            Server.Transfer("Suppliermaster.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CustomerProps p = new CustomerProps();
            p.Cid = txtcid.Text;
            p.Cname = txtname.Text;
            p.Cell = txtcell.Text;
            p.No_of_item = txtnoitem.Text;
            p.T_bill = txttbill.Text;
            CustomerBLL obj = new CustomerBLL();
            if (obj.CustomerInsert(p))
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
            CustomerProps p = new CustomerProps();
            p.Cid = txtcid.Text;
            p.Cname = txtname.Text;
            p.Cell = txtcell.Text;
            p.No_of_item = txtnoitem.Text;
            p.T_bill = txttbill.Text;
            CustomerBLL obj = new CustomerBLL();
            if (obj.CustomerUpdate(p))
            {
                lblout.Text = "Updated";
            }
            else
            {
                lblout.Text = " not Updated";

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            CustomerProps p = new CustomerProps();
            p.Cid = txtcid.Text;
            CustomerBLL obj = new CustomerBLL();
            if (obj.CustomerDelete(p))
            {
                lblout.Text = "Deleted";
            }
            else
            {

                lblout.Text = "nai hota yar";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            CustomerProps p = new CustomerProps();
            p.Cid = txtcid.Text;

            CustomerBLL obj = new CustomerBLL();
            DataTable dt = (obj.search_by_id(p));
            if (dt == null)
            {
                lblout.Text = "nai hota yar";
            }
            else
            {
                txtcid.Text = dt.Rows[0]["c_id"].ToString();
                txtname.Text = dt.Rows[0]["c_name"].ToString();
                txtcell.Text = dt.Rows[0]["cell"].ToString();
                txtnoitem.Text = dt.Rows[0]["no_item"].ToString();
                txttbill.Text = dt.Rows[0]["t_bill"].ToString();
                
                lblout.Text = "data showed";


            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customermaster.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}