using PhanHe1.DAO;
using System;
using System.Collections;
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
    public partial class fGrantPrivileges : Form
    {
        public fGrantPrivileges()
        {
            InitializeComponent();
            string queryUserList = "SELECT username FROM all_users";
            String queryTable = "SELECT table_name FROM all_tables WHERE owner = 'ADMIN'";
            String queryRoleList = "SELECT role FROM DBA_ROLES";
            DataProvider provider = new DataProvider();
            comboboxlisuser.DataSource = provider.ExecuteQuery(queryUserList);
            comboboxlisuser.DisplayMember = "username";
            comboBoxListTable.DataSource = provider.ExecuteQuery(queryTable);
            comboBoxListTable.DisplayMember = "table_name";
            comboBoxRole.DataSource= provider.ExecuteQuery(queryRoleList);
            comboBoxRole.DisplayMember = "role";
           
            //dgvTable.DataSource = provider.ExecuteQuery(queryTable);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fGrantPrivileges_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = comboboxlisuser.Text;
            string tablename=comboBoxListTable.Text;
            string role=comboBoxRole.Text;
            string columns = "";
            string privileges = "";
            string option = "";

            option = checkBoxGrantOption.Checked ? "WITH GRANT OPTION" : "";

            //duyệt qua list command

            CheckedListBox.CheckedItemCollection listColumns = listboxColumn.CheckedItems;

            foreach (System.Data.DataRowView item in listColumns)
            {
                columns += item["column_name"].ToString() + ",";
            }

            if (columns.Length > 0)
            {
                columns = columns.Remove(columns.Length - 1);

            }

            if (columns != "")
            {
                columns="("+columns+")";
            }
            for (int i = 0; i < checkedListBoxGrant.Items.Count; i++)
            {
                if (checkedListBoxGrant.GetItemChecked(i))
                {
                    privileges += checkedListBoxGrant.Items[i].ToString()+",";
                }
            }
            if (privileges.Length > 0)
            {
                privileges = privileges.Remove(privileges.Length - 1);

            }

            if(username!= string.Empty && role != string.Empty)
            {
                username += "," + role;
            }
            else
            {
                
                username = username != string.Empty ? username : role;
            }

            string query = "GRANT " + privileges +" "+ columns + " ON " + tablename + " TO " + username  +" "+ option;
            if (privileges == "")
            {
                MessageBox.Show("bạn chưa chọn quyền để cấp cho user!");
            }
            else
            {
                DataProvider provider = new DataProvider();
                int check = provider.ExecuteNonQuery(query);
                if (check == -1)
                {

                    MessageBox.Show("cấp quyền thành công! Vui lòng kiểm tra!");
                }
                //MessageBox.Show(query);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string query = "SELECT column_name FROM all_tab_columns WHERE table_name = '"+ comboBoxListTable.Text + "' AND owner = 'ADMIN'";
            DataProvider provider = new DataProvider();
            listboxColumn.DataSource = provider.ExecuteQuery(query);
            listboxColumn.DisplayMember = "column_name";


        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isValue1Selected = false;
            for (int i = 0; i < checkedListBoxGrant.Items.Count; i++)
            {
                if (checkedListBoxGrant.GetItemChecked(i) && (checkedListBoxGrant.Items[i].ToString() == "DELETE" || checkedListBoxGrant.Items[i].ToString() == "SELECT"))
                {
                    isValue1Selected = true;
                    break;
                }

            }
            listboxColumn.Enabled = true;
            if (isValue1Selected)
            {
                listboxColumn.Enabled = false;
            }
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if(checkBoxNoneUser.Checked)
            {
                comboboxlisuser.Text = string.Empty;
                comboboxlisuser.Enabled = false;
            }
            else
            {
                comboboxlisuser.Enabled = true;
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxNoneRole.Checked)
            {
                comboBoxRole.Text = string.Empty;
                comboBoxRole.Enabled = false;
            }
            else
            {
               
                comboBoxRole.Enabled = true;
            }
        }

        private void checkBoxNoneRole_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoneRole.Checked)
            {
                comboBoxRole.Text = string.Empty;
                comboBoxRole.Enabled = false;
            }
            else
            {
                comboBoxRole.Enabled = true;
            }
        }
    }
}
