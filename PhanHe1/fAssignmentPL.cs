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
    public partial class fAssignmentPL : Form
    {
        private string username;
        private string password;
        public fAssignmentPL(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

       
        private void fAssignmentPL_Load(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider(username, password);
            string query = "SELECT * FROM ADMIN.DEAN";
            dgvAssignmentPL.DataSource = provider.ExecuteQuery(query);

        }



        private void bthThem_Click(object sender, EventArgs e)
        {
            

            DataProvider provider = new DataProvider(username, password);
            string dataText = txbNgayBD.Text;
            DateTime dateValue;
            if (DateTime.TryParse(dataText, out dateValue))
            {
                string formattedDate = dateValue.ToString("dd-MM-yyyy");

                string query = "INSERT INTO ADMIN.DEAN VALUES('"
                    + txbMaDA.Text + "','" + txbTenDA.Text + "',TO_DATE('" + formattedDate + "','dd-MM-yyyy'))" + Convert.ToInt32(txbPhong.Text);
                provider.ExecuteNonQuery(query);
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Nhập không đúng định dạng ngày");
           
            dgvAssignmentPL.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.DEAN");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvAssignmentPL.SelectedRows[0];
                string cellValue = selectedRow.Cells["MADA"].Value.ToString();

                DataProvider provider = new DataProvider(username, password);
                string dataText = txbNgayBD.Text;
                DateTime dateValue;
                if (DateTime.TryParse(dataText, out dateValue))
                {
                    string formattedDate = dateValue.ToString("dd-MM-yyyy");

                    string query = "UPDATE ADMIN.DEAN SET MADA="
                        + txbMaDA.Text + ",TENDA='" + txbTenDA.Text + "',TO_DATE('" + formattedDate + "','dd-MM-yyyy'))" + ",PHONG=" + Convert.ToInt32(txbPhong.Text) + "WHERE MADA=" + cellValue;
                    provider.ExecuteNonQuery(query);
                    MessageBox.Show("Sửa thành công");
                    dgvAssignmentPL.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.DEAN");
                }
                else
                    MessageBox.Show("Nhập không đúng định dạng ngày");
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để sửa");
            };
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvAssignmentPL.SelectedRows[0];
                string cellValue = selectedRow.Cells["MADA"].Value.ToString();
                DataProvider provider = new DataProvider(username, password);
                string query = "DELETE FROM ADMIN.DEAN WHERE MADA=" + cellValue;
                provider.ExecuteNonQuery(query);
                MessageBox.Show("Xóa thành công");
                dgvAssignmentPL.DataSource = provider.ExecuteQuery("SELECT * FROM ADMIN.DEAN");
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xóa");
            };


        }
    }
}