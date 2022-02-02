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
namespace MDI_Assignment
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void button1_Click(object sender, EventArgs e)
        {
            string con = "data source =devops.aapnainfotech.com;database=MDIAssignment; uid=apnsa; pwd=W98rd41lMravjL5";
            string query = "delete * from Employee where eid = '" + textBox1.Text + "' ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Employee");
            dataGridView1.DataSource = ds.Tables["Employee"];

        }
    }
}
