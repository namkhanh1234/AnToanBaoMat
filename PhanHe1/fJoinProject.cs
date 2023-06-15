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
    public partial class fJoinProject : Form
    {
        private string username;
        private string password;
        public fJoinProject(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void fJoinProject_Load(object sender, EventArgs e)
        {
            string query = "select * from ADMIN.view_assignment";
            DataProvider provider = new DataProvider(username,password);
            dgvJoinProject.DataSource = provider.ExecuteQuery(query);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvJoinProject.SelectedRows[0];
                textBox1.Text = ((DateTime)selectedRow.Cells["THOIGIAN"].Value).ToShortDateString();

                string cellValue = selectedRow.Cells["MADA"].Value.ToString();
                DataProvider provider = new DataProvider();
                string query = "SELECT TENDA,NGAYBD FROM ADMIN.DEAN WHERE MADA= " + cellValue;
                DataTable dt = new DataTable();
                dt =  provider.ExecuteQuery(query);
                DataRow row = dt.Rows[0];

                textBox2.Text = ((DateTime)row["NGAYBD"]).ToShortDateString();
                textBox3.Text = row["TENDA"].ToString();
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xem");
            }
           
        }
    }
}
