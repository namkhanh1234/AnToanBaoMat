using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class fDepartmentHR : Form
    {
        private string username;
        private string password;
        public fDepartmentHR(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }


        private void fDepartmentHR_Load(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider(username, password);
            string query = "";

            query = "SELECT * FROM ADMIN.PHONGBAN";

            dgvDepartmentHR.DataSource = provider.ExecuteQuery(query);


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            

            DataProvider provider = new DataProvider(username, password);

            string query = "INSERT INTO ADMIN.PHANCONG VALUES("
               + Convert.ToInt32(txbMaPB.Text) + ",'" + txbTenPB + "'," + Convert.ToInt32(txbMaTP.Text);
            provider.ExecuteNonQuery(query);
            MessageBox.Show("Thêm thành công");
            dgvDepartmentHR.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.PHONGBAN");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvDepartmentHR.SelectedRows[0];
                string cellValue = selectedRow.Cells["MAPB"].Value.ToString();

                DataProvider provider = new DataProvider(username, password);

                string query = "UPDATE ADMIN.PHANCONG SET MAPB="
                   + Convert.ToInt32(txbMaPB.Text) + ",TenPB='" + txbTenPB + "',TRPHG=" + Convert.ToInt32(txbMaTP.Text) + "WHERE MAPB=" + cellValue;
                provider.ExecuteNonQuery(query);
                MessageBox.Show("Sửa thành công");
                dgvDepartmentHR.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.PHONGBAN");
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để sửa");
            };
        }
    }
}

