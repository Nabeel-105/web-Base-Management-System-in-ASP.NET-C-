using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using PrjProps;

namespace ThreeLayerOfcMgtSystem3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ProductBLL obj = new ProductBLL();
            DataTable dt = obj.searchallbll();
            record.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("inserted");
            }
            else
            {

                MessageBox.Show("nai hota yar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("Updated");
            }
            else
            {

                MessageBox.Show("nai hota yar");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ProductBLL obj = new ProductBLL();
            DataTable dt = obj.searchallbll();
            record.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductProps p = new ProductProps();
            p.Pid = txtpid.Text;
            ProductBLL obj = new ProductBLL();
            if (obj.ProductDelete(p))
            {
                MessageBox.Show("Deleted");
            }
            else
            {

                MessageBox.Show("nai hota yar");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductProps p = new ProductProps();
            p.Pid = txtpid.Text;
           
            ProductBLL obj = new ProductBLL();
            DataTable dt = (obj.search_by_id(p));
            if(dt==null)
            {
                MessageBox.Show("nai hota yar");
            }
            else
            {
                txtpid.Text = dt.Rows[0]["pid"].ToString();
                txttitle.Text = dt.Rows[0]["title"].ToString();
                txtprize.Text = dt.Rows[0]["price"].ToString();
                txtstock.Text = dt.Rows[0]["stock"].ToString();
                txtexpiry.Text = dt.Rows[0]["expiry"].ToString();
                txtmft.Text = dt.Rows[0]["manuf"].ToString();
                

            }
        }
    }
}
