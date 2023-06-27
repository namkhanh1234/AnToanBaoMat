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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class fAssignmentFinance : Form
    {
        private string username;
        private string password;
        public fAssignmentFinance(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

       

        private void fAssignmentFinance_Load_1(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider(username, password);
            string query = "";


            query = "SELECT * FROM ADMIN.PHANCONG";


            dgvAssignmentFinance.DataSource = provider.ExecuteQuery(query);
            txbMANV.DataBindings.Add(new Binding("Text", dgvAssignmentFinance.DataSource, "MANV"));
            txbMADA.DataBindings.Add(new Binding("Text", dgvAssignmentFinance.DataSource, "MADA"));
            txbThoiGian.DataBindings.Add(new Binding("Text", dgvAssignmentFinance.DataSource, "THOIGIAN", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));
        }

        

      

        
        

       

        private void txbIDProject_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
