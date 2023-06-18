namespace PhanHe1
{
    partial class fAssignmentCOD
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txbDateStart = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbNameProject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbNameStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbDateJoin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbIDProject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbIDStaff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAssignmentCOD = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentCOD)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(315, 271);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 53);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Xem";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txbDateStart
            // 
            this.txbDateStart.Location = new System.Drawing.Point(118, 20);
            this.txbDateStart.Name = "txbDateStart";
            this.txbDateStart.ReadOnly = true;
            this.txbDateStart.Size = new System.Drawing.Size(157, 22);
            this.txbDateStart.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbDateStart);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(8, 330);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(285, 74);
            this.panel8.TabIndex = 4;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.txbPhone);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(8, 134);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 53);
            this.panel7.TabIndex = 3;
            // 
            // txbNameProject
            // 
            this.txbNameProject.Location = new System.Drawing.Point(118, 20);
            this.txbNameProject.Multiline = true;
            this.txbNameProject.Name = "txbNameProject";
            this.txbNameProject.ReadOnly = true;
            this.txbNameProject.Size = new System.Drawing.Size(157, 94);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.txbNameProject);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(8, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 131);
            this.panel6.TabIndex = 2;
            // 
            // txbNameStaff
            // 
            this.txbNameStaff.Location = new System.Drawing.Point(118, 20);
            this.txbNameStaff.Name = "txbNameStaff";
            this.txbNameStaff.ReadOnly = true;
            this.txbNameStaff.Size = new System.Drawing.Size(157, 22);
            this.txbNameStaff.TabIndex = 1;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.txbNameStaff);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(8, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 53);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 67);
            this.panel4.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(381, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 410);
            this.panel2.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(298, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(291, 67);
            this.panel12.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thông tin";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txbDateJoin);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(299, 193);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(285, 53);
            this.panel11.TabIndex = 4;
            // 
            // txbDateJoin
            // 
            this.txbDateJoin.Location = new System.Drawing.Point(118, 20);
            this.txbDateJoin.Name = "txbDateJoin";
            this.txbDateJoin.Size = new System.Drawing.Size(157, 22);
            this.txbDateJoin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày tham gia:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbIDProject);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(298, 134);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(285, 53);
            this.panel10.TabIndex = 3;
            // 
            // txbIDProject
            // 
            this.txbIDProject.Location = new System.Drawing.Point(118, 20);
            this.txbIDProject.Name = "txbIDProject";
            this.txbIDProject.Size = new System.Drawing.Size(157, 22);
            this.txbIDProject.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã đề án:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbIDStaff);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(299, 75);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(285, 53);
            this.panel9.TabIndex = 2;
            // 
            // txbIDStaff
            // 
            this.txbIDStaff.Location = new System.Drawing.Point(118, 20);
            this.txbIDStaff.Name = "txbIDStaff";
            this.txbIDStaff.Size = new System.Drawing.Size(157, 22);
            this.txbIDStaff.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhân viên:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(455, 350);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(122, 53);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(315, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 53);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(455, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 53);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAssignmentCOD);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 418);
            this.panel1.TabIndex = 2;
            // 
            // dgvAssignmentCOD
            // 
            this.dgvAssignmentCOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignmentCOD.Location = new System.Drawing.Point(7, 76);
            this.dgvAssignmentCOD.Name = "dgvAssignmentCOD";
            this.dgvAssignmentCOD.RowHeadersWidth = 51;
            this.dgvAssignmentCOD.RowTemplate.Height = 24;
            this.dgvAssignmentCOD.Size = new System.Drawing.Size(365, 338);
            this.dgvAssignmentCOD.TabIndex = 1;
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
            // fAssignmentCOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fAssignmentCOD";
            this.Text = "fAssignmentCOD";
            this.Load += new System.EventHandler(this.fAssignmentCOD_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentCOD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txbDateStart;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbNameProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbNameStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvAssignmentCOD;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txbDateJoin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbIDProject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbIDStaff;
        private System.Windows.Forms.Label label6;
    }
}