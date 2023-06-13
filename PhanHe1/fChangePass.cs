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
            string query = "ALTER USER " +txbUserNameChange.Text+ " IDENTIFIED BY " + txbPassWordChange.Text;
            DataProvider provider = new DataProvider();
            int data = provider.ExecuteNonQuery(query);
            MessageBox.Show("Thay đổi mật khẩu thành công");
        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}
