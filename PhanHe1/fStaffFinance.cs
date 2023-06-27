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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class fStaffFinance : Form
    {
        private string username;
        private string password;
        public fStaffFinance(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fStaffFinance_Load(object sender, EventArgs e)
        {
                DataProvider provider = new DataProvider(username, password);
                string query = "";


                query = "SELECT * FROM ADMIN.NHANVIEN";


                dgvStaffFinance.DataSource = provider.ExecuteQuery(query);
                 
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow selectedRow = dgvStaffFinance.SelectedRows[0];
                string cellValue = selectedRow.Cells["MANV"].Value.ToString();

                int newLUONG = Convert.ToInt32(txbLuong.Text);
                DataProvider provider = new DataProvider(username, password);
                string query = "UPDATE NHANVIEN SET PHUCAP= " + newLUONG + " WHERE MANV= " + cellValue;
                provider.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật thành công");
                dgvStaffFinance.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.NHANVIEN");
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xem");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvStaffFinance.SelectedRows[0];
                string cellValue = selectedRow.Cells["MANV"].Value.ToString();

                int newPHUCAP = Convert.ToInt32(txbPhuCap.Text);
                DataProvider provider = new DataProvider(username, password);
                string query = "UPDATE NHANVIEN SET PHUCAP= " + newPHUCAP + " WHERE MANV= " + cellValue;
                provider.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật thành công");
                dgvStaffFinance.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.NHANVIEN");
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xem");
            }
        }
    }
}