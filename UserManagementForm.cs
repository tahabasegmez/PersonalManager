using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOP_PROJE
{
    
    public partial class UserManagementForm : Form
    {
        string filePath = @"data/users.csv";
        private BackgroundWorker backgroundWorker;
        string newPassword;
        User loginedUser;
        DataTable dataTable;
        
        public UserManagementForm(User loginedUser)
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            this.loginedUser = loginedUser;
        }
        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var arguments = (Tuple<string, string>)e.Argument;
            string toEmail = arguments.Item1;
            string newPassword = arguments.Item2;
            BackgroundWorker worker = sender as BackgroundWorker;
            SendPasswordResetEmail(toEmail, newPassword, worker);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update progress bar if necessary
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Update UI or show completion message
            MessageBox.Show("E-posta başarıyla gönderildi.");
        }




















        private void BtnUpdate_Click(object sender, EventArgs e)
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

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            UserManager um = new UserManager();
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.ForeColor = SystemColors.ControlText;
            try
            {
                dataTable = um.LoadCsvToDataTable(filePath);
                
                
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvUsers.SelectedRows)
            {
                if (!selectedRow.IsNewRow)
                {
                    int index = selectedRow.Index;
                    
                    dataTable.Rows.RemoveAt(index);
                    UserManager um = new UserManager();
                    um.WriteDataTableToCsv(dataTable, filePath);
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = dataTable;
            cmbUsertype.Items.Add("Admin");
            cmbUsertype.Items.Add("Normal User");
            cmbUsertype.Items.Add("Part-time User");
        }

        private void txtRegisterNo_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length > 2)
            {
                string searchValue = txtSearch.Text.Trim().ToLower();
                dgvUsers.ClearSelection();

                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    if (row.Cells["username"].Value != null && row.Cells["username"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        private void cmbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini alın
                int selectedRowIndex = dgvUsers.SelectedRows[0].Index;

                // Seçili satırın kullanıcı adını alın
                string selectedUsername = dgvUsers.Rows[selectedRowIndex].Cells["username"].Value.ToString();

                // Kullanıcı adına göre verileri dataTable'dan bulun
                DataRow[] selectedRows = dataTable.Select($"username = '{selectedUsername}'");

                if (selectedRows.Length > 0)
                {
                    // Seçili kullanıcının verisini alın
                    DataRow selectedRow = selectedRows[0];

                    // cmbUsertype'tan seçilen değeri alın
                    string selectedUsertype = cmbUsertype.SelectedItem.ToString();

                    // Usertype'ı güncelleyin
                    switch (selectedUsertype)
                    {
                        case "":
                            MessageBox.Show("Choose an usertype");
                            break;
                        case "Admin":
                            selectedRow["usertype"] = "0";
                            break;
                        case "Normal User":
                            selectedRow["usertype"] = "1";
                            break;
                        case "Part-time User":
                            selectedRow["usertype"] = "2";
                            break;
                        default:
                            break;
                    }

                    // Güncellenmiş dataTable'ı CSV dosyasına yazın
                    UserManager um = new UserManager();
                    um.WriteDataTableToCsv(dataTable, filePath);

                    // Kullanıcıya bilgi verin
                    MessageBox.Show("User type updated successfully.");
                }
                else
                {
                    MessageBox.Show("User not found in the database.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the grid.");
            }

        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
                return;
            }

            
            int selectedIndex = dgvUsers.SelectedRows[0].Index;

           
            string username = dgvUsers.Rows[selectedIndex].Cells["username"].Value.ToString();

            
            string userEmail = dataTable.AsEnumerable()
                                          .Where(row => row.Field<string>("username") == username)
                                          .Select(row => row.Field<string>("email"))
                                          .FirstOrDefault();

            
            string newPassword = GenerateRandomPassword();
            if (IsValidEmail(userEmail))
            {
                backgroundWorker.RunWorkerAsync(Tuple.Create(userEmail, newPassword)); ;
            }

            
            UpdateUserPassword(username, newPassword);
            
        }

        
        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());
        }

       
        private void SendPasswordResetEmail(string toEmail,string newPassword, BackgroundWorker worker)
        {
            try
            {
                
                
                string body = $"Your new password is: {newPassword}"; 
                string fromEmail = "cprojegonderenmail@yandex.com"; 
                string fromPassword = "zppytkjabslshizw";  
                string subject = "New Password";
                

                
                SmtpClient smtpClient = new SmtpClient("smtp.yandex.com", 587)
                {
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true
                };

                
                MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);

                
                smtpClient.Send(mail);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending password reset email: {ex.Message}");
            }
        }

        // Kullanıcının şifresini güncelleyen metod
        private void UpdateUserPassword(string username, string newPassword)
        {
            // Kullanıcının şifresini güncelleyin
            DataRow[] selectedRows = dataTable.Select($"username = '{username}'");
            if (selectedRows.Length > 0)
            {
                selectedRows[0]["password"] = newPassword;

                // Güncellenmiş dataTable'ı CSV dosyasına yazın
                UserManager um = new UserManager();
                um.WriteDataTableToCsv(dataTable, filePath);

                MessageBox.Show("Şifre sıfırlama başarılı. Yeni şifre e-posta adresinize gönderildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
