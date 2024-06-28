using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJE
{
    public partial class MenuForm : Form
    {
        User loginedUser;
        public MenuForm(User loginedUser)
        {
            InitializeComponent();
            this.loginedUser = loginedUser;
        }


















        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAdmin.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = SystemColors.ControlText;
        }

        private void btnNoteBook_MouseHover(object sender, EventArgs e)
        {
            btnNoteBook.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnNoteBook_MouseLeave(object sender, EventArgs e)
        {
            btnNoteBook.BackColor = SystemColors.ControlText;
        }

        private void btnPersonalInfo_MouseHover(object sender, EventArgs e)
        {
            btnPersonalInfo.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnPersonalInfo_MouseLeave(object sender, EventArgs e)
        {
            btnPersonalInfo.BackColor = SystemColors.ControlText;
        }

        private void btnPhoneBook_MouseHover(object sender, EventArgs e)
        {
            btnPhoneBook.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnPhoneBook_MouseLeave(object sender, EventArgs e)
        {
            btnPhoneBook.BackColor = SystemColors.ControlText;
        }

        private void btnCalculator_MouseHover(object sender, EventArgs e)
        {
            btnCalculator.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnCalculator_MouseLeave(object sender, EventArgs e)
        {
            btnCalculator.BackColor = SystemColors.ControlText;
        }

        private void btnRemainder_MouseHover(object sender, EventArgs e)
        {
            btnRemainder.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnRemainder_MouseLeave(object sender, EventArgs e)
        {
            btnRemainder.BackColor = SystemColors.ControlText;
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            btnLogOut.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = SystemColors.ControlText;
        }
        private void BtnCalculator_MouseHover(object sender, EventArgs e)
        {
            btnCalculator.BackColor = SystemColors.ControlDarkDark;
        }
        private void BtnCalculator_MouseLeave(object sender, EventArgs e)
        {
            btnCalculator.BackColor = SystemColors.ControlText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Gerçekten çıkmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Kullanıcı 'Hayır' seçerse, formun kapanmasını iptal et
                Application.Exit();
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

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
       
        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (loginedUser.UserType == 0) { btnAdmin.Enabled = true; btnAdmin.Visible = true; LblManagement.Visible = true; }
            else { btnAdmin.Enabled = false; btnAdmin.Visible = false; LblManagement.Visible = false; }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(loginedUser);
            userManagementForm.Show();
            this.Close();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            SalaryCalculatorForm salaryCalculatorForm = new SalaryCalculatorForm(loginedUser);
            salaryCalculatorForm.Show();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            PersonalInformationForm personalInformationForm = new PersonalInformationForm(loginedUser);
            personalInformationForm.Show();
        }

        private void btnPhoneBook_Click(object sender, EventArgs e)
        {
            PhonebookForm phonebookForm = new PhonebookForm(loginedUser);
            phonebookForm.Show();
            this.Close();
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            ReminderForm remainderForm = new ReminderForm(loginedUser);
            remainderForm.Show();
            this.Close();
        }

        private void btnNoteBook_Click(object sender, EventArgs e)
        {
            NotebookForm notebookForm = new NotebookForm(loginedUser);
            notebookForm.Show();
            this.Close();
        }
    }
}
