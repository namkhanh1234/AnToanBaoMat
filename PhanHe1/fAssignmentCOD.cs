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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class fAssignmentCOD : Form
    {
        private string username;
        private string password;
        public fAssignmentCOD(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void LoadAssignment()
        {
            DataProvider provider = new DataProvider(username, password);
            string query = "SELECT * FROM ADMIN.PHANCONG";
            dgvAssignmentCOD.DataSource = provider.ExecuteQuery(query);
        }

        private void fAssignmentCOD_Load(object sender, EventArgs e)
        {
            LoadAssignment();
            txbIDStaff.DataBindings.Add(new Binding("Text", dgvAssignmentCOD.DataSource, "MANV"));
            txbIDProject.DataBindings.Add(new Binding("Text", dgvAssignmentCOD.DataSource, "MADA"));
            txbDateJoin.DataBindings.Add(new Binding("Text", dgvAssignmentCOD.DataSource, "THOIGIAN", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvAssignmentCOD.SelectedRows[0];
                string cellValue = selectedRow.Cells["MADA"].Value.ToString();
                DataProvider provider = new DataProvider(username, password);
                string query = "SELECT TENDA,NGAYBD FROM ADMIN.DEAN WHERE MADA= " + cellValue;
                DataTable dt = new DataTable();
                dt = provider.ExecuteQuery(query);
                DataRow row = dt.Rows[0];

                txbDateStart.Text = ((DateTime)row["NGAYBD"]).ToShortDateString();
                txbNameProject.Text = row["TENDA"].ToString();

                cellValue = selectedRow.Cells["MANV"].Value.ToString();
                query = "SELECT * FROM ADMIN.view_infomation_staff_cod WHERE MANV= " + cellValue;
                dt = provider.ExecuteQuery(query);
                row = dt.Rows[0];

                txbNameStaff.Text = row["TENNV"].ToString();
                txbPhone.Text = row["SODT"].ToString();
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xem");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvAssignmentCOD.SelectedRows[0];
                string cellProject = selectedRow.Cells["MADA"].Value.ToString();
                string cellStaff = selectedRow.Cells["MANV"].Value.ToString();
                DataProvider provider = new DataProvider(username, password);
                string query = "DELETE FROM ADMIN.PHANCONG WHERE MADA= " + cellProject + " AND MANV= " + cellStaff ;

                int check = provider.ExecuteNonQuery(query);
                query = "commit";
                check = provider.ExecuteNonQuery(query);

                LoadAssignment();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Chưa chọn cột để xóa");
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string dataText = txbDateJoin.Text;
            DateTime dateValue;
            if (DateTime.TryParse(dataText, out dateValue))
            {
                string formattedDate = dateValue.ToString("dd-MM-yyyy");
                DataProvider provider = new DataProvider(username, password);

                string query = "INSERT INTO ADMIN.PHANCONG(MANV,MADA,THOIGIAN) VALUES("
                    + txbIDStaff.Text + "," + txbIDProject.Text + ",TO_DATE('" + formattedDate + "','dd-MM-yyyy'))";
                int check = provider.ExecuteNonQuery(query);
                    
                if (check ==-1)
                {
                    MessageBox.Show("Mã nhân viên hoặc mã đề án không hợp lệ dd/MM/yyyy");
                }    
                else
                {
                    query = "commit";
                    check = provider.ExecuteNonQuery(query);

                    LoadAssignment();
                    MessageBox.Show("Thêm thành công");
                }

            }
            else
            {
                MessageBox.Show("Nhập không đúng định dạng ngày");
            }    

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string dataText = txbDateJoin.Text;
            DateTime dateValue;
            if (DateTime.TryParse(dataText, out dateValue))
            {
                string formattedDate = dateValue.ToString("dd-MM-yyyy");
                DataProvider provider = new DataProvider(username, password);

                DataGridViewRow selectedRow = dgvAssignmentCOD.SelectedRows[0];
                string cellProject = selectedRow.Cells["MADA"].Value.ToString();
                string cellStaff = selectedRow.Cells["MANV"].Value.ToString();

                string query = "UPDATE ADMIN.PHANCONG SET THOIGIAN = TO_DATE('" + formattedDate + "', 'dd-MM-yyyy') WHERE MANV= "
                    +cellStaff + " AND MADA= " + cellProject ;
                int check = provider.ExecuteNonQuery(query);

                if (check == -1)
                {
                    MessageBox.Show("Mã nhân viên hoặc mã đề án không hợp lệ dd/MM/yyyy");
                }
                else
                {
                    query = "commit";
                    check = provider.ExecuteNonQuery(query);

                    LoadAssignment();
                    MessageBox.Show("Cập nhật thành công");
                }

            }
            else
            {
                MessageBox.Show("Nhập không đúng định dạng ngày");
            }
        }
    }
}
