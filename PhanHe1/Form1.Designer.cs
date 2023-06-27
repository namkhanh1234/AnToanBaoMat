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
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuHoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGrantPrivileges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 55);
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
            this.roleToolStripMenuItem,
            this.thuHoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinVềQuyềnToolStripMenuItem
            // 
            this.thôngTinVềQuyềnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quyềnCủaUserToolStripMenuItem,
            this.quyềnCủaRoleToolStripMenuItem});
            this.thôngTinVềQuyềnToolStripMenuItem.Name = "thôngTinVềQuyềnToolStripMenuItem";
            this.thôngTinVềQuyềnToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.thôngTinVềQuyềnToolStripMenuItem.Text = "Thông tin về quyền";
            // 
            // quyềnCủaUserToolStripMenuItem
            // 
            this.quyềnCủaUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectPrivilegesToolStripMenuItem,
            this.systemPrivilegesToolStripMenuItem});
            this.quyềnCủaUserToolStripMenuItem.Name = "quyềnCủaUserToolStripMenuItem";
            this.quyềnCủaUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quyềnCủaUserToolStripMenuItem.Text = "Quyền của user";
            // 
            // objectPrivilegesToolStripMenuItem
            // 
            this.objectPrivilegesToolStripMenuItem.Name = "objectPrivilegesToolStripMenuItem";
            this.objectPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.objectPrivilegesToolStripMenuItem.Text = "Object privileges";
            this.objectPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.objectPrivilegesToolStripMenuItem_Click);
            // 
            // systemPrivilegesToolStripMenuItem
            // 
            this.systemPrivilegesToolStripMenuItem.Name = "systemPrivilegesToolStripMenuItem";
            this.systemPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.systemPrivilegesToolStripMenuItem.Text = "System privileges";
            this.systemPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.systemPrivilegesToolStripMenuItem_Click);
            // 
            // quyềnCủaRoleToolStripMenuItem
            // 
            this.quyềnCủaRoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectPrivilegesToolStripMenuItem1,
            this.systemPrivilegesToolStripMenuItem1});
            this.quyềnCủaRoleToolStripMenuItem.Name = "quyềnCủaRoleToolStripMenuItem";
            this.quyềnCủaRoleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quyềnCủaRoleToolStripMenuItem.Text = "Quyền của role";
            // 
            // objectPrivilegesToolStripMenuItem1
            // 
            this.objectPrivilegesToolStripMenuItem1.Name = "objectPrivilegesToolStripMenuItem1";
            this.objectPrivilegesToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.objectPrivilegesToolStripMenuItem1.Text = "Object privileges";
            this.objectPrivilegesToolStripMenuItem1.Click += new System.EventHandler(this.objectPrivilegesToolStripMenuItem1_Click);
            // 
            // systemPrivilegesToolStripMenuItem1
            // 
            this.systemPrivilegesToolStripMenuItem1.Name = "systemPrivilegesToolStripMenuItem1";
            this.systemPrivilegesToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
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
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // tạoUserToolStripMenuItem
            // 
            this.tạoUserToolStripMenuItem.Name = "tạoUserToolStripMenuItem";
            this.tạoUserToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tạoUserToolStripMenuItem.Text = "Tạo user";
            this.tạoUserToolStripMenuItem.Click += new System.EventHandler(this.tạoUserToolStripMenuItem_Click);
            // 
            // xóaUserToolStripMenuItem
            // 
            this.xóaUserToolStripMenuItem.Name = "xóaUserToolStripMenuItem";
            this.xóaUserToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.xóaUserToolStripMenuItem.Text = "Xóa user";
            this.xóaUserToolStripMenuItem.Click += new System.EventHandler(this.xóaUserToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuUserToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuUserToolStripMenuItem.Name = "thayĐổiMậtKhẩuUserToolStripMenuItem";
            this.thayĐổiMậtKhẩuUserToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.thayĐổiMậtKhẩuUserToolStripMenuItem.Text = "Thay đổi mật khẩu user";
            this.thayĐổiMậtKhẩuUserToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuUserToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // thuHoToolStripMenuItem
            // 
            this.thuHoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem2,
            this.roleToolStripMenuItem1});
            this.thuHoToolStripMenuItem.Name = "thuHoToolStripMenuItem";
            this.thuHoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.thuHoToolStripMenuItem.Text = "Thu hồi quyền";
            // 
            // userToolStripMenuItem2
            // 
            this.userToolStripMenuItem2.Name = "userToolStripMenuItem2";
            this.userToolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.userToolStripMenuItem2.Text = "User";
            this.userToolStripMenuItem2.Click += new System.EventHandler(this.userToolStripMenuItem2_Click);
            // 
            // roleToolStripMenuItem1
            // 
            this.roleToolStripMenuItem1.Name = "roleToolStripMenuItem1";
            this.roleToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.roleToolStripMenuItem1.Text = "Role";
            this.roleToolStripMenuItem1.Click += new System.EventHandler(this.roleToolStripMenuItem1_Click);
            // 
            // btnGrantPrivileges
            // 
            this.btnGrantPrivileges.Location = new System.Drawing.Point(358, 46);
            this.btnGrantPrivileges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrantPrivileges.Name = "btnGrantPrivileges";
            this.btnGrantPrivileges.Size = new System.Drawing.Size(138, 57);
            this.btnGrantPrivileges.TabIndex = 3;
            this.btnGrantPrivileges.Text = "Cấp quyền";
            this.btnGrantPrivileges.UseVisualStyleBackColor = true;
            this.btnGrantPrivileges.Click += new System.EventHandler(this.btnGrantPrivileges_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Người dùng: Quản trị viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnManageKey
            // 
            this.btnManageKey.Location = new System.Drawing.Point(653, 46);
            this.btnManageKey.Name = "btnManageKey";
            this.btnManageKey.Size = new System.Drawing.Size(120, 56);
            this.btnManageKey.TabIndex = 5;
            this.btnManageKey.Text = "Quản lý mã hoá";
            this.btnManageKey.UseVisualStyleBackColor = true;
            this.btnManageKey.Click += new System.EventHandler(this.btnManageKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 478);
            this.Controls.Add(this.btnManageKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrantPrivileges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem thuHoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageKey;
    }
}

