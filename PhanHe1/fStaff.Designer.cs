namespace PhanHe1
{
    partial class fStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewProject = new System.Windows.Forms.Button();
            this.btnViewDepartment = new System.Windows.Forms.Button();
            this.btnViewAssignment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhữngĐềÁnThamGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Người dùng: Nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 156);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnViewProject);
            this.panel3.Controls.Add(this.btnViewDepartment);
            this.panel3.Controls.Add(this.btnViewAssignment);
            this.panel3.Location = new System.Drawing.Point(384, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 142);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnViewProject
            // 
            this.btnViewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnViewProject.Location = new System.Drawing.Point(281, 62);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(123, 60);
            this.btnViewProject.TabIndex = 4;
            this.btnViewProject.Text = "Xem thông tin đề án";
            this.btnViewProject.UseVisualStyleBackColor = true;
            this.btnViewProject.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnViewDepartment
            // 
            this.btnViewDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnViewDepartment.Location = new System.Drawing.Point(142, 62);
            this.btnViewDepartment.Name = "btnViewDepartment";
            this.btnViewDepartment.Size = new System.Drawing.Size(123, 60);
            this.btnViewDepartment.TabIndex = 3;
            this.btnViewDepartment.Text = "Xem thông tin phòng ban";
            this.btnViewDepartment.UseVisualStyleBackColor = true;
            // 
            // btnViewAssignment
            // 
            this.btnViewAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnViewAssignment.Location = new System.Drawing.Point(13, 62);
            this.btnViewAssignment.Name = "btnViewAssignment";
            this.btnViewAssignment.Size = new System.Drawing.Size(123, 60);
            this.btnViewAssignment.TabIndex = 1;
            this.btnViewAssignment.Text = "Xem phân công";
            this.btnViewAssignment.UseVisualStyleBackColor = true;
            this.btnViewAssignment.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.nhữngĐềÁnThamGiaToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
            // 
            // nhữngĐềÁnThamGiaToolStripMenuItem
            // 
            this.nhữngĐềÁnThamGiaToolStripMenuItem.Name = "nhữngĐềÁnThamGiaToolStripMenuItem";
            this.nhữngĐềÁnThamGiaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.nhữngĐềÁnThamGiaToolStripMenuItem.Text = "Những đề án tham gia";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStaff);
            this.panel2.Location = new System.Drawing.Point(3, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 274);
            this.panel2.TabIndex = 7;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(5, 0);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(794, 274);
            this.dgvStaff.TabIndex = 0;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fStaff";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.fStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewProject;
        private System.Windows.Forms.Button btnViewDepartment;
        private System.Windows.Forms.Button btnViewAssignment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhữngĐềÁnThamGiaToolStripMenuItem;
    }
}