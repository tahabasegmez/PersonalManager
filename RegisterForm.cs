using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace OOP_PROJE
{
    public partial class RegisterForm : Form
    {
        int UserType;
        string photoPath;
        bool flag = false;
        UserManager um = new UserManager();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblNewKayıt_Click(object sender, EventArgs e)
        {

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
            Close();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }



        private void BtnImagePath_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                string selectedImagePath = openFileDialog.FileName;


                // Seçilen fotoğrafı ekranda göstermek için bir PictureBox kontrolüne yükleyebilirsiniz.
                pictureBox3.Image = userManager.DisplayBase64Image(userManager.ConvertImageToBase64(selectedImagePath));
                photoPath = selectedImagePath;
            }

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void MTxtPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPhoto_Click(object sender, EventArgs e)
        {

        }

        private void LblEmail_Click(object sender, EventArgs e)
        {

        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblAddress_Click(object sender, EventArgs e)
        {

        }

        private void LblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSurname_Click(object sender, EventArgs e)
        {

        }

        private void LnlName_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnewPassword_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            if (flag == false || txtNewName.Text.Length == 0 || txtNewPass.Text == "" || TxtAddress.Text == "" || TxtEmail.Text == "" || MTxtPhoneNumber.Text == "" || MTxtPhoneNumber.Text.Length < 14 || TxtSurname.Text == "" || TxtName.Text == "" || !UserManager.isEmailValid(TxtEmail.Text))
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Please fill in all required fields.";
                

            }
            else
            {
                lblError.ForeColor = Color.Green;

                if (!um.isThereAdmin()) UserType = 0;
                else UserType = 1;
                string photo = userManager.ConvertImageToBase64(photoPath);
                User newUser = new User(txtNewName.Text, txtNewPass.Text, TxtName.Text, TxtSurname.Text, MTxtPhoneNumber.Text, TxtAddress.Text, TxtEmail.Text, "20002", photo, UserType, false);
                //username, password, name, surname, phoneNumber, address, email, salary, photo, usertype, rememberMe
                um.AddCsv(newUser);
                lblError.Text = "Registration successful.";
                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

        }
    }
}
