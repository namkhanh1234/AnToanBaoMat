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
    public partial class fEncryption : Form
    {

        private string username;
        private string password;

        public fEncryption(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            listKey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tạo các cột cho DataGridView
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "id"; // Tên cột tương ứng trong DataTable
            column1.HeaderText = "id"; // Tên hiển thị trong DataGridView
            column1.FillWeight = 10;

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "createdat";
            column2.HeaderText = "Ngày tạo";
            column2.FillWeight = 20;

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "key";
            column3.HeaderText = "Giá trị khoá";
            column3.FillWeight = 40;

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "createdby";
            column4.HeaderText = "Người tạo";
            column4.Width = 70;
            column4.FillWeight = 30 ;

            // Thêm các cột vào DataGridView
            listKey.Columns.Add(column1);
            listKey.Columns.Add(column2);
            listKey.Columns.Add(column3);
            listKey.Columns.Add(column4);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from KEY_ENCRYPT order by  CREATED_AT desc FETCH FIRST 1 ROW ONLY";
            DataProvider provider = new DataProvider(username, password);
            DataTable data = provider.ExecuteQuery(query);
            DataRow firstRow = data.Rows[0];
            String key = firstRow.Field<string>("KEY");
            MessageBox.Show(key,"Khoá mới nhất");
        }

        private void btnShowAllKey_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADMIN.KEY_ENCRYPT";
            DataProvider provider = new DataProvider(username,password);
            DataTable data = provider.ExecuteQuery(query);
            data.Columns["ID"].ColumnName = "id";
            data.Columns["CREATED_AT"].ColumnName = "createdat";
            data.Columns["KEY"].ColumnName = "key";
            data.Columns["CREATED_BY"].ColumnName = "createdby";
            listKey.DataSource = data;
        }

        private void listKey_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fEncryption_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeKey_Click(object sender, EventArgs e)
        {
            string query = "begin ADMIN.CHANGE_KEY; end;";
            DataProvider provider = new DataProvider(username, password);
            int rowAffected = provider.ExecuteNonQuery(query);
            if (rowAffected == 0)
            {
                MessageBox.Show("Thay đổi khoá không thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thay đổi khoá thành công", "Thông báo");
                string query1 = "SELECT * FROM ADMIN.KEY_ENCRYPT";
                DataTable data = provider.ExecuteQuery(query1);
                data.Columns["ID"].ColumnName = "id";
                data.Columns["CREATED_AT"].ColumnName = "createdat";
                data.Columns["KEY"].ColumnName = "key";
                data.Columns["CREATED_BY"].ColumnName = "createdby";
                listKey.DataSource = data;
            }
        }
    }
}
