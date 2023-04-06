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
    public partial class fObjectPrivilegeUser : Form
    {
        public fObjectPrivilegeUser()
        {
            InitializeComponent();
        }

        private void btnSearchObjectUser_Click(object sender, EventArgs e)
        {
            string userName= txbUserNameObjectUser.Text;
            userName = userName.ToUpper();
            string query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + userName+"'";
            DataProvider provider = new DataProvider();
            dgvObjectUser.DataSource = provider.ExecuteQuery(query);
            int check = provider.ExecuteNonQuery(query);
            if (check == -1)
            {
                MessageBox.Show("Không tìm thấy user này");
            }
        }
    }
}
