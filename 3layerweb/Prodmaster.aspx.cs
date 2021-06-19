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
    public partial class Prodmaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductBLL b = new ProductBLL();
                DataTable dt = b.searchallbll();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            ProductProps p = new ProductProps();
            p.Pid = txtpid.Text;
            p.Title = txttitle.Text;
            p.Price = txtprize.Text;
            p.Stock = txtstock.Text;
            p.Expiry = txtexpiry.Text;
            p.Manufacturor = txtmft.Text;
            ProductBLL obj = new ProductBLL();
            if (obj.ProductInsert(p))
            {
                lblout.Text = "inserted";
            }
            else
            {

                lblout.Text="nai hota yar";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ProductProps p = new ProductProps();
            p.Pid = txtpid.Text;
            p.Title = txttitle.Text;
            p.Price = txtprize.Text;
            p.Stock = txtstock.Text;
            p.Expiry = txtexpiry.Text;
            p.Manufacturor = txtmft.Text;
            ProductBLL obj = new ProductBLL();
            if (obj.ProductUpdate(p))
            {
                lblout.Text = "Updated";
            }
            else
            {

                lblout.Text = "nai hota yar";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ProductProps p = new ProductProps();
            p.Pid = txtpid.Text;
            ProductBLL obj = new ProductBLL();
            if (obj.ProductDelete(p))
            {
                lblout.Text = "Deleted";
            }
            else
            {

                lblout.Text = "nai hota yar";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProductProps p = new ProductProps();
            p.Pid = txtpid.Text;

            ProductBLL obj = new ProductBLL();
            DataTable dt = (obj.search_by_id(p));
            if (dt == null)
            {
                lblout.Text="nai hota yar";
            }
            else
            {
                txtpid.Text = dt.Rows[0]["pid"].ToString();
                txttitle.Text = dt.Rows[0]["title"].ToString();
                txtprize.Text = dt.Rows[0]["price"].ToString();
                txtstock.Text = dt.Rows[0]["stock"].ToString();
                txtexpiry.Text = dt.Rows[0]["expiry"].ToString();
                txtmft.Text = dt.Rows[0]["manuf"].ToString();
                lblout.Text = "data showed";


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
            Server.TransferRequest("Employee.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customermaster.aspx");
            Server.TransferRequest("Customermaster.aspx");
        }

        protected void button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suppliermaster.aspx");
            Server.TransferRequest("Suppliermaster.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Prodmaster.aspx");
        }
    }
}