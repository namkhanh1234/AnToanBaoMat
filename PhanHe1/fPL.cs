﻿using PhanHe1.DAO;
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
    public partial class fPL : Form
    {
        private string username;
        private string password;
        public fPL(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fStaffInformation f = new fStaffInformation(username, password);
            f.ShowDialog();
        }

        private void btnViewDepartment_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADMIN.PHONGBAN";
            DataProvider provider = new DataProvider(username, password);
            dgv.DataSource = provider.ExecuteQuery(query);
        }

        private void btnViewProject_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADMIN.DEAN";
            DataProvider provider = new DataProvider(username, password);
            dgv.DataSource = provider.ExecuteQuery(query);
        }

        private void nhữngĐềÁnThamGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fJoinProject f = new fJoinProject(username, password);
            f.ShowDialog();
        }

        private void thôngTinĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fAssignmentPL f = new fAssignmentPL(username, password);
            f.ShowDialog();
        }
    }
}
