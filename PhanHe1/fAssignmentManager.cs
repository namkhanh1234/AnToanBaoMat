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
    public partial class fAssignmentManager : Form
    {
        private string username;
        private string password;
        public fAssignmentManager(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void fAssignmentManager_Load(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider(username,password);
            string query = "SELECT * FROM ADMIN.PHANCONG";
            dgvAssignmentManager.DataSource = provider.ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvAssignmentManager.SelectedRows[0];
          

                string cellValue = selectedRow.Cells["MADA"].Value.ToString();
                DataProvider provider = new DataProvider(username,password);
                string query = "SELECT TENDA,NGAYBD FROM ADMIN.DEAN WHERE MADA= " + cellValue;
                DataTable dt = new DataTable();
                dt = provider.ExecuteQuery(query);
                DataRow row = dt.Rows[0];

                txbDateStart.Text = ((DateTime)row["NGAYBD"]).ToShortDateString();
                txbNameProject.Text = row["TENDA"].ToString();

                cellValue = selectedRow.Cells["MANV"].Value.ToString();
                query = "SELECT * FROM ADMIN.view_infomation_staff_manager WHERE MANV= " + cellValue;      
                dt = provider.ExecuteQuery(query);
                row = dt.Rows[0];

                txbNameStaff.Text = row["TENNV"].ToString();
                txbPhone.Text = row["SODT"].ToString();
                MessageBox.Show(cellValue);
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xem");
            }
        }
    }
}
