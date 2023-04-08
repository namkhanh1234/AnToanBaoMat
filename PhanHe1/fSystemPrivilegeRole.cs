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
    public partial class fSystemPrivilegeRole : Form
    {
        public fSystemPrivilegeRole()
        {
            InitializeComponent();
        }

        private void btnSearchSystemrRole_Click(object sender, EventArgs e)
        {
            string roleName = txbUserNameSystemRole.Text;
            roleName = roleName.ToUpper();
            string query = "SELECT * FROM ROLE_SYS_PRIVS WHERE ROLE = '" + roleName + "'";
            DataProvider provider = new DataProvider();
            dgvSystemRole.DataSource = provider.ExecuteQuery(query);
            int check = provider.ExecuteNonQuery(query);
            if (check == -1)
            {
                MessageBox.Show("Không tìm thấy role này");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
