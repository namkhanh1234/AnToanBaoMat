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
    public partial class fStaffInformation : Form
    {
        public fStaffInformation(string username, string password)
        {
            InitializeComponent();
            DataProvider provider = new DataProvider(username,password);
            string query = "select * from ADMIN.NHANVIEN WHERE MANV=SUBSTR(SYS_CONTEXT('USERENV', 'SESSION_USER'),-3)";
            DataTable dt = new DataTable();
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fStaffInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
