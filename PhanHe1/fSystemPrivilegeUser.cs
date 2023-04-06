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
    public partial class fSystemPrivilegeUser : Form
    {
        public fSystemPrivilegeUser()
        {
            InitializeComponent();
        }

        private void btnSearchSystemUser_Click(object sender, EventArgs e)
        {
            string userName = txbUserNameSystemUser.Text;
            userName = userName.ToUpper();
            string query = "SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + userName + "'";
            DataProvider provider = new DataProvider();
            dgvSystemUser.DataSource = provider.ExecuteQuery(query);
            int check = provider.ExecuteNonQuery(query);
            if (check == -1)
            {
                MessageBox.Show("Không tìm thấy user này");
            }
        }
    }
}
