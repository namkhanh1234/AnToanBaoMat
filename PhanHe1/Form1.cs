using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using PhanHe1.DAO;

namespace PhanHe1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ALL_USERS";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }

        private void objectPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fObjectPrivilegeUser f =new fObjectPrivilegeUser();
            f.ShowDialog();
        }

        private void systemPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSystemPrivilegeUser f =new fSystemPrivilegeUser();
            f.ShowDialog();
        }

        private void objectPrivilegesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fObjectPrivilegeRole f =new fObjectPrivilegeRole();
            f.ShowDialog();
        }

        private void systemPrivilegesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fSystemPrivilegeRole f = new fSystemPrivilegeRole();
            f.ShowDialog();
        }
    }
}
