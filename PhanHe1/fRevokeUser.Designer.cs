namespace PhanHe1
{
    partial class fRevokeUser
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
            this.btnCancleRevoke = new System.Windows.Forms.Button();
            this.btnRevokeUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbPrivileges = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObject = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSystem);
            this.panel1.Controls.Add(this.btnObject);
            this.panel1.Controls.Add(this.btnCancleRevoke);
            this.panel1.Controls.Add(this.btnRevokeUser);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 370);
            this.panel1.TabIndex = 0;
            // 
            // btnCancleRevoke
            // 
            this.btnCancleRevoke.Location = new System.Drawing.Point(540, 302);
            this.btnCancleRevoke.Name = "btnCancleRevoke";
            this.btnCancleRevoke.Size = new System.Drawing.Size(124, 51);
            this.btnCancleRevoke.TabIndex = 4;
            this.btnCancleRevoke.Text = "Thoát";
            this.btnCancleRevoke.UseVisualStyleBackColor = true;
            this.btnCancleRevoke.Click += new System.EventHandler(this.btnCancleRevoke_Click);
            // 
            // btnRevokeUser
            // 
            this.btnRevokeUser.Location = new System.Drawing.Point(387, 302);
            this.btnRevokeUser.Name = "btnRevokeUser";
            this.btnRevokeUser.Size = new System.Drawing.Size(124, 51);
            this.btnRevokeUser.TabIndex = 3;
            this.btnRevokeUser.Text = "Thu hồi";
            this.btnRevokeUser.UseVisualStyleBackColor = true;
            this.btnRevokeUser.Click += new System.EventHandler(this.btnRevokeUser_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbPrivileges);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(9, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 79);
            this.panel4.TabIndex = 2;
            // 
            // cbPrivileges
            // 
            this.cbPrivileges.FormattingEnabled = true;
            this.cbPrivileges.Location = new System.Drawing.Point(185, 29);
            this.cbPrivileges.Name = "cbPrivileges";
            this.cbPrivileges.Size = new System.Drawing.Size(300, 24);
            this.cbPrivileges.TabIndex = 1;
            this.cbPrivileges.SelectedIndexChanged += new System.EventHandler(this.cbPrivileges_SelectedIndexChanged);
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
            this.panel3.Controls.Add(this.cbTable);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(9, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 79);
            this.panel3.TabIndex = 1;
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(185, 29);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(300, 24);
            this.cbTable.TabIndex = 1;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
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
            this.panel2.Controls.Add(this.cbUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 79);
            this.panel2.TabIndex = 0;
            // 
            // cbUserName
            // 
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(185, 30);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(300, 24);
            this.cbUserName.TabIndex = 1;
            this.cbUserName.SelectedIndexChanged += new System.EventHandler(this.cbUserName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnObject
            // 
            this.btnObject.Location = new System.Drawing.Point(572, 60);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(113, 51);
            this.btnObject.TabIndex = 5;
            this.btnObject.Text = "Object";
            this.btnObject.UseVisualStyleBackColor = true;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Location = new System.Drawing.Point(572, 136);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(113, 51);
            this.btnSystem.TabIndex = 6;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // fRevokeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 378);
            this.Controls.Add(this.panel1);
            this.Name = "fRevokeUser";
            this.Text = "Thu hồi quyền";
            this.Load += new System.EventHandler(this.fRevokeUser_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPrivileges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancleRevoke;
        private System.Windows.Forms.Button btnRevokeUser;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnObject;
    }
}