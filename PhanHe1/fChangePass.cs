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
    public partial class fChangePass : Form
    {
        public fChangePass()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string procedure = "change_password_user";
            int data = 0;
            string query = "username password";
            DataProvider provider = new DataProvider();
            data = provider.ExecuteNonQuery_Procedure(procedure, query, new object[] { txbUserNameChange.Text, txbPassWordChange.Text });
            MessageBox.Show("Thay đổi mật khẩu thành công");
        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
