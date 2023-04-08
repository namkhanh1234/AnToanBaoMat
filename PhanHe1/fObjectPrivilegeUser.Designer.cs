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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvObjectUser = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchObjectUser = new System.Windows.Forms.Button();
            this.txbUserNameObjectUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectUser)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvObjectUser);
            this.panel3.Location = new System.Drawing.Point(4, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 205);
            this.panel3.TabIndex = 1;
            // 
            // dgvObjectUser
            // 
            this.dgvObjectUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectUser.Location = new System.Drawing.Point(4, 3);
            this.dgvObjectUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvObjectUser.Name = "dgvObjectUser";
            this.dgvObjectUser.RowHeadersWidth = 51;
            this.dgvObjectUser.RowTemplate.Height = 24;
            this.dgvObjectUser.Size = new System.Drawing.Size(491, 201);
            this.dgvObjectUser.TabIndex = 0;
            this.dgvObjectUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjectUser_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchObjectUser);
            this.panel2.Controls.Add(this.txbUserNameObjectUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 70);
            this.panel2.TabIndex = 0;
            // 
            // btnSearchObjectUser
            // 
            this.btnSearchObjectUser.Location = new System.Drawing.Point(430, 11);
            this.btnSearchObjectUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchObjectUser.Name = "btnSearchObjectUser";
            this.btnSearchObjectUser.Size = new System.Drawing.Size(45, 48);
            this.btnSearchObjectUser.TabIndex = 2;
            this.btnSearchObjectUser.Text = "Tìm";
            this.btnSearchObjectUser.UseVisualStyleBackColor = true;
            this.btnSearchObjectUser.Click += new System.EventHandler(this.btnSearchObjectUser_Click);
            // 
            // txbUserNameObjectUser
            // 
            this.txbUserNameObjectUser.Location = new System.Drawing.Point(119, 26);
            this.txbUserNameObjectUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUserNameObjectUser.Name = "txbUserNameObjectUser";
            this.txbUserNameObjectUser.Size = new System.Drawing.Size(287, 20);
            this.txbUserNameObjectUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // fObjectPrivilegeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 304);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fObjectPrivilegeUser";
            this.Text = "Object Privileges của User";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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