using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjProps;
using BusinessLayer;

namespace ThreeLayerOfcMgtSystem3
{
    public partial class Form1 : Form
    {
        EmpBLL obj = new EmpBLL();
        public Form1()
        {
            InitializeComponent();
            DataTable dt = obj.searchallbll();
            JTable.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtcell.Text;
            p.Emp_ads = txtadrs.Text;
            EmpBLL obj = new EmpBLL();
            if (obj.empInsert(p))
            {
                MessageBox.Show("inserted");
            }
            else
            {

                MessageBox.Show("nai hota yar");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtcell.Text;
            p.Emp_ads = txtadrs.Text;
            EmpBLL obj = new EmpBLL();
            if (obj.empDelete(p))
            {
                MessageBox.Show("Deleted");
            }
            else
            {

                MessageBox.Show("nai hota yar delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
            EmpBLL obj = new EmpBLL();
            DataTable dt = obj.search_by_id(p);
            if(dt==null)
            {
                MessageBox.Show("Record not found");
            }
            else
            {
                txtid.Text = dt.Rows[0]["empid"].ToString();
                txtname.Text = dt.Rows[0]["name"].ToString();
                txtcell.Text = dt.Rows[0]["cell"].ToString();
                txtadrs.Text= dt.Rows[0]["address"].ToString();
            }
         
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_code = txtid.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtcell.Text;
            p.Emp_ads = txtadrs.Text;
            EmpBLL obj = new EmpBLL();
            if (obj.empUpdate(p))
            {
                MessageBox.Show("Updated");
            }
            else
            {

                MessageBox.Show("nai hota yar");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmpBLL obj = new EmpBLL();
            DataTable dt = obj.searchallbll();
            JTable.DataSource = dt;
        }
    }
}
