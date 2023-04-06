namespace PhanHe1
{
    partial class fObjectPrivilegeRole
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvObjectRole = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchObjectRole = new System.Windows.Forms.Button();
            this.txbUserNameObjectRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectRole)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 350);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvObjectRole);
            this.panel3.Location = new System.Drawing.Point(6, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 252);
            this.panel3.TabIndex = 1;
            // 
            // dgvObjectRole
            // 
            this.dgvObjectRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectRole.Location = new System.Drawing.Point(6, 4);
            this.dgvObjectRole.Name = "dgvObjectRole";
            this.dgvObjectRole.RowHeadersWidth = 51;
            this.dgvObjectRole.RowTemplate.Height = 24;
            this.dgvObjectRole.Size = new System.Drawing.Size(655, 247);
            this.dgvObjectRole.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchObjectRole);
            this.panel2.Controls.Add(this.txbUserNameObjectRole);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 86);
            this.panel2.TabIndex = 0;
            // 
            // btnSearchObjectRole
            // 
            this.btnSearchObjectRole.Location = new System.Drawing.Point(574, 14);
            this.btnSearchObjectRole.Name = "btnSearchObjectRole";
            this.btnSearchObjectRole.Size = new System.Drawing.Size(60, 59);
            this.btnSearchObjectRole.TabIndex = 2;
            this.btnSearchObjectRole.Text = "Tìm";
            this.btnSearchObjectRole.UseVisualStyleBackColor = true;
            this.btnSearchObjectRole.Click += new System.EventHandler(this.btnSearchObjectRole_Click);
            // 
            // txbUserNameObjectRole
            // 
            this.txbUserNameObjectRole.Location = new System.Drawing.Point(159, 32);
            this.txbUserNameObjectRole.Name = "txbUserNameObjectRole";
            this.txbUserNameObjectRole.Size = new System.Drawing.Size(381, 22);
            this.txbUserNameObjectRole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role name:";
            // 
            // fObjectPrivilegeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 371);
            this.Controls.Add(this.panel1);
            this.Name = "fObjectPrivilegeRole";
            this.Text = "Object Privilege của Role";
            this.Load += new System.EventHandler(this.fObjectPrivilegeRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectRole)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvObjectRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchObjectRole;
        private System.Windows.Forms.TextBox txbUserNameObjectRole;
        private System.Windows.Forms.Label label1;
    }
}