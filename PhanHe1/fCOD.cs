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
    public partial class fCOD : Form
    {
        private string username;
        string password;
        public fCOD(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fStaffInformation f = new fStaffInformation(username, password);
            f.ShowDialog();
        }
    }
}
