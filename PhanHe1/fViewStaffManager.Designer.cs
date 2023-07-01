namespace PhanHe1
{
    partial class fViewStaffManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvViewStaffManager = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbIdDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbBirthday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStaffManager)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvViewStaffManager);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 365);
            this.panel2.TabIndex = 0;
            // 
            // dgvViewStaffManager
            // 
            this.dgvViewStaffManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStaffManager.Location = new System.Drawing.Point(2, 69);
            this.dgvViewStaffManager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViewStaffManager.Name = "dgvViewStaffManager";
            this.dgvViewStaffManager.RowHeadersWidth = 51;
            this.dgvViewStaffManager.RowTemplate.Height = 24;
            this.dgvViewStaffManager.Size = new System.Drawing.Size(333, 295);
            this.dgvViewStaffManager.TabIndex = 1;
            this.dgvViewStaffManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStaffManager_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 61);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(44, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(2, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 60);
            this.panel5.TabIndex = 0;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(122, 12);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(119, 20);
            this.txbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbName);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(7, 69);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 39);
            this.panel6.TabIndex = 1;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(122, 12);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.ReadOnly = true;
            this.txbPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.txbPhoneNumber.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(341, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 365);
            this.panel3.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txbIdDepartment);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(6, 241);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(246, 39);
            this.panel11.TabIndex = 4;
            // 
            // txbIdDepartment
            // 
            this.txbIdDepartment.Location = new System.Drawing.Point(122, 9);
            this.txbIdDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txbIdDepartment.Name = "txbIdDepartment";
            this.txbIdDepartment.ReadOnly = true;
            this.txbIdDepartment.Size = new System.Drawing.Size(119, 20);
            this.txbIdDepartment.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(2, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã phòng:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbGender);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(6, 197);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(246, 39);
            this.panel10.TabIndex = 3;
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(122, 9);
            this.txbGender.Margin = new System.Windows.Forms.Padding(2);
            this.txbGender.Name = "txbGender";
            this.txbGender.ReadOnly = true;
            this.txbGender.Size = new System.Drawing.Size(119, 20);
            this.txbGender.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(2, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phái:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbAddress);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(6, 286);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(246, 76);
            this.panel9.TabIndex = 3;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(122, 11);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ReadOnly = true;
            this.txbAddress.Size = new System.Drawing.Size(119, 51);
            this.txbAddress.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(2, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbBirthday);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(7, 154);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(246, 39);
            this.panel8.TabIndex = 2;
            // 
            // txbBirthday
            // 
            this.txbBirthday.Location = new System.Drawing.Point(122, 9);
            this.txbBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.txbBirthday.Name = "txbBirthday";
            this.txbBirthday.ReadOnly = true;
            this.txbBirthday.Size = new System.Drawing.Size(119, 20);
            this.txbBirthday.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(2, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbPhoneNumber);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(8, 113);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(246, 36);
            this.panel7.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 367);
            this.panel1.TabIndex = 1;
            // 
            // fViewStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fViewStaffManager";
            this.Text = "Thông tin những nhân viên quản lý";
            this.Load += new System.EventHandler(this.fViewStaffManager_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStaffManager)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvViewStaffManager;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txbIdDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.Label label7;
    }
}