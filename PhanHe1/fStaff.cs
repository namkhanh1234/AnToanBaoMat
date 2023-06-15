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
    public partial class fStaff : Form
    {
        private string username;
        private string password;
        public fStaff(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADMIN.DEAN";
            DataProvider provider = new DataProvider(username, password);
            dgvStaff.DataSource = provider.ExecuteQuery(query);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fStaffInformation f = new fStaffInformation(username,password);
            f.ShowDialog();
        }

        private void fStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnViewDepartment_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADMIN.PHONGBAN";
            DataProvider provider = new DataProvider(username,password);
            dgvStaff.DataSource=provider.ExecuteQuery(query);

        }

        private void nhữngĐềÁnThamGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fJoinProject f = new fJoinProject(username,password);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvStaff.SelectedRows[0];
            string cellValue1 = selectedRow.Cells["MAPB"].Value.ToString();
            MessageBox.Show(cellValue1);
        }
    }
}
