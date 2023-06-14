using Oracle.ManagedDataAccess.Client;
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
    public partial class fDropUser : Form
    {
        public fDropUser()
        {
            InitializeComponent();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            try
            {
                string procedure = "drop_user";
                int data = 0;
                string query = "username";
                DataProvider provider = new DataProvider();
                data = provider.ExecuteNonQuery_Procedure(procedure, query, new object[] { txbUserNameDrop.Text });
                MessageBox.Show("Xóa user thành công");
            }
            catch
            {
                MessageBox.Show("Nhập sai username");
            }
        }

        private void btnCancelDrop_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
