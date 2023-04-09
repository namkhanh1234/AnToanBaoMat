namespace PhanHe1
{
    partial class fRevokeRole
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
            this.btnSystemRole = new System.Windows.Forms.Button();
            this.btnObjectRole = new System.Windows.Forms.Button();
            this.btnCancleRevokeRole = new System.Windows.Forms.Button();
            this.btnRevokeRole = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbPrivilegesRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTableRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbUserNameRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSystemRole);
            this.panel1.Controls.Add(this.btnObjectRole);
            this.panel1.Controls.Add(this.btnCancleRevokeRole);
            this.panel1.Controls.Add(this.btnRevokeRole);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 370);
            this.panel1.TabIndex = 1;
            // 
            // btnSystemRole
            // 
            this.btnSystemRole.Location = new System.Drawing.Point(572, 136);
            this.btnSystemRole.Name = "btnSystemRole";
            this.btnSystemRole.Size = new System.Drawing.Size(113, 51);
            this.btnSystemRole.TabIndex = 6;
            this.btnSystemRole.Text = "System";
            this.btnSystemRole.UseVisualStyleBackColor = true;
            this.btnSystemRole.Click += new System.EventHandler(this.btnSystemRole_Click);
            // 
            // btnObjectRole
            // 
            this.btnObjectRole.Location = new System.Drawing.Point(572, 60);
            this.btnObjectRole.Name = "btnObjectRole";
            this.btnObjectRole.Size = new System.Drawing.Size(113, 51);
            this.btnObjectRole.TabIndex = 5;
            this.btnObjectRole.Text = "Object";
            this.btnObjectRole.UseVisualStyleBackColor = true;
            this.btnObjectRole.Click += new System.EventHandler(this.btnObjectRole_Click);
            // 
            // btnCancleRevokeRole
            // 
            this.btnCancleRevokeRole.Location = new System.Drawing.Point(540, 302);
            this.btnCancleRevokeRole.Name = "btnCancleRevokeRole";
            this.btnCancleRevokeRole.Size = new System.Drawing.Size(124, 51);
            this.btnCancleRevokeRole.TabIndex = 4;
            this.btnCancleRevokeRole.Text = "Thoát";
            this.btnCancleRevokeRole.UseVisualStyleBackColor = true;
            this.btnCancleRevokeRole.Click += new System.EventHandler(this.btnCancleRevokeRole_Click);
            // 
            // btnRevokeRole
            // 
            this.btnRevokeRole.Location = new System.Drawing.Point(387, 302);
            this.btnRevokeRole.Name = "btnRevokeRole";
            this.btnRevokeRole.Size = new System.Drawing.Size(124, 51);
            this.btnRevokeRole.TabIndex = 3;
            this.btnRevokeRole.Text = "Thu hồi";
            this.btnRevokeRole.UseVisualStyleBackColor = true;
            this.btnRevokeRole.Click += new System.EventHandler(this.btnRevokeRole_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbPrivilegesRole);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(9, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 79);
            this.panel4.TabIndex = 2;
            // 
            // cbPrivilegesRole
            // 
            this.cbPrivilegesRole.FormattingEnabled = true;
            this.cbPrivilegesRole.Location = new System.Drawing.Point(185, 29);
            this.cbPrivilegesRole.Name = "cbPrivilegesRole";
            this.cbPrivilegesRole.Size = new System.Drawing.Size(300, 24);
            this.cbPrivilegesRole.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quyền:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbTableRole);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(9, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 79);
            this.panel3.TabIndex = 1;
            // 
            // cbTableRole
            // 
            this.cbTableRole.FormattingEnabled = true;
            this.cbTableRole.Location = new System.Drawing.Point(185, 29);
            this.cbTableRole.Name = "cbTableRole";
            this.cbTableRole.Size = new System.Drawing.Size(300, 24);
            this.cbTableRole.TabIndex = 1;
            this.cbTableRole.SelectedIndexChanged += new System.EventHandler(this.cbTableRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bảng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbUserNameRole);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 79);
            this.panel2.TabIndex = 0;
            // 
            // cbUserNameRole
            // 
            this.cbUserNameRole.FormattingEnabled = true;
            this.cbUserNameRole.Location = new System.Drawing.Point(185, 30);
            this.cbUserNameRole.Name = "cbUserNameRole";
            this.cbUserNameRole.Size = new System.Drawing.Size(300, 24);
            this.cbUserNameRole.TabIndex = 1;
            this.cbUserNameRole.SelectedIndexChanged += new System.EventHandler(this.cbUserNameRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rolename:";
            // 
            // fRevokeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 376);
            this.Controls.Add(this.panel1);
            this.Name = "fRevokeRole";
            this.Text = "fRevokeRole";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSystemRole;
        private System.Windows.Forms.Button btnObjectRole;
        private System.Windows.Forms.Button btnCancleRevokeRole;
        private System.Windows.Forms.Button btnRevokeRole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPrivilegesRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTableRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbUserNameRole;
        private System.Windows.Forms.Label label1;
    }
}