namespace OOP_PROJE
{
    partial class ReminderForm
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.rdoTask = new System.Windows.Forms.RadioButton();
            this.rdoMeeting = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.btnAddReminder = new System.Windows.Forms.Label();
            this.btnReminders = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvReminder = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 27);
            this.dateTimePicker1.TabIndex = 93;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(102, 232);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(378, 30);
            this.txtDescription.TabIndex = 84;
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSummary.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSummary.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSummary.Location = new System.Drawing.Point(102, 286);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(378, 93);
            this.txtSummary.TabIndex = 83;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSummary.Location = new System.Drawing.Point(22, 320);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(74, 20);
            this.lblSummary.TabIndex = 80;
            this.lblSummary.Text = "Summary:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(54, 187);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 20);
            this.lblTime.TabIndex = 79;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(54, 147);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 20);
            this.lblDate.TabIndex = 78;
            this.lblDate.Text = "Date:";
            // 
            // rdoTask
            // 
            this.rdoTask.AutoSize = true;
            this.rdoTask.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoTask.Location = new System.Drawing.Point(102, 18);
            this.rdoTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTask.Name = "rdoTask";
            this.rdoTask.Size = new System.Drawing.Size(54, 24);
            this.rdoTask.TabIndex = 77;
            this.rdoTask.TabStop = true;
            this.rdoTask.Text = "Task";
            this.rdoTask.UseVisualStyleBackColor = true;
            // 
            // rdoMeeting
            // 
            this.rdoMeeting.AutoSize = true;
            this.rdoMeeting.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoMeeting.Location = new System.Drawing.Point(6, 18);
            this.rdoMeeting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMeeting.Name = "rdoMeeting";
            this.rdoMeeting.Size = new System.Drawing.Size(81, 24);
            this.rdoMeeting.TabIndex = 76;
            this.rdoMeeting.TabStop = true;
            this.rdoMeeting.Text = "Meeting";
            this.rdoMeeting.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(235, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(94, 26);
            this.lblHeader.TabIndex = 75;
            this.lblHeader.Text = "Reminder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Description:";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdoTask);
            this.grpType.Controls.Add(this.rdoMeeting);
            this.grpType.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpType.ForeColor = System.Drawing.SystemColors.Control;
            this.grpType.Location = new System.Drawing.Point(106, 76);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(162, 49);
            this.grpType.TabIndex = 593;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_close_48__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(540, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 591;
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
            this.btnMinimized.Location = new System.Drawing.Point(510, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 590;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            this.btnMinimized.MouseHover += new System.EventHandler(this.btnMinimized_MouseHover);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnUpdate.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_refresh;
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnUpdate.Location = new System.Drawing.Point(504, 207);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(50, 50);
            this.BtnUpdate.TabIndex = 88;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnDelete.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_no_reminders_48;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnDelete.Location = new System.Drawing.Point(504, 329);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(50, 50);
            this.BtnDelete.TabIndex = 87;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnAdd.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_add_reminder_48;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnAdd.Location = new System.Drawing.Point(504, 267);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(50, 50);
            this.BtnAdd.TabIndex = 86;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnList.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_list_48;
            this.BtnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnList.Location = new System.Drawing.Point(504, 147);
            this.BtnList.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(50, 50);
            this.BtnList.TabIndex = 85;
            this.BtnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.AutoSize = true;
            this.btnAddReminder.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddReminder.Location = new System.Drawing.Point(30, 30);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(37, 20);
            this.btnAddReminder.TabIndex = 594;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.MouseLeave += new System.EventHandler(this.btnAddReminder_MouseLeave);
            this.btnAddReminder.MouseHover += new System.EventHandler(this.btnAddReminder_MouseHover);
            // 
            // btnReminders
            // 
            this.btnReminders.AutoSize = true;
            this.btnReminders.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminders.Location = new System.Drawing.Point(73, 30);
            this.btnReminders.Name = "btnReminders";
            this.btnReminders.Size = new System.Drawing.Size(108, 20);
            this.btnReminders.TabIndex = 595;
            this.btnReminders.Text = "My Reminders";
            this.btnReminders.MouseLeave += new System.EventHandler(this.btnReminders_MouseLeave);
            this.btnReminders.MouseHover += new System.EventHandler(this.btnReminders_MouseHover);
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
            this.btnBack.TabIndex = 609;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvReminder
            // 
            this.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminder.Location = new System.Drawing.Point(564, 57);
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.Size = new System.Drawing.Size(240, 268);
            this.dgvReminder.TabIndex = 610;
            this.dgvReminder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReminder_CellClick);
            this.dgvReminder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReminder_CellContentClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(564, 329);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 611;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTime.Location = new System.Drawing.Point(104, 180);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTime.Mask = "00:00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(55, 27);
            this.txtTime.TabIndex = 82;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(812, 401);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvReminder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReminders);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeader);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReminderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rem77ainderForm";
            this.Load += new System.EventHandler(this.RemainderForm_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RadioButton rdoTask;
        private System.Windows.Forms.RadioButton rdoMeeting;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Label btnAddReminder;
        private System.Windows.Forms.Label btnReminders;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvReminder;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox txtTime;
    }
}