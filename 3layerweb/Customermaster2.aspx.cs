using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3layerweb
{
    public partial class Customermaster2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private void RetrieveUserDetails()
        {
         websqlclassessDataContext dtContext = new websqlclassessDataContext();
            GridView1.DataSource = dtContext.Customers;
            //GridView1.DataSource = from userDetails in dtContext.UserDetails  
            //                       where userDetails.City == "noida"  
            //                       select userDetails;  
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            using (websqlclassessDataContext dtContext = new websqlclassessDataContext())
            {
                Customer customers = new Customer();
                 customers.c_id = txtcid.Text;
                customers.c_id = txtname.Text;
                customers.cell = txtcell.Text;
                customers.no_item = txtnoitem.Text;
                customers.t_bill = txttbill.Text;
                dtContext.Customers.InsertOnSubmit(customers);
                dtContext.SubmitChanges();
            }
            RetrieveUserDetails();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}