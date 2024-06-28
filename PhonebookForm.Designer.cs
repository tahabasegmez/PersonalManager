namespace OOP_PROJE
{
    partial class PhonebookForm
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
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MTxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvPhone = new System.Windows.Forms.DataGridView();
            this.btnAddRecord = new System.Windows.Forms.Label();
            this.btnContacts = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDescription
            // 
            this.TxtDescription.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDescription.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtDescription.Location = new System.Drawing.Point(133, 313);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(267, 31);
            this.TxtDescription.TabIndex = 61;
            this.TxtDescription.Visible = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtEmail.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtEmail.Location = new System.Drawing.Point(133, 356);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(267, 31);
            this.TxtEmail.TabIndex = 62;
            this.TxtEmail.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtName.Location = new System.Drawing.Point(136, 67);
            this.TxtName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(267, 31);
            this.TxtName.TabIndex = 57;
            this.TxtName.Visible = false;
            // 
            // MTxtNumber
            // 
            this.MTxtNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MTxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTxtNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.MTxtNumber.Location = new System.Drawing.Point(136, 152);
            this.MTxtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MTxtNumber.Mask = "(999) 000-0000";
            this.MTxtNumber.Name = "MTxtNumber";
            this.MTxtNumber.Size = new System.Drawing.Size(264, 29);
            this.MTxtNumber.TabIndex = 59;
            this.MTxtNumber.Visible = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(76, 72);
            this.LblName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(52, 18);
            this.LblName.TabIndex = 69;
            this.LblName.Text = "Name:";
            this.LblName.Visible = false;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.Location = new System.Drawing.Point(71, 361);
            this.LblMail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(54, 18);
            this.LblMail.TabIndex = 68;
            this.LblMail.Text = "E-Mail:";
            this.LblMail.Visible = false;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDescription.Location = new System.Drawing.Point(35, 318);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(87, 18);
            this.LblDescription.TabIndex = 67;
            this.LblDescription.Text = "Description:";
            this.LblDescription.Visible = false;
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtAddress.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtAddress.Location = new System.Drawing.Point(133, 192);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(267, 109);
            this.TxtAddress.TabIndex = 60;
            this.TxtAddress.Visible = false;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAddress.Location = new System.Drawing.Point(55, 228);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(66, 18);
            this.LblAddress.TabIndex = 66;
            this.LblAddress.Text = "Address:";
            this.LblAddress.Visible = false;
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNumber.Location = new System.Drawing.Point(11, 158);
            this.LblNumber.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(112, 18);
            this.LblNumber.TabIndex = 65;
            this.LblNumber.Text = "Phone Number:";
            this.LblNumber.Visible = false;
            // 
            // TxtSurname
            // 
            this.TxtSurname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtSurname.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtSurname.Location = new System.Drawing.Point(136, 110);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(267, 31);
            this.TxtSurname.TabIndex = 58;
            this.TxtSurname.Visible = false;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.Location = new System.Drawing.Point(53, 115);
            this.LblSurname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(72, 18);
            this.LblSurname.TabIndex = 64;
            this.LblSurname.Text = "Surname:";
            this.LblSurname.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_close_48__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(430, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 602;
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
            this.btnMinimized.Location = new System.Drawing.Point(400, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 601;
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
            this.btnDelete.Location = new System.Drawing.Point(205, 425);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 600;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_add_list_48;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(205, 425);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 599;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_refresh;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdate.Location = new System.Drawing.Point(265, 425);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 50);
            this.btnUpdate.TabIndex = 598;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnBack.TabIndex = 80;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(177, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(124, 24);
            this.lblHeader.TabIndex = 603;
            this.lblHeader.Text = "Phone Book";
            // 
            // dgvPhone
            // 
            this.dgvPhone.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhone.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvPhone.Location = new System.Drawing.Point(14, 108);
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            this.dgvPhone.RowHeadersWidth = 51;
            this.dgvPhone.Size = new System.Drawing.Size(401, 309);
            this.dgvPhone.TabIndex = 604;
            this.dgvPhone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhone_CellClick);
            this.dgvPhone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhone_CellContentClick);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.AutoSize = true;
            this.btnAddRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRecord.Location = new System.Drawing.Point(109, 30);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(36, 18);
            this.btnAddRecord.TabIndex = 605;
            this.btnAddRecord.Text = "Add";
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            this.btnAddRecord.MouseLeave += new System.EventHandler(this.btnAddRecord_MouseLeave);
            this.btnAddRecord.MouseHover += new System.EventHandler(this.btnAddRecord_MouseHover);
            // 
            // btnContacts
            // 
            this.btnContacts.AutoSize = true;
            this.btnContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContacts.Location = new System.Drawing.Point(30, 30);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(35, 18);
            this.btnContacts.TabIndex = 606;
            this.btnContacts.Text = "List";
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            this.btnContacts.MouseLeave += new System.EventHandler(this.btnContacts_MouseLeave);
            this.btnContacts.MouseHover += new System.EventHandler(this.btnContacts_MouseHover);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(143, 399);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 607;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(133, 67);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 31);
            this.txtSearch.TabIndex = 608;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(71, 72);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 18);
            this.lblSearch.TabIndex = 609;
            this.lblSearch.Text = "Search:";
            // 
            // PhonebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(460, 488);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.dgvPhone);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.MTxtNumber);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.LblSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhonebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhonebookForm";
            this.Load += new System.EventHandler(this.PhonebookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox MTxtNumber;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvPhone;
        private System.Windows.Forms.Label btnAddRecord;
        private System.Windows.Forms.Label btnContacts;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}