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
    public partial class fStaffInformation : Form
    {
        private string username;
        private string password;
        public fStaffInformation(string username, string password)
        {
            InitializeComponent();

            DataProvider provider = new DataProvider(username,password);
            DataTable dt = new DataTable();

            string query = "select * from ADMIN.NHANVIEN";
            
            dt = provider.ExecuteQuery(query);
            DataRow row = dt.Rows[0];   

            txbName.Text = row["TENNV"].ToString();
            txbID.Text = row["MANV"].ToString();
            txbGender.Text = row["PHAI"].ToString();
            txbBirthDay.Text = row["NGAYSINH"].ToString();
            txbAddress.Text = row["DIACHI"].ToString();
            txbPhoneNumber.Text = row["SODT"].ToString();
            txbSalary.Text = row["LUONG"].ToString();
            txbBonus.Text = row["PHUCAP"].ToString();
            this.username = username;
            this.password = password;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fStaffInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tmp = txbPhoneNumber.Text;
            DataProvider provider = new DataProvider(username, password);
            string query = "UPDATE ADMIN.NHANVIEN SET SODT= ' " + txbPhoneNumber.Text + " '";
            int data = provider.ExecuteNonQuery(query);
            MessageBox.Show(txbPhoneNumber.Text);
            //MessageBox.Show("Cập nhật thành công");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
