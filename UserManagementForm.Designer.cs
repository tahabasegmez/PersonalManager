namespace OOP_PROJE
{
    partial class UserManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearch = new System.Windows.Forms.Label();
            this.LblUserType = new System.Windows.Forms.Label();
            this.cmbUsertype = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSendPassword = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(838, 88);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 70;
            this.lblSearch.Text = "Search:";
            // 
            // LblUserType
            // 
            this.LblUserType.AutoSize = true;
            this.LblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUserType.Location = new System.Drawing.Point(817, 127);
            this.LblUserType.Name = "LblUserType";
            this.LblUserType.Size = new System.Drawing.Size(102, 24);
            this.LblUserType.TabIndex = 66;
            this.LblUserType.Text = "User Type:";
            // 
            // cmbUsertype
            // 
            this.cmbUsertype.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbUsertype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsertype.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbUsertype.FormattingEnabled = true;
            this.cmbUsertype.Location = new System.Drawing.Point(901, 127);
            this.cmbUsertype.Name = "cmbUsertype";
            this.cmbUsertype.Size = new System.Drawing.Size(121, 32);
            this.cmbUsertype.TabIndex = 78;
            this.cmbUsertype.SelectedIndexChanged += new System.EventHandler(this.cmbUsertype_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AllowDrop = true;
            this.txtSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearch.Location = new System.Drawing.Point(901, 88);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 32);
            this.txtSearch.TabIndex = 606;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtRegisterNo_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_close_48__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(1070, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 605;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_minimize_48;
            this.btnMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimized.Location = new System.Drawing.Point(1040, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 604;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            this.btnMinimized.MouseHover += new System.EventHandler(this.btnMinimized_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_delete_48;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDelete.Location = new System.Drawing.Point(972, 254);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 603;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_refresh;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdate.Location = new System.Drawing.Point(972, 178);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 50);
            this.btnUpdate.TabIndex = 602;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnList.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_list_48;
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnList.Location = new System.Drawing.Point(901, 178);
            this.btnList.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(50, 50);
            this.btnList.TabIndex = 601;
            this.btnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSendPassword
            // 
            this.btnSendPassword.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_password_reset_48;
            this.btnSendPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSendPassword.Location = new System.Drawing.Point(902, 254);
            this.btnSendPassword.Name = "btnSendPassword";
            this.btnSendPassword.Size = new System.Drawing.Size(50, 50);
            this.btnSendPassword.TabIndex = 79;
            this.btnSendPassword.UseVisualStyleBackColor = true;
            this.btnSendPassword.Click += new System.EventHandler(this.btnSendPassword_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(478, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(225, 29);
            this.lblHeader.TabIndex = 607;
            this.lblHeader.Text = "User Management";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_left_48;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 608;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvUsers.Location = new System.Drawing.Point(30, 30);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.Size = new System.Drawing.Size(750, 350);
            this.dgvUsers.TabIndex = 609;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(786, 376);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 610;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1100, 400);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSendPassword);
            this.Controls.Add(this.cmbUsertype);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.LblUserType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label LblUserType;
        private System.Windows.Forms.ComboBox cmbUsertype;
        private System.Windows.Forms.Button btnSendPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblError;
    }
}