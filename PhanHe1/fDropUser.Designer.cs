namespace PhanHe1
{
    partial class fDropUser
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
            this.btnCancelDrop = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUserNameDrop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelDrop);
            this.panel1.Controls.Add(this.btnDrop);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 157);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelDrop
            // 
            this.btnCancelDrop.Location = new System.Drawing.Point(398, 90);
            this.btnCancelDrop.Name = "btnCancelDrop";
            this.btnCancelDrop.Size = new System.Drawing.Size(135, 49);
            this.btnCancelDrop.TabIndex = 3;
            this.btnCancelDrop.Text = "Thoát";
            this.btnCancelDrop.UseVisualStyleBackColor = true;
            this.btnCancelDrop.Click += new System.EventHandler(this.btnCancelDrop_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Location = new System.Drawing.Point(257, 90);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(135, 49);
            this.btnDrop.TabIndex = 2;
            this.btnDrop.Text = "Xóa";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUserNameDrop);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 55);
            this.panel2.TabIndex = 0;
            // 
            // txbUserNameDrop
            // 
            this.txbUserNameDrop.Location = new System.Drawing.Point(180, 16);
            this.txbUserNameDrop.Name = "txbUserNameDrop";
            this.txbUserNameDrop.Size = new System.Drawing.Size(344, 22);
            this.txbUserNameDrop.TabIndex = 1;
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
            // fDropUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 159);
            this.Controls.Add(this.panel1);
            this.Name = "fDropUser";
            this.Text = "fDropUser";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelDrop;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUserNameDrop;
        private System.Windows.Forms.Label label1;
    }
}