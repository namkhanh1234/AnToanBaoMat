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
    public partial class fObjectPrivilegeRole : Form
    {
        public fObjectPrivilegeRole()
        {
            InitializeComponent();
        }

        private void btnSearchObjectRole_Click(object sender, EventArgs e)
        {
            string roleName = txbUserNameObjectRole.Text;
            roleName = roleName.ToUpper();
            string query = "SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE = '" + roleName + "'";
            DataProvider provider = new DataProvider();
            dgvObjectRole.DataSource = provider.ExecuteQuery(query);
       
        }

        private void fObjectPrivilegeRole_Load(object sender, EventArgs e)
        {

        }
    }
}
