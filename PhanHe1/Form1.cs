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
using Oracle.ManagedDataAccess.Types;
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

        private void btnGrantPrivileges_Click(object sender, EventArgs e)
        {
            fGrantPrivileges f = new fGrantPrivileges();
            f.ShowDialog();
        }

        private void cấpQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantPrivileges f = new fGrantPrivileges();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGrantPrivileges_Click_1(object sender, EventArgs e)
        {
            fGrantPrivileges f = new fGrantPrivileges();
            f.ShowDialog();
        }

        private void tạoUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCreate f = new fCreate();
            f.ShowDialog();
        }

        private void xóaUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDropUser f = new fDropUser();
            f.ShowDialog();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRole f = new fRole();
            f.ShowDialog();
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            fRevokeUser f = new fRevokeUser();
            f.ShowDialog();
        }

        private void thayĐổiMậtKhẩuUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePass f = new fChangePass();
            f.ShowDialog();
        }

        private void userToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fRevokeUser f = new fRevokeUser();
            f.ShowDialog();
        }

        private void roleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fRevokeRole f = new fRevokeRole();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
