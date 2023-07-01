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
    public partial class fViewStaffManager : Form
    {
        private string username;
        private string password;
        public fViewStaffManager(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void fViewStaffManager_Load(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider(username,password);
            string query="";
            if (username.Contains("manager"))
            {
                query = "SELECT * FROM ADMIN.view_infomation_staff_manager";
            }    
            else
            {
                query = "SELECT * FROM ADMIN.view_infomation_staff_cod";
            }    
            
            dgvViewStaffManager.DataSource=provider.ExecuteQuery(query);
            txbName.DataBindings.Add(new Binding("Text", dgvViewStaffManager.DataSource, "TENNV"));
            txbPhoneNumber.DataBindings.Add(new Binding("Text", dgvViewStaffManager.DataSource, "SODT"));
            txbBirthday.DataBindings.Add(new Binding("Text", dgvViewStaffManager.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));
            txbAddress.DataBindings.Add(new Binding("Text", dgvViewStaffManager.DataSource, "DIACHI"));
            txbGender.DataBindings.Add(new Binding("Text", dgvViewStaffManager.DataSource, "PHAI"));
            txbIdDepartment.DataBindings.Add(new Binding("Text", dgvViewStaffManager.DataSource, "PHG"));


        }

        private void dgvViewStaffManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
