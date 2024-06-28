namespace OOP_PROJE
{
    partial class NotebookForm
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.btnReminders = new System.Windows.Forms.Label();
            this.btnAddReminder = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNote.Location = new System.Drawing.Point(34, 76);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(533, 300);
            this.txtNote.TabIndex = 63;
            this.txtNote.Text = "                                   \r\n";
            this.txtNote.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(271, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 24);
            this.lblHeader.TabIndex = 595;
            this.lblHeader.Text = "Notebook";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_close_48__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(614, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 594;
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
            this.btnMinimized.Location = new System.Drawing.Point(584, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 593;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            this.btnMinimized.MouseHover += new System.EventHandler(this.btnMinimized_MouseHover);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnDelete.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_delete_48;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnDelete.Location = new System.Drawing.Point(580, 240);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(50, 50);
            this.BtnDelete.TabIndex = 591;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_add_list_48;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreate.Location = new System.Drawing.Point(580, 155);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(50, 50);
            this.btnCreate.TabIndex = 590;
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.btnBack.TabIndex = 589;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnList.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_list_48;
            this.BtnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnList.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnList.Location = new System.Drawing.Point(578, 76);
            this.BtnList.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(50, 50);
            this.BtnList.TabIndex = 67;
            this.BtnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnReminders
            // 
            this.btnReminders.AutoSize = true;
            this.btnReminders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminders.Location = new System.Drawing.Point(73, 30);
            this.btnReminders.Name = "btnReminders";
            this.btnReminders.Size = new System.Drawing.Size(80, 18);
            this.btnReminders.TabIndex = 597;
            this.btnReminders.Text = "My Notes";
            this.btnReminders.Click += new System.EventHandler(this.btnReminders_Click);
            this.btnReminders.MouseLeave += new System.EventHandler(this.btnReminders_MouseLeave);
            this.btnReminders.MouseHover += new System.EventHandler(this.btnReminders_MouseHover);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.AutoSize = true;
            this.btnAddReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddReminder.Location = new System.Drawing.Point(30, 30);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(36, 18);
            this.btnAddReminder.TabIndex = 596;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            this.btnAddReminder.MouseLeave += new System.EventHandler(this.btnAddReminder_MouseLeave);
            this.btnAddReminder.MouseHover += new System.EventHandler(this.btnAddReminder_MouseHover);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 384);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 598;
            // 
            // dgvNotes
            // 
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvNotes.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvNotes.Location = new System.Drawing.Point(34, 76);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersWidth = 51;
            this.dgvNotes.Size = new System.Drawing.Size(534, 300);
            this.dgvNotes.TabIndex = 605;
            this.dgvNotes.CellBorderStyleChanged += new System.EventHandler(this.dgvNotes_CellBorderStyleChanged);
            this.dgvNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellClick);
            this.dgvNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellContentClick);
            // 
            // NotebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(644, 413);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReminders);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.txtNote);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NotebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotebookForm";
            this.Load += new System.EventHandler(this.NotebookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label btnReminders;
        private System.Windows.Forms.Label btnAddReminder;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvNotes;
    }
}