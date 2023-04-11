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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanHe1
{
    public partial class fCreate : Form
    {
        public fCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string procedure = "create_new_user";
            int data = 0;
            string query = "username password";
            DataProvider provider = new DataProvider();
            data=provider.ExecuteNonQuery_Procedure(procedure, query,new object[] {txbUserNameCreate.Text,txbPassWordCreate.Text});
            MessageBox.Show("Tạo user thành công");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
