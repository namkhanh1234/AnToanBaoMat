﻿namespace PhanHe1
{
    partial class fGrantPrivileges
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
            this.checkedListBoxGrant = new System.Windows.Forms.CheckedListBox();
            this.comboboxlisuser = new System.Windows.Forms.ComboBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxListTable = new System.Windows.Forms.ComboBox();
            this.lbTableName = new System.Windows.Forms.Label();
            this.listboxColumn = new System.Windows.Forms.CheckedListBox();
            this.checkBoxGrantOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxGrant
            // 
            this.checkedListBoxGrant.CheckOnClick = true;
            this.checkedListBoxGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGrant.FormattingEnabled = true;
            this.checkedListBoxGrant.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.checkedListBoxGrant.Location = new System.Drawing.Point(542, 171);
            this.checkedListBoxGrant.Name = "checkedListBoxGrant";
            this.checkedListBoxGrant.Size = new System.Drawing.Size(121, 108);
            this.checkedListBoxGrant.TabIndex = 1;
            this.checkedListBoxGrant.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // comboboxlisuser
            // 
            this.comboboxlisuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxlisuser.FormattingEnabled = true;
            this.comboboxlisuser.Location = new System.Drawing.Point(109, 31);
            this.comboboxlisuser.Name = "comboboxlisuser";
            this.comboboxlisuser.Size = new System.Drawing.Size(359, 28);
            this.comboboxlisuser.TabIndex = 2;
            this.comboboxlisuser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(23, 34);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(83, 20);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(542, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxListTable
            // 
            this.comboBoxListTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListTable.FormattingEnabled = true;
            this.comboBoxListTable.Location = new System.Drawing.Point(109, 103);
            this.comboBoxListTable.Name = "comboBoxListTable";
            this.comboBoxListTable.Size = new System.Drawing.Size(359, 28);
            this.comboBoxListTable.TabIndex = 6;
            this.comboBoxListTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.Location = new System.Drawing.Point(24, 103);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(48, 20);
            this.lbTableName.TabIndex = 7;
            this.lbTableName.Text = "Table";
            // 
            // listboxColumn
            // 
            this.listboxColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxColumn.FormattingEnabled = true;
            this.listboxColumn.Items.AddRange(new object[] {
            "empty"});
            this.listboxColumn.Location = new System.Drawing.Point(109, 171);
            this.listboxColumn.Name = "listboxColumn";
            this.listboxColumn.Size = new System.Drawing.Size(359, 235);
            this.listboxColumn.TabIndex = 8;
            this.listboxColumn.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // checkBoxGrantOption
            // 
            this.checkBoxGrantOption.AutoSize = true;
            this.checkBoxGrantOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGrantOption.Location = new System.Drawing.Point(542, 301);
            this.checkBoxGrantOption.Name = "checkBoxGrantOption";
            this.checkBoxGrantOption.Size = new System.Drawing.Size(192, 24);
            this.checkBoxGrantOption.TabIndex = 9;
            this.checkBoxGrantOption.Text = "WITH GRANT OPTION";
            this.checkBoxGrantOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Column";
            // 
            // fGrantPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxGrantOption);
            this.Controls.Add(this.listboxColumn);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.comboBoxListTable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.comboboxlisuser);
            this.Controls.Add(this.checkedListBoxGrant);
            this.Name = "fGrantPrivileges";
            this.Text = "Cấp quyền";
            this.Load += new System.EventHandler(this.fGrantPrivileges_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxGrant;
        private System.Windows.Forms.ComboBox comboboxlisuser;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxListTable;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.CheckedListBox listboxColumn;
        private System.Windows.Forms.CheckBox checkBoxGrantOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}