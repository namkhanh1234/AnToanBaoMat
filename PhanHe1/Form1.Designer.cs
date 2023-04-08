namespace PhanHe1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinVềQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyềnCủaUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyềnCủaRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectPrivilegesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPrivilegesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGrantPrivileges = new System.Windows.Forms.Button();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xem danh sách người dùng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinVềQuyềnToolStripMenuItem,
            this.userToolStripMenuItem,
            this.roleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinVềQuyềnToolStripMenuItem
            // 
            this.thôngTinVềQuyềnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quyềnCủaUserToolStripMenuItem,
            this.quyềnCủaRoleToolStripMenuItem});
            this.thôngTinVềQuyềnToolStripMenuItem.Name = "thôngTinVềQuyềnToolStripMenuItem";
            this.thôngTinVềQuyềnToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.thôngTinVềQuyềnToolStripMenuItem.Text = "Thông tin về quyền";
            // 
            // quyềnCủaUserToolStripMenuItem
            // 
            this.quyềnCủaUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectPrivilegesToolStripMenuItem,
            this.systemPrivilegesToolStripMenuItem});
            this.quyềnCủaUserToolStripMenuItem.Name = "quyềnCủaUserToolStripMenuItem";
            this.quyềnCủaUserToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.quyềnCủaUserToolStripMenuItem.Text = "Quyền của user";
            // 
            // objectPrivilegesToolStripMenuItem
            // 
            this.objectPrivilegesToolStripMenuItem.Name = "objectPrivilegesToolStripMenuItem";
            this.objectPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.objectPrivilegesToolStripMenuItem.Text = "Object privileges";
            this.objectPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.objectPrivilegesToolStripMenuItem_Click);
            // 
            // systemPrivilegesToolStripMenuItem
            // 
            this.systemPrivilegesToolStripMenuItem.Name = "systemPrivilegesToolStripMenuItem";
            this.systemPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.systemPrivilegesToolStripMenuItem.Text = "System privileges";
            this.systemPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.systemPrivilegesToolStripMenuItem_Click);
            // 
            // quyềnCủaRoleToolStripMenuItem
            // 
            this.quyềnCủaRoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectPrivilegesToolStripMenuItem1,
            this.systemPrivilegesToolStripMenuItem1});
            this.quyềnCủaRoleToolStripMenuItem.Name = "quyềnCủaRoleToolStripMenuItem";
            this.quyềnCủaRoleToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.quyềnCủaRoleToolStripMenuItem.Text = "Quyền của role";
            // 
            // objectPrivilegesToolStripMenuItem1
            // 
            this.objectPrivilegesToolStripMenuItem1.Name = "objectPrivilegesToolStripMenuItem1";
            this.objectPrivilegesToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.objectPrivilegesToolStripMenuItem1.Text = "Object privileges";
            this.objectPrivilegesToolStripMenuItem1.Click += new System.EventHandler(this.objectPrivilegesToolStripMenuItem1_Click);
            // 
            // systemPrivilegesToolStripMenuItem1
            // 
            this.systemPrivilegesToolStripMenuItem1.Name = "systemPrivilegesToolStripMenuItem1";
            this.systemPrivilegesToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.systemPrivilegesToolStripMenuItem1.Text = "System privileges";
            this.systemPrivilegesToolStripMenuItem1.Click += new System.EventHandler(this.systemPrivilegesToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoUserToolStripMenuItem,
            this.xóaUserToolStripMenuItem,
            this.thayĐổiMậtKhẩuUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // tạoUserToolStripMenuItem
            // 
            this.tạoUserToolStripMenuItem.Name = "tạoUserToolStripMenuItem";
            this.tạoUserToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.tạoUserToolStripMenuItem.Text = "Tạo user";
            this.tạoUserToolStripMenuItem.Click += new System.EventHandler(this.tạoUserToolStripMenuItem_Click);
            // 
            // xóaUserToolStripMenuItem
            // 
            this.xóaUserToolStripMenuItem.Name = "xóaUserToolStripMenuItem";
            this.xóaUserToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.xóaUserToolStripMenuItem.Text = "Xóa user";
            this.xóaUserToolStripMenuItem.Click += new System.EventHandler(this.xóaUserToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuUserToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuUserToolStripMenuItem.Name = "thayĐổiMậtKhẩuUserToolStripMenuItem";
            this.thayĐổiMậtKhẩuUserToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.thayĐổiMậtKhẩuUserToolStripMenuItem.Text = "Thay đổi mật khẩu user";
            // 
            // btnGrantPrivileges
            // 
            this.btnGrantPrivileges.Location = new System.Drawing.Point(202, 77);
            this.btnGrantPrivileges.Name = "btnGrantPrivileges";
            this.btnGrantPrivileges.Size = new System.Drawing.Size(184, 52);
            this.btnGrantPrivileges.TabIndex = 3;
            this.btnGrantPrivileges.Text = "Cấp quyền";
            this.btnGrantPrivileges.UseVisualStyleBackColor = true;
            this.btnGrantPrivileges.Click += new System.EventHandler(this.btnGrantPrivileges_Click_1);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 490);
            this.Controls.Add(this.btnGrantPrivileges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinVềQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyềnCủaUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyềnCủaRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectPrivilegesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem systemPrivilegesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuUserToolStripMenuItem;
        private System.Windows.Forms.Button btnGrantPrivileges;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
    }
}

