using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static OOP_PROJE.ReminderForm;
using OOP_PROJE.Resources;
using System.Media;
using System.Globalization;

namespace OOP_PROJE
{
    public partial class ReminderForm : Form
    {
        private bool status;
        private User loginedUser;
        private DataTable dataTable;
        private static string folderPath = @"data/";
        private string filePath;

        private ReminderManager reminderManager;

        public ReminderForm(User loginedUser)
        {
            InitializeComponent();
            this.loginedUser = loginedUser;
            string fileName = $"{loginedUser.Username}Reminders.csv";
            filePath = Path.Combine(folderPath, fileName);

            reminderManager = new ReminderManager(filePath);
            reminderManager.ReminderOccurred += ReminderManager_ReminderOccurred;
        }

        private void ReminderManager_ReminderOccurred(object sender, ReminderEventArgs e)
        {
            // Olay tetiklendiğinde bu metot çalışacak
            MessageBox.Show(e.Description);
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

        private void btnAddReminder_MouseLeave(object sender, EventArgs e)
        {
            btnAddReminder.BackColor = SystemColors.ControlText;
        }

        private void btnAddReminder_MouseHover(object sender, EventArgs e)
        {
            btnAddReminder.BackColor = SystemColors.ControlDarkDark;
            btnAddReminder.BackColor = SystemColors.ControlText;
        }

        private void btnReminders_MouseHover(object sender, EventArgs e)
        {
            btnReminders.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnReminders_MouseLeave(object sender, EventArgs e)
        {
            btnReminders.BackColor = SystemColors.ControlText;
            
        }

        private void RemainderForm_Load(object sender, EventArgs e)
        {
            reminderManager.CheckReminders(filePath);
            UserManager userManager = new UserManager();
            dgvReminder.ForeColor = SystemColors.ControlText;

            try
            {

                if (!File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        string csvHeader = "Type,Description,Time,Summary,Status";
                        writer.WriteLine(csvHeader);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataTable = userManager.LoadCsvToDataTable(filePath);
            dgvReminder.DataSource = dataTable;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string reminderType;
            IReminderFactory factory;

            UserManager userManager = new UserManager();
            if ((rdoMeeting.Checked == false && rdoTask.Checked == false) || txtTime.Text == "" || txtDescription.Text == "" || txtSummary.Text == "")
            {
                lblError.Text = "Please fill in all required fields.";
            }
            else
            {
                if (rdoMeeting.Checked)
                {
                    reminderType = rdoMeeting.Text;
                    factory = new MeetingFactory();
                }
                else
                {
                    reminderType = rdoTask.Text;
                    factory = new OOP_PROJE.Resources.TaskFactory();
                }

                Reminder reminder = new Reminder(factory);
                status = true;
                string time = txtTime.Text;

                string reminderDescription = reminder.getReminderDescription(txtDescription.Text);
                string reminderSummary = reminder.getReminderSummary(txtSummary.Text);

                userManager.AddCsv(filePath, reminderType, reminderDescription, time, reminderSummary, status);
                dataTable = userManager.LoadCsvToDataTable(filePath);
                dgvReminder.DataSource = dataTable;
                lblError.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(loginedUser);
            menuForm.Show();
            this.Close();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            
            dgvReminder.Visible = !dgvReminder.Visible;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvReminder.SelectedRows)
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();

           
            string selectedDateTimeString = dateTimePicker1.Value.ToString("MM.dd.yyyy") + " " + txtTime.Text;

            
            string reminderType = rdoTask.Checked ? "Task" : "Meeting";

            
            string newDescription = txtDescription.Text;
            string newSummary = txtSummary.Text;

           
            if (string.IsNullOrWhiteSpace(newDescription) || string.IsNullOrWhiteSpace(newSummary) || string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            int rowIndex = dgvReminder.SelectedCells[0].RowIndex;

            
            string type = dgvReminder.Rows[rowIndex].Cells["Type"].Value.ToString();
            string oldDescription = dgvReminder.Rows[rowIndex].Cells["Description"].Value.ToString();
            string time = dgvReminder.Rows[rowIndex].Cells["Time"].Value.ToString();
            string oldSummary = dgvReminder.Rows[rowIndex].Cells["Summary"].Value.ToString();
            bool status = Convert.ToBoolean(dgvReminder.Rows[rowIndex].Cells["Status"].Value);


            userManager.WriteDataTableToCsv(dataTable, filePath);

            dataTable = userManager.LoadCsvToDataTable(filePath);
            dgvReminder.DataSource = dataTable;

            MessageBox.Show("Reminder updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvReminder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
             
                DataGridViewRow row = this.dgvReminder.Rows[e.RowIndex];

                
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtSummary.Text = row.Cells["Summary"].Value.ToString();
                string[] dateTimeParts = row.Cells["Time"].Value.ToString().Split(' ');
                dateTimePicker1.Value = DateTime.ParseExact(dateTimeParts[0], "MM.dd.yyyy", CultureInfo.InvariantCulture);
                txtTime.Text = dateTimeParts[1];
            }
        }

        private void dgvReminder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
