using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_PROJE
{
    public partial class NotebookForm : Form
    {
    
        User loginedUser;
        DataTable dataTable;
        static string folderPath = @"data/";
        string filePath;

        public NotebookForm(User loginedUser)
        {
            InitializeComponent();
            this.loginedUser = loginedUser;
            string fileName = $"{loginedUser.Username}Notebook.csv";
            filePath = Path.Combine(folderPath, fileName);

            dgvNotes.CellDoubleClick += dgvNotes_CellDoubleClick;
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
            DialogResult result = MessageBox.Show("Gerçekten çıkmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                Application.Exit();
            }
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            if (txtNote.Text == "" )
            {
                lblError.Text = "Please fill in all required fields.";
            }
            else
            {
                userManager.AddCsv(filePath, txtNote.Text);
                dataTable = userManager.LoadCsvToDataTable(filePath);
                dgvNotes.DataSource = dataTable;
                lblError.Text = "";
            }
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            txtNote.Visible = true;
            btnCreate.Visible = true;

            dgvNotes.Visible = false;
            BtnList.Visible = false;
           
            BtnDelete.Visible = false;
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            txtNote.Visible = false;
            btnCreate.Visible= false;

            dgvNotes.Visible = true;
            BtnList.Visible = true;
            
            BtnDelete.Visible = true;
        }
        //private void ConfigureDataGridView()
        //{
        //    // DataGridView özelliklerini ayarla
        //    dgvNotes.AutoGenerateColumns = true;
        //    dgvNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvNotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        //    dgvNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        //    // Diğer stil ayarları
        //    dgvNotes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //    dgvNotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvNotes.MultiSelect = false;
        //    dgvNotes.AllowUserToAddRows = false;
        //    dgvNotes.AllowUserToDeleteRows = false;
        //    dgvNotes.ReadOnly = true;
        //}
        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(loginedUser);
            menuForm.Show();
            this.Close();
        }
        
        private void NotebookForm_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            //ConfigureDataGridView();
            dgvNotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNotes.MultiSelect = false;
            dgvNotes.ReadOnly = true;
            dgvNotes.ForeColor = SystemColors.ControlText;
            
            try
            {

                if (!File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        string csvHeader = "Notes                                                                       ";
                        writer.WriteLine(csvHeader);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataTable = userManager.LoadCsvToDataTable(filePath);
            
        }
        private void dgvNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvNotes.Rows[e.RowIndex];
                string existingNote = selectedRow.Cells[0].Value.ToString();

                EditNoteForm editNoteForm = new EditNoteForm(existingNote);
                if (editNoteForm.ShowDialog() == DialogResult.OK)
                {
                    string updatedNote = editNoteForm.UpdatedNote;
                    selectedRow.Cells[0].Value = updatedNote;

                    // Save changes to CSV
                    UserManager userManager = new UserManager();
                    DataTable dataTable = (DataTable)dgvNotes.DataSource;
                    userManager.WriteDataTableToCsv(dataTable, filePath);
                }
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            dgvNotes.Visible = !dgvNotes.Visible;
        }

        private void btnReminders_MouseHover(object sender, EventArgs e)
        {
            btnReminders.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnReminders_MouseLeave(object sender, EventArgs e)
        {
            btnReminders.BackColor = SystemColors.ControlText;
        }
        

        private void btnAddReminder_MouseHover(object sender, EventArgs e)
        {
            btnAddReminder.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnAddReminder_MouseLeave(object sender, EventArgs e)
        {
            btnAddReminder.BackColor = SystemColors.ControlText;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvNotes.SelectedRows)
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

        private void dgvNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvNotes_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
