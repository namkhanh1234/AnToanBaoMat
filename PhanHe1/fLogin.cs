using Oracle.ManagedDataAccess.Client;
using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel=true;
            }    
               

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            string t1 = "staff";
            string t2 = "manager";
            string t3 = "cod";
            string t4 = "finance";
            string t5 = "hr";
            string t6 = "pl";
            string t7 = "director";
            if (Login(userName, passWord))
            {
                if (userName.Contains(t1))
                {
                    fStaff f = new fStaff(userName,passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (userName.Contains(t2))
                {
                    fManager f = new fManager(userName, passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (userName.Contains(t3))
                {
                    fCOD f = new fCOD(userName, passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (userName.Contains(t4))
                {
                    fFinance f = new fFinance(userName, passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (userName.Contains(t5))
                {
                    fHR f = new fHR(userName, passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (userName.Contains(t6))
                {
                    fPL f = new fPL(userName, passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (userName.Contains(t7))
                {
                    fDirector f = new fDirector(userName, passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    Form1 f = new Form1(userName,passWord);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
 
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }    

        }
        bool Login(string userName,string passWord)
        {
            try
            {
                string query = "SELECT * from user_tables";
                DataProvider provider = new DataProvider(userName, passWord);
                int data = provider.ExecuteNonQuery(query);
            }
            catch
            {
                return false;
            }
            
            
            return true;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
