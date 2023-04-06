namespace PhanHe1
{
    partial class fObjectPrivilegeUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserNameObjectUser = new System.Windows.Forms.TextBox();
            this.btnSearchObjectUser = new System.Windows.Forms.Button();
            this.dgvObjectUser = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 350);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchObjectUser);
            this.panel2.Controls.Add(this.txbUserNameObjectUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 86);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvObjectUser);
            this.panel3.Location = new System.Drawing.Point(6, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 252);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // txbUserNameObjectUser
            // 
            this.txbUserNameObjectUser.Location = new System.Drawing.Point(159, 32);
            this.txbUserNameObjectUser.Name = "txbUserNameObjectUser";
            this.txbUserNameObjectUser.Size = new System.Drawing.Size(381, 22);
            this.txbUserNameObjectUser.TabIndex = 1;
            // 
            // btnSearchObjectUser
            // 
            this.btnSearchObjectUser.Location = new System.Drawing.Point(574, 14);
            this.btnSearchObjectUser.Name = "btnSearchObjectUser";
            this.btnSearchObjectUser.Size = new System.Drawing.Size(60, 59);
            this.btnSearchObjectUser.TabIndex = 2;
            this.btnSearchObjectUser.Text = "Tìm";
            this.btnSearchObjectUser.UseVisualStyleBackColor = true;
            this.btnSearchObjectUser.Click += new System.EventHandler(this.btnSearchObjectUser_Click);
            // 
            // dgvObjectUser
            // 
            this.dgvObjectUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectUser.Location = new System.Drawing.Point(6, 4);
            this.dgvObjectUser.Name = "dgvObjectUser";
            this.dgvObjectUser.RowHeadersWidth = 51;
            this.dgvObjectUser.RowTemplate.Height = 24;
            this.dgvObjectUser.Size = new System.Drawing.Size(655, 247);
            this.dgvObjectUser.TabIndex = 0;
            // 
            // fObjectPrivilegeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 374);
            this.Controls.Add(this.panel1);
            this.Name = "fObjectPrivilegeUser";
            this.Text = "Object Privileges của User";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvObjectUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchObjectUser;
        private System.Windows.Forms.TextBox txbUserNameObjectUser;
        private System.Windows.Forms.Label label1;
    }
}