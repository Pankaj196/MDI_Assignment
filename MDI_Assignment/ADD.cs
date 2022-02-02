using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace MDI_Assignment
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string con = "data source =devops.aapnainfotech.com;database=MDIAssignment; uid=apnsa; pwd=W98rd41lMravjL5";
                string con = ConfigurationManager.AppSettings["constr"]; 
                string query = "select * from Employee";

                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                ad.Fill(ds, "Employee");

                DataRow row = ds.Tables["Employee"].NewRow();
                row[0] = textBox1.Text;
                row[1] = textBox2.Text;
                row[2] = textBox3.Text;
                row[3] = textBox4.Text;

                ds.Tables["Employee"].Rows.Add(row);

                SqlCommandBuilder scb = new SqlCommandBuilder(ad);
                ad.Update(ds.Tables["Employee"]);
                dataGridView1.DataSource = ds.Tables["Employee"];
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
