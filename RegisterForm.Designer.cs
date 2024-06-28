namespace OOP_PROJE
{
    partial class RegisterForm
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
            this.BtnImagePath = new System.Windows.Forms.Button();
            this.MTxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblPhoto = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LnlName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblnewPassword = new System.Windows.Forms.Label();
            this.lblNewKayıt = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImagePath
            // 
            this.BtnImagePath.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImagePath.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnImagePath.Location = new System.Drawing.Point(154, 524);
            this.BtnImagePath.Name = "BtnImagePath";
            this.BtnImagePath.Size = new System.Drawing.Size(96, 42);
            this.BtnImagePath.TabIndex = 53;
            this.BtnImagePath.Text = "Choose";
            this.BtnImagePath.UseVisualStyleBackColor = false;
            this.BtnImagePath.Click += new System.EventHandler(this.BtnImagePath_Click);
            // 
            // MTxtPhoneNumber
            // 
            this.MTxtPhoneNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MTxtPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.MTxtPhoneNumber.Location = new System.Drawing.Point(154, 346);
            this.MTxtPhoneNumber.Mask = "(999) 000-0000";
            this.MTxtPhoneNumber.Name = "MTxtPhoneNumber";
            this.MTxtPhoneNumber.Size = new System.Drawing.Size(217, 24);
            this.MTxtPhoneNumber.TabIndex = 50;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtEmail.Location = new System.Drawing.Point(154, 482);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 24);
            this.TxtEmail.TabIndex = 52;
            // 
            // LblPhoto
            // 
            this.LblPhoto.AutoSize = true;
            this.LblPhoto.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPhoto.Location = new System.Drawing.Point(96, 535);
            this.LblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoto.Name = "LblPhoto";
            this.LblPhoto.Size = new System.Drawing.Size(52, 18);
            this.LblPhoto.TabIndex = 62;
            this.LblPhoto.Text = "Photo:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.LblEmail.Location = new System.Drawing.Point(96, 482);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(54, 18);
            this.LblEmail.TabIndex = 61;
            this.LblEmail.Text = "E-Mail:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtAddress.Location = new System.Drawing.Point(154, 394);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(217, 73);
            this.TxtAddress.TabIndex = 51;
            this.TxtAddress.UseSystemPasswordChar = true;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAddress.Location = new System.Drawing.Point(80, 415);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(66, 18);
            this.LblAddress.TabIndex = 60;
            this.LblAddress.Text = "Address:";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPhoneNumber.Location = new System.Drawing.Point(36, 349);
            this.LblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(112, 18);
            this.LblPhoneNumber.TabIndex = 59;
            this.LblPhoneNumber.Text = "Phone Number:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtSurname.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtSurname.Location = new System.Drawing.Point(154, 301);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(217, 24);
            this.TxtSurname.TabIndex = 49;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtName.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtName.Location = new System.Drawing.Point(154, 257);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(217, 24);
            this.TxtName.TabIndex = 48;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.ForeColor = System.Drawing.SystemColors.Control;
            this.LblSurname.Location = new System.Drawing.Point(78, 304);
            this.LblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(72, 18);
            this.LblSurname.TabIndex = 58;
            this.LblSurname.Text = "Surname:";
            // 
            // LnlName
            // 
            this.LnlName.AutoSize = true;
            this.LnlName.ForeColor = System.Drawing.SystemColors.Control;
            this.LnlName.Location = new System.Drawing.Point(96, 257);
            this.LnlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnlName.Name = "LnlName";
            this.LnlName.Size = new System.Drawing.Size(52, 18);
            this.LnlName.TabIndex = 57;
            this.LnlName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(304, -30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "CREATE ACCOUNT";
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNewPass.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNewPass.Location = new System.Drawing.Point(154, 209);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(217, 24);
            this.txtNewPass.TabIndex = 47;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtNewName
            // 
            this.txtNewName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNewName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNewName.Location = new System.Drawing.Point(154, 162);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(217, 24);
            this.txtNewName.TabIndex = 44;
            // 
            // lblnewPassword
            // 
            this.lblnewPassword.AutoSize = true;
            this.lblnewPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnewPassword.Location = new System.Drawing.Point(73, 212);
            this.lblnewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewPassword.Name = "lblnewPassword";
            this.lblnewPassword.Size = new System.Drawing.Size(79, 18);
            this.lblnewPassword.TabIndex = 46;
            this.lblnewPassword.Text = "Password:";
            // 
            // lblNewKayıt
            // 
            this.lblNewKayıt.AutoSize = true;
            this.lblNewKayıt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNewKayıt.Location = new System.Drawing.Point(69, 165);
            this.lblNewKayıt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewKayıt.Name = "lblNewKayıt";
            this.lblNewKayıt.Size = new System.Drawing.Size(81, 18);
            this.lblNewKayıt.TabIndex = 45;
            this.lblNewKayıt.Text = "Username:";
            this.lblNewKayıt.Click += new System.EventHandler(this.lblNewKayıt_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Location = new System.Drawing.Point(191, 599);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(156, 51);
            this.btnRegister.TabIndex = 54;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PersonalManager.Properties.Resources.icons8_add_user_male_96;
            this.pictureBox3.Location = new System.Drawing.Point(191, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PersonalManager.Properties.Resources.icons8_close_48__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(470, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 593;
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
            this.btnMinimized.Location = new System.Drawing.Point(440, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 592;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            this.btnMinimized.MouseHover += new System.EventHandler(this.btnMinimized_MouseHover);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(149, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(219, 24);
            this.lblHeader.TabIndex = 604;
            this.lblHeader.Text = "Create a New Account";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblError.Location = new System.Drawing.Point(150, 569);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 605;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(500, 676);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.BtnImagePath);
            this.Controls.Add(this.MTxtPhoneNumber);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblPhoto);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LnlName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblnewPassword);
            this.Controls.Add(this.lblNewKayıt);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnImagePath;
        private System.Windows.Forms.MaskedTextBox MTxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblPhoto;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LnlName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblnewPassword;
        private System.Windows.Forms.Label lblNewKayıt;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblError;
    }
}