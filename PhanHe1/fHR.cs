using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1
{
    public partial class fHR : Form
    {
        private string username;
        private string password;    
        public fHR(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fStaffInformation f = new fStaffInformation(username, password);
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADMIN.PHONGBAN";
            DataProvider provider = new DataProvider(username, password);
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADMIN.DEAN";
            DataProvider provider = new DataProvider(username, password);
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }
    }
}
