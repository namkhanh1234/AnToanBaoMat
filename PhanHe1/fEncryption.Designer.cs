namespace PhanHe1
{
    partial class fEncryption
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
            this.listKey = new System.Windows.Forms.DataGridView();
            this.btnShowAllKey = new System.Windows.Forms.Button();
            this.btnCurrentKey = new System.Windows.Forms.Button();
            this.btnChangeKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listKey)).BeginInit();
            this.SuspendLayout();
            // 
            // listKey
            // 
            this.listKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listKey.Location = new System.Drawing.Point(34, 105);
            this.listKey.Name = "listKey";
            this.listKey.Size = new System.Drawing.Size(837, 340);
            this.listKey.TabIndex = 0;
            this.listKey.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listKey_CellContentClick);
            // 
            // btnShowAllKey
            // 
            this.btnShowAllKey.Location = new System.Drawing.Point(899, 86);
            this.btnShowAllKey.Name = "btnShowAllKey";
            this.btnShowAllKey.Size = new System.Drawing.Size(141, 54);
            this.btnShowAllKey.TabIndex = 1;
            this.btnShowAllKey.Text = "Xem danh sách khoá";
            this.btnShowAllKey.UseVisualStyleBackColor = true;
            this.btnShowAllKey.Click += new System.EventHandler(this.btnShowAllKey_Click);
            // 
            // btnCurrentKey
            // 
            this.btnCurrentKey.Location = new System.Drawing.Point(899, 173);
            this.btnCurrentKey.Name = "btnCurrentKey";
            this.btnCurrentKey.Size = new System.Drawing.Size(141, 50);
            this.btnCurrentKey.TabIndex = 2;
            this.btnCurrentKey.Text = "Xem khoá hiện tại";
            this.btnCurrentKey.UseVisualStyleBackColor = true;
            this.btnCurrentKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeKey
            // 
            this.btnChangeKey.Location = new System.Drawing.Point(899, 256);
            this.btnChangeKey.Name = "btnChangeKey";
            this.btnChangeKey.Size = new System.Drawing.Size(141, 57);
            this.btnChangeKey.TabIndex = 3;
            this.btnChangeKey.Text = "Đổi khoá";
            this.btnChangeKey.UseVisualStyleBackColor = true;
            this.btnChangeKey.Click += new System.EventHandler(this.btnChangeKey_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách khoá mã hoá";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeKey);
            this.Controls.Add(this.btnCurrentKey);
            this.Controls.Add(this.btnShowAllKey);
            this.Controls.Add(this.listKey);
            this.Name = "fEncryption";
            this.Text = "Quản lý mã hoá";
            this.Load += new System.EventHandler(this.fEncryption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listKey;
        private System.Windows.Forms.Button btnShowAllKey;
        private System.Windows.Forms.Button btnCurrentKey;
        private System.Windows.Forms.Button btnChangeKey;
        private System.Windows.Forms.Label label1;
    }
}