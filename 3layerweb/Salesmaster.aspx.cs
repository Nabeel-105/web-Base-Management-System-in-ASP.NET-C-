using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using PrjProps;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace _3layerweb
{
    public partial class Salesmaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SalesBLL obj = new SalesBLL();
                SalesProps p = new SalesProps();
                DataTable dt = obj.loadsalesproductname();
                DataTable dtt = obj.loadsalesempname();
               
            if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        p.Product_name = dr["title"].ToString();
                        DropDownList1.Items.Add(p.Product_name);
                }
                foreach (DataRow dr in dtt.Rows)
                {
                    
                    DropDownList2.Items.Add(dr["name"].ToString());
                }
               

            }

            
                SalesBLL b = new SalesBLL();
                DataTable d = b.searchallbll();
                GridView1.DataSource = d;
                GridView1.DataBind();
            }



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbcon db = new dbcon();
            String query = "Select price,stock from Product where title='"+ DropDownList1.SelectedItem.ToString() +"'";
            db.OpenCon();
            DataTable dt = db.Searchstockprice(query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txtprice.Text = dr["price"].ToString();
                    txtstock.Text = dr["stock"].ToString();
                }
            }
            db.CloseCon();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
            Server.TransferRequest("Employee.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Prodmaster.aspx");
            Server.TransferRequest("Prodmaster.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customermaster.aspx");
            Server.TransferRequest("Customermaster.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SalesProps p = new SalesProps();
            SalesBLL obj = new SalesBLL();
            
            p.Reciept = txtreciept.Text;
            p.Product_name = DropDownList1.Text;
            p.Price = txtprice.Text;
            p.Stock = txtstock.Text;
            p.Quantity = txtquantity.Text;
            p.Date= txtdate.Text;
            p.Soldby = DropDownList2.Text;

            int stock= Convert.ToInt32(txtstock.Text);
            int quantity = Convert.ToInt32(txtquantity.Text);
            int newstock = stock - quantity;
            p.Stock = newstock.ToString();
            if (obj.ProductUpdateBLL(p)) {

                lblout1.Text = "stock updated";
               
                if (obj.SalesInsert(p))
                {
                    lblout.Text = "inserted";
                }
                else
                {
                    lblout.Text = " not inserted";

                }
            }
            else
            {

            }
        }

        protected void txtprice_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SalesProps p = new SalesProps();
            p.Reciept = txtreciept.Text;
            p.Product_name = DropDownList1.Text;
            p.Price = txtprice.Text;
            p.Stock = txtstock.Text;
            p.Quantity = txtquantity.Text;
            p.Date = txtdate.Text;
            p.Soldby = DropDownList2.Text;
            SalesBLL obj = new SalesBLL();
            if (obj.SalesUpdate(p))
            {
                lblout.Text = "Updated";
            }
            else
            {
                lblout.Text = " ni ho ra yar";

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SalesProps p = new SalesProps();
            p.Reciept = txtreciept.Text;
          
            SalesBLL obj = new SalesBLL();
            if (obj.SalesDelete(p))
            {
                lblout.Text = "Deleted";
            }
            else
            {
                lblout.Text = " ni ho ra yar";

            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SalesProps p = new SalesProps();
            p.Reciept = txtreciept.Text;

            SalesBLL obj = new SalesBLL();
            DataTable dt = (obj.search_by_id(p));
            if (dt == null)
            {
                lblout.Text = "nai hota yar";
            }
            else
            {
                DropDownList1.DataSource = dt;
                DropDownList2.DataSource = dt;
                txtreciept.Text = dt.Rows[0]["recipt_no"].ToString();
                DropDownList1.DataTextField = "p_name";
                DropDownList1.DataBind();
                txtprice.Text = dt.Rows[0]["price"].ToString();
                txtstock.Text = dt.Rows[0]["stock"].ToString();
                txtquantity.Text = dt.Rows[0]["quantity"].ToString();
                txtdate.Text = dt.Rows[0]["date"].ToString();
                DropDownList2.DataTextField = "sold_by";
                DropDownList2.DataBind();

                lblout.Text = "data showed";


            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SalesBLL b = new SalesBLL();
            DataTable d = b.searchallbll();
            GridView1.DataSource = d;
            GridView1.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Salesmaster.aspx");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            dbcon db = new dbcon();
            db.OpenCon();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select price,stock from Product where title='" + DropDownList1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtprice.Text = dr["price"].ToString();
                txtstock.Text = dr["stock"].ToString();
            }

            db.CloseCon();
        }
    }
}