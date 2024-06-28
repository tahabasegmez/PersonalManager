using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace OOP_PROJE
{
    public partial class LoginForm : Form
    {


        static string folderPath = @"data/";
        static string fileName = "users.csv";
        static string filePath = Path.Combine(folderPath, fileName);


        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }









































        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.ControlText;
        }

        private void btnMinimized_MouseHover(object sender, EventArgs e)
        {
            btnMinimized.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnMinimized_MouseLeave(object sender, EventArgs e)
        {
            btnMinimized.BackColor = SystemColors.ControlText;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.ControlDarkDark;

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.ControlText;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnSignUp_MouseHover(object sender, EventArgs e)
        {
            btnSignUp.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = SystemColors.ControlText;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager um = new UserManager();
            if (!um.userExists(txtName.Text))
            {
                lblLoginError.Text = "Kullanici adi bulunamadi. Sign Up'la";
            }
            else
            {
                if (um.VerifyPassword(txtName.Text, txtPassword.Text) == 0)
                {
                    lblLoginError.Text = "Giris yapiliyor";
                    User loginedUser = um.GetUser(txtName.Text);
                    MenuForm menu = new MenuForm(loginedUser);
                    menu.StartPosition = FormStartPosition.CenterScreen;
                    menu.Show();
                    this.Hide();
                }
                else if (um.VerifyPassword(txtName.Text, txtPassword.Text) == 1) { lblLoginError.Text = "Sifre yanlis."; }
                else if (um.VerifyPassword(txtName.Text, txtPassword.Text) == 2) { lblLoginError.Text = "Kullanici adi bulunamadi."; }
            }



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
            lblLoginError.Text = "";



            try
            {
                
                if (!File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        string csvHeader = "username,password,name,surname,phoneNumber,address,email,salary,photo,usertype,rememberMe";
                        writer.WriteLine(csvHeader);
                    }
                }

            }
            catch (Exception ex)
            {
                lblLoginError.Text = $"Bir hata oluştu: {ex.Message}";
            }
        }



    }
}
