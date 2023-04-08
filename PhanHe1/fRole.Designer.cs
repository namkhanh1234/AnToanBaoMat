namespace PhanHe1
{
    partial class fRole
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
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.btnCancelRole = new System.Windows.Forms.Button();
            this.btnDropRole = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbRoleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateRole);
            this.panel1.Controls.Add(this.btnCancelRole);
            this.panel1.Controls.Add(this.btnDropRole);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 157);
            this.panel1.TabIndex = 2;
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(116, 90);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(135, 49);
            this.btnCreateRole.TabIndex = 4;
            this.btnCreateRole.Text = "Tạo";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // btnCancelRole
            // 
            this.btnCancelRole.Location = new System.Drawing.Point(398, 90);
            this.btnCancelRole.Name = "btnCancelRole";
            this.btnCancelRole.Size = new System.Drawing.Size(135, 49);
            this.btnCancelRole.TabIndex = 3;
            this.btnCancelRole.Text = "Thoát";
            this.btnCancelRole.UseVisualStyleBackColor = true;
            this.btnCancelRole.Click += new System.EventHandler(this.btnCancelRole_Click);
            // 
            // btnDropRole
            // 
            this.btnDropRole.Location = new System.Drawing.Point(257, 90);
            this.btnDropRole.Name = "btnDropRole";
            this.btnDropRole.Size = new System.Drawing.Size(135, 49);
            this.btnDropRole.TabIndex = 2;
            this.btnDropRole.Text = "Xóa";
            this.btnDropRole.UseVisualStyleBackColor = true;
            this.btnDropRole.Click += new System.EventHandler(this.btnDropRole_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbRoleName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 55);
            this.panel2.TabIndex = 0;
            // 
            // txbRoleName
            // 
            this.txbRoleName.Location = new System.Drawing.Point(180, 16);
            this.txbRoleName.Name = "txbRoleName";
            this.txbRoleName.Size = new System.Drawing.Size(344, 22);
            this.txbRoleName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role name:";
            // 
            // fRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 167);
            this.Controls.Add(this.panel1);
            this.Name = "fRole";
            this.Text = "Role";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.Button btnCancelRole;
        private System.Windows.Forms.Button btnDropRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbRoleName;
        private System.Windows.Forms.Label label1;
    }
}