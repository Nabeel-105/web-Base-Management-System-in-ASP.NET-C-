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
    public partial class Suppliermaster : System.Web.UI.Page
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
                SupplierBLL b = new SupplierBLL();
                DataTable dt = b.searchallbll();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
            Server.Transfer("Employee.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customermaster.aspx");
            Server.Transfer("Customermaster.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Prodmaster.aspx");
            Server.Transfer("Prodmaster.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suppliermaster.aspx");
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SupplierProps p = new SupplierProps();
            p.Sid = txtsid.Text;
            p.Sname = txtname.Text;
            p.Cell = txtcell.Text;
            p.Itemsupply = txtitemsupply.Text;
            p.Name_of_reciver = txtnamereciver.Text;
            p.Itemsupply = txtitemsupply.Text;
            p.Amount = txtamount.Text;
            SupplierBLL obj = new SupplierBLL();
            if (obj.SupplierInsert(p))
            {
                lblout.Text = "inserted";
            }
            else
            {

                lblout.Text = "nai hota yar";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SupplierProps p = new SupplierProps();
            p.Sid = txtsid.Text;
            p.Sname = txtname.Text;
            p.Cell = txtcell.Text;
            p.Itemsupply = txtitemsupply.Text;
            p.Name_of_reciver = txtnamereciver.Text;
            p.Itemsupply = txtitemsupply.Text;
            p.Amount = txtamount.Text;
            SupplierBLL obj = new SupplierBLL();
            if (obj.SupplierUpdate(p))
            {
                lblout.Text = "Updated";
            }
            else
            {

                lblout.Text = "nai hota yar";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SupplierProps p = new SupplierProps();
            p.Sid = txtsid.Text;
           
            SupplierBLL obj = new SupplierBLL();
            if (obj.SupplierDelete(p))
            {
                lblout.Text = "Deleted";
            }
            else
            {

                lblout.Text = "nai hota yar";
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SupplierProps p = new SupplierProps();
            p.Sid = txtsid.Text;

            SupplierBLL obj = new SupplierBLL();
            DataTable dt = (obj.search_by_id(p));
            if (dt == null)
            {
                lblout.Text = "nai hota yar";
            }
            else
            {
                txtsid.Text = dt.Rows[0]["s_id"].ToString();
                txtname.Text = dt.Rows[0]["s_name"].ToString();
                txtcell.Text = dt.Rows[0]["cell"].ToString();
                txtitemsupply.Text = dt.Rows[0]["item_supply"].ToString();
                txtnamereciver.Text = dt.Rows[0]["name_reciver"].ToString();
                txtamount.Text = dt.Rows[0]["t_amount"].ToString();

                lblout.Text = "data showed";


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}