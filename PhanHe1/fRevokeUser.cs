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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class fRevokeUser : Form
    {
        public fRevokeUser()
        {
            InitializeComponent();
            string queryUserList = "SELECT username FROM all_users";
            DataProvider provider = new DataProvider();
            cbUserName.DataSource = provider.ExecuteQuery(queryUserList);
            cbUserName.DisplayMember = "username";

   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fRevokeUser_Load(object sender, EventArgs e)
        {

        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT PRIVILEGE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + cbUserName.Text + "' AND TABLE_NAME='"+cbTable.Text+"'";
            DataProvider provider = new DataProvider();
            cbPrivileges.DataSource = provider.ExecuteQuery(query);
            cbPrivileges.DisplayMember = "PRIVILEGE";
        }

        private void btnRevokeUser_Click(object sender, EventArgs e)
        {
            string query = "REVOKE " + cbPrivileges.Text + " ON " + cbTable.Text + " FROM " + cbUserName.Text;
            DataProvider provider = new DataProvider();
            int data = provider.ExecuteNonQuery(query);
            MessageBox.Show("Thu hồi quyền thành công");
        }

        private void btnCancleRevoke_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnObject_Click(object sender, EventArgs e)
        {
            cbTable.Enabled = true;
            string query = "SELECT TABLE_NAME FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + cbUserName.Text + "' AND OWNER='ADMIN'";
            DataProvider provider = new DataProvider();
            cbTable.DataSource = provider.ExecuteQuery(query);
            cbTable.DisplayMember = "TABLE_NAME";
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            cbTable.Enabled = false;
            string query = "SELECT PRIVILEGE FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + cbUserName.Text + "'";
            DataProvider provider = new DataProvider();
            cbPrivileges.DataSource = provider.ExecuteQuery(query);
            cbPrivileges.DisplayMember = "PRIVILEGE";
        }

        private void cbPrivileges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
