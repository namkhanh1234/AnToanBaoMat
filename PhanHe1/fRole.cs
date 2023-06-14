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
    public partial class fRole : Form
    {
        public fRole()
        {
            InitializeComponent();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            string procedure = "create_role";
            int data = 0;
            string query = "rolename";
            DataProvider provider = new DataProvider();
            data = provider.ExecuteNonQuery_Procedure(procedure, query, new object[] { txbRoleName.Text });
            MessageBox.Show("Tạo role thành công");

        }

        private void btnDropRole_Click(object sender, EventArgs e)
        {
            try
            {
                string procedure = "drop_role";
                int data = 0;
                string query = "rolename";
                DataProvider provider = new DataProvider();
                data = provider.ExecuteNonQuery_Procedure(procedure, query, new object[] { txbRoleName.Text });
                MessageBox.Show("Xóa role thành công");
            }
            catch
            {
                MessageBox.Show("Nhập rolename sai");
            }
        
        }

        private void btnCancelRole_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
