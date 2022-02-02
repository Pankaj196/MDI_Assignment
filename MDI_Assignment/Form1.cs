using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD a=new ADD();
            a.Show();
            a.MdiParent = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           select s=new select();
            s.Show();
            s.MdiParent=this;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete d=new delete();
            d.Show();
            d.MdiParent = this;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update u = new update();
            u.Show();
            u.MdiParent = this;
        }
    }
}
