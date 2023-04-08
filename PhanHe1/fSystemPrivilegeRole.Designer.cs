namespace PhanHe1
{
    partial class fSystemPrivilegeRole
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
            this.dgvSystemRole = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchSystemrRole = new System.Windows.Forms.Button();
            this.txbUserNameSystemRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemRole)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 284);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSystemRole);
            this.panel3.Location = new System.Drawing.Point(4, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 205);
            this.panel3.TabIndex = 1;
            // 
            // dgvSystemRole
            // 
            this.dgvSystemRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemRole.Location = new System.Drawing.Point(4, 3);
            this.dgvSystemRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSystemRole.Name = "dgvSystemRole";
            this.dgvSystemRole.RowHeadersWidth = 51;
            this.dgvSystemRole.RowTemplate.Height = 24;
            this.dgvSystemRole.Size = new System.Drawing.Size(491, 201);
            this.dgvSystemRole.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchSystemrRole);
            this.panel2.Controls.Add(this.txbUserNameSystemRole);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 70);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSearchSystemrRole
            // 
            this.btnSearchSystemrRole.Location = new System.Drawing.Point(430, 11);
            this.btnSearchSystemrRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchSystemrRole.Name = "btnSearchSystemrRole";
            this.btnSearchSystemrRole.Size = new System.Drawing.Size(45, 48);
            this.btnSearchSystemrRole.TabIndex = 2;
            this.btnSearchSystemrRole.Text = "Tìm";
            this.btnSearchSystemrRole.UseVisualStyleBackColor = true;
            this.btnSearchSystemrRole.Click += new System.EventHandler(this.btnSearchSystemrRole_Click);
            // 
            // txbUserNameSystemRole
            // 
            this.txbUserNameSystemRole.Location = new System.Drawing.Point(119, 26);
            this.txbUserNameSystemRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUserNameSystemRole.Name = "txbUserNameSystemRole";
            this.txbUserNameSystemRole.Size = new System.Drawing.Size(287, 20);
            this.txbUserNameSystemRole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fSystemPrivilegeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 297);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fSystemPrivilegeRole";
            this.Text = "System Privileges của Role";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemRole)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSystemRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchSystemrRole;
        private System.Windows.Forms.TextBox txbUserNameSystemRole;
        private System.Windows.Forms.Label label1;
    }
}