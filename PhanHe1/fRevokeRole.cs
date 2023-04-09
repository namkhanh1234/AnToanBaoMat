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
    public partial class fRevokeRole : Form
    {
        public fRevokeRole()
        {
            InitializeComponent();
            string queryUserList = "SELECT ROLE FROM DBA_ROLES";
            DataProvider provider = new DataProvider();
            cbUserNameRole.DataSource = provider.ExecuteQuery(queryUserList);
            cbUserNameRole.DisplayMember = "ROLE";
        }

        private void cbUserNameRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTableRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT PRIVILEGE FROM ROLE_TAB_PRIVS WHERE ROLE = '" + cbUserNameRole.Text + "' AND TABLE_NAME='" + cbTableRole.Text + "'";
            DataProvider provider = new DataProvider();
            cbPrivilegesRole.DataSource = provider.ExecuteQuery(query);
            cbPrivilegesRole.DisplayMember = "PRIVILEGE";
        }

        private void btnObjectRole_Click(object sender, EventArgs e)
        {
            cbTableRole.Enabled = true;
            string query = "SELECT TABLE_NAME FROM ROLE_TAB_PRIVS WHERE ROLE = '" + cbUserNameRole.Text + "' AND OWNER='ADMIN'";
            DataProvider provider = new DataProvider();
            cbTableRole.DataSource = provider.ExecuteQuery(query);
            cbTableRole.DisplayMember = "TABLE_NAME";
        }

        private void btnSystemRole_Click(object sender, EventArgs e)
        {
            cbTableRole.Enabled = false;
            string query = "SELECT PRIVILEGE FROM ROLE_SYS_PRIVS WHERE ROLE = '" + cbUserNameRole.Text + "'";
            DataProvider provider = new DataProvider();
            cbPrivilegesRole.DataSource = provider.ExecuteQuery(query);
            cbPrivilegesRole.DisplayMember = "PRIVILEGE";
        }

        private void btnRevokeRole_Click(object sender, EventArgs e)
        {
            string query = "REVOKE " + cbPrivilegesRole.Text + " ON " + cbTableRole.Text + " FROM " + cbUserNameRole.Text;
            DataProvider provider = new DataProvider();
            int data = provider.ExecuteNonQuery(query);
            MessageBox.Show("Thu hồi quyền thành công");
        }

        private void btnCancleRevokeRole_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
