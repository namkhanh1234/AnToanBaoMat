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
    public partial class fSalaryHR : Form
    {
        private string username;
        private string password;
        public fSalaryHR(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void fSalaryHR_Load(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider(username, password);
            string query = "";

            query = "SELECT * FROM ADMIN.view_infomation_luong_phucap_null";

            dgvSalaryHR.DataSource = provider.ExecuteQuery(query);
        }

        private void btnSuaLuong_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvSalaryHR.SelectedRows[0];
                string cellValue = selectedRow.Cells["MANV"].Value.ToString();

                DataProvider provider = new DataProvider(username, password);

                string query = "UPDATE ADMIN.NHANVIEN SET LUONG="
                   + Convert.ToInt32(txbLuong.Text) + "WHERE MANV=" + cellValue;
                provider.ExecuteNonQuery(query);
                MessageBox.Show("Sửa thành công");
                dgvSalaryHR.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.view_infomation_luong_phucap_null");
            }
            catch {
                MessageBox.Show("Chưa chọn cột để xem");
            }
        }

        private void btnSuaPC_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvSalaryHR.SelectedRows[0];
                string cellValue = selectedRow.Cells["MANV"].Value.ToString();

                DataProvider provider = new DataProvider(username, password);

                string query = "UPDATE ADMIN.NHANVIEN SET PHUCAP="
                   + Convert.ToInt32(txbPhucap.Text) + "WHERE MANV=" + cellValue;
                provider.ExecuteNonQuery(query);
                MessageBox.Show("Sửa thành công");
                dgvSalaryHR.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.view_infomation_luong_phucap_null");
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xem");
            }
        }
    }
}
