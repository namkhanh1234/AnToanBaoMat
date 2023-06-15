using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class fStaffInformation : Form
    {
        private string username;
        private string password;
        public fStaffInformation(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            DataProvider provider = new DataProvider(username, password);
            DataTable dt = new DataTable();

            string query = "select * from ADMIN.view_staff";

             dt = provider.ExecuteQuery(query);
             DataRow row = dt.Rows[0];

             txbName.Text = row["TENNV"].ToString();
             txbID.Text = row["MANV"].ToString();
             txbGender.Text = row["PHAI"].ToString();
             txbBirthDay.Text = ((DateTime)row["NGAYSINH"]).ToShortDateString();
             txbAddress.Text = row["DIACHI"].ToString();
             txbPhoneNumber.Text = row["SODT"].ToString();
             txbSalary.Text = row["LUONG"].ToString();
             txbBonus.Text = row["PHUCAP"].ToString();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fStaffInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string dateText = txbBirthDay.Text;
            DateTime dateValue;
            if (DateTime.TryParse(dateText, out dateValue))
            {
                string formattedDate = dateValue.ToString("dd-MM-yyyy");
                DataProvider provider = new DataProvider(username, password);
                string query = "UPDATE ADMIN.view_staff SET SODT= '" + txbPhoneNumber.Text + "',DIACHI= '" + txbAddress.Text + "',NGAYSINH = TO_DATE('"+ formattedDate+"', 'dd-MM-yyyy')";
                int data = provider.ExecuteNonQuery(query);
                query = "commit";
                data = provider.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật thành công");
            }    
            else
            {
                MessageBox.Show("Ngày nhập không đúng định dạng");
            }    
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
