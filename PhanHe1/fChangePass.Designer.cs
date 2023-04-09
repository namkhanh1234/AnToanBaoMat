namespace PhanHe1
{
    partial class fChangePass
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
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassWordChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUserNameChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelChange);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 231);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelChange
            // 
            this.btnCancelChange.Location = new System.Drawing.Point(418, 159);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(135, 49);
            this.btnCancelChange.TabIndex = 3;
            this.btnCancelChange.Text = "Thoát";
            this.btnCancelChange.UseVisualStyleBackColor = true;
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelChange_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(277, 159);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 49);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Thay đổi";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassWordChange);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(9, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 55);
            this.panel3.TabIndex = 1;
            // 
            // txbPassWordChange
            // 
            this.txbPassWordChange.Location = new System.Drawing.Point(180, 16);
            this.txbPassWordChange.Name = "txbPassWordChange";
            this.txbPassWordChange.Size = new System.Drawing.Size(344, 22);
            this.txbPassWordChange.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUserNameChange);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 55);
            this.panel2.TabIndex = 0;
            // 
            // txbUserNameChange
            // 
            this.txbUserNameChange.Location = new System.Drawing.Point(180, 16);
            this.txbUserNameChange.Name = "txbUserNameChange";
            this.txbUserNameChange.Size = new System.Drawing.Size(344, 22);
            this.txbUserNameChange.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // fChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 247);
            this.Controls.Add(this.panel1);
            this.Name = "fChangePass";
            this.Text = "Thay đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelChange;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassWordChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUserNameChange;
        private System.Windows.Forms.Label label1;
    }
}