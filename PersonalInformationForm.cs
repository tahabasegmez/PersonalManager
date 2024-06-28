using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJE
{
    
    public partial class PersonalInformationForm : Form
    {
        static string folderPath = @"data/";
        string phoneBookFilePath;
        string reminderFilePath;
        string notebookFilePath;
        string phoneBookFileName;
        string reminderFileName;
        string notebookFileName;
        string photoPath;
        User loginedUser;
        
        public PersonalInformationForm(User loginedUser)
        {
            InitializeComponent();
            this.loginedUser = loginedUser;

            phoneBookFileName = $"{loginedUser.Username}PhoneBook.csv";
            reminderFileName = $"{loginedUser.Username}Reminders.csv";
            notebookFileName = $"{loginedUser.Username}Notebook.csv";

            phoneBookFilePath = Path.Combine(folderPath, phoneBookFileName);
            reminderFilePath = Path.Combine(folderPath, reminderFileName);
            notebookFilePath = Path.Combine(folderPath, notebookFileName);
        }

        private void PersonalInformationForm_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            picPhoto.Image = userManager.DisplayBase64Image(loginedUser.Photo);
            txtUsername.Text = loginedUser.Username;
            txtPassword.Text = loginedUser.Password;
            TxtAddress.Text = loginedUser.Address; 
            TxtEmail.Text = loginedUser.Email;
            TxtName.Text = loginedUser.Name;  
            TxtSurname.Text = loginedUser.Surname;
            TxtPhoneNumber.Text = loginedUser.PhoneNumber;
            lblUserType.Text = "User Type: " +loginedUser.UserType.ToString();
            lblSalary.Text = "Salary: " + loginedUser.Salary + " Turkish Lira";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserManager um = new UserManager();
            User newUserInfo = new User();
            string oldUsername = loginedUser.Username;
            string photo;
            if (photoPath != null) { photo = um.ConvertImageToBase64(photoPath); }
            else { photo = loginedUser.Photo; }
            um.ChangePersonalInfo(loginedUser.Username, txtUsername.Text, txtPassword.Text, TxtName.Text, TxtSurname.Text,TxtPhoneNumber.Text,TxtAddress.Text,TxtEmail.Text, photo);
            picPhoto.Image = um.DisplayBase64Image(photo);
            newUserInfo.Username = txtUsername.Text;
            newUserInfo.Password = txtPassword.Text;
            newUserInfo.Name = TxtName.Text;
            newUserInfo.Surname = TxtSurname.Text;
            newUserInfo.PhoneNumber = TxtPhoneNumber.Text;
            newUserInfo.Address = TxtAddress.Text;
            newUserInfo.Email = TxtEmail.Text;
            newUserInfo.Photo = photo;
            loginedUser.Username = newUserInfo.Username;
            loginedUser.Address = newUserInfo.Address;
            loginedUser.PhoneNumber = newUserInfo.PhoneNumber; 
            loginedUser.Name = newUserInfo.Name;
            loginedUser.Password = newUserInfo.Password;
            loginedUser.Address = newUserInfo.Address;
            loginedUser.Email = newUserInfo.Email;
            loginedUser.Photo = photo;

            string phoneBookNewFileName = $"{newUserInfo.Username}PhoneBook.csv";
            string phoneBookNewFilePath = Path.Combine(folderPath, phoneBookNewFileName);

            if (File.Exists(phoneBookFilePath))
            {
                System.IO.File.Move(phoneBookFilePath, phoneBookNewFilePath);
                MessageBox.Show("Yeni:" + phoneBookNewFilePath + " str:" + oldUsername + " newUSername:" + loginedUser.Username + " newUserInfoUsername:" + newUserInfo.Username);
            }
            phoneBookFilePath = phoneBookNewFilePath;
            phoneBookFileName = phoneBookNewFileName;

            string reminderNewFileName = $"{newUserInfo.Username}Reminders.csv";
            string reminderNewFilePath = Path.Combine(folderPath, reminderNewFileName);
            if (File.Exists(reminderFilePath))
            {
                System.IO.File.Move(reminderFilePath, reminderNewFilePath);
            }
            reminderFilePath = reminderNewFilePath;
            reminderFileName = reminderNewFileName;

            string notebookNewFileName = $"{newUserInfo.Username}Notebook.csv";
            string notebookNewFilePath = Path.Combine(folderPath, notebookNewFileName);
            if (File.Exists(notebookFilePath))
            {
                System.IO.File.Move(notebookFilePath, notebookNewFilePath);
            }
            notebookFilePath = notebookNewFilePath;
            notebookFileName = notebookNewFileName;
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;


                // Seçilen fotoğrafı ekranda göstermek için bir PictureBox kontrolüne yükleyebilirsiniz.
                picPhoto.Image = userManager.DisplayBase64Image(userManager.ConvertImageToBase64(selectedImagePath));
                photoPath = selectedImagePath;
            }
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(loginedUser);
            menuForm.Show();
            this.Close();
        }

        private void LblSurname_Click(object sender, EventArgs e)
        {

        }
    }
}
