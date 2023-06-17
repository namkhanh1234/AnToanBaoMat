namespace PhanHe1
{
    partial class fAssignmentManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvAssignmentManager = new System.Windows.Forms.DataGridView();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNameStaff = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbNameProject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbDateStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentManager)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAssignmentManager);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(380, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 445);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.a);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 73);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvAssignmentManager
            // 
            this.dgvAssignmentManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignmentManager.Location = new System.Drawing.Point(9, 79);
            this.dgvAssignmentManager.Name = "dgvAssignmentManager";
            this.dgvAssignmentManager.RowHeadersWidth = 51;
            this.dgvAssignmentManager.RowTemplate.Height = 24;
            this.dgvAssignmentManager.Size = new System.Drawing.Size(363, 369);
            this.dgvAssignmentManager.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 67);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbNameStaff);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(8, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 53);
            this.panel5.TabIndex = 1;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.a.Location = new System.Drawing.Point(25, 23);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(318, 24);
            this.a.TabIndex = 1;
            this.a.Text = "Những phân công của nhân viên";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chi tiết của nhân viên và đề án";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txbNameStaff
            // 
            this.txbNameStaff.Location = new System.Drawing.Point(118, 20);
            this.txbNameStaff.Name = "txbNameStaff";
            this.txbNameStaff.ReadOnly = true;
            this.txbNameStaff.Size = new System.Drawing.Size(157, 22);
            this.txbNameStaff.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbNameProject);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(8, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 101);
            this.panel6.TabIndex = 2;
            // 
            // txbNameProject
            // 
            this.txbNameProject.Location = new System.Drawing.Point(118, 20);
            this.txbNameProject.Multiline = true;
            this.txbNameProject.Name = "txbNameProject";
            this.txbNameProject.ReadOnly = true;
            this.txbNameProject.Size = new System.Drawing.Size(157, 78);
            this.txbNameProject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đề án tham gia:";
            this.label3.UseMnemonic = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbPhone);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(8, 134);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 53);
            this.panel7.TabIndex = 3;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(118, 20);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.ReadOnly = true;
            this.txbPhone.Size = new System.Drawing.Size(157, 22);
            this.txbPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbDateStart);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(8, 300);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(285, 74);
            this.panel8.TabIndex = 4;
            // 
            // txbDateStart
            // 
            this.txbDateStart.Location = new System.Drawing.Point(118, 20);
            this.txbDateStart.Name = "txbDateStart";
            this.txbDateStart.ReadOnly = true;
            this.txbDateStart.Size = new System.Drawing.Size(157, 22);
            this.txbDateStart.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày bắt đầu đề án:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fAssignmentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fAssignmentManager";
            this.Text = "Thông tin phân công của nhân viên";
            this.Load += new System.EventHandler(this.fAssignmentManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentManager)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAssignmentManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbDateStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbNameProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbNameStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
    }
}