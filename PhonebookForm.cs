using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJE
{
    public partial class PhonebookForm : Form
    {
        User loginedUser;
        DataTable dataTable;
        static string folderPath = @"data/";
        string filePath;

        public PhonebookForm(User loginedUser)
        {
            InitializeComponent();
            this.loginedUser = loginedUser;
            string fileName = $"{loginedUser.Username}PhoneBook.csv";
            filePath = Path.Combine(folderPath, fileName);
        }

        private void BtnList_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPhone.SelectedCells.Count > 0)
            {
               
                int selectedIndex = dgvPhone.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvPhone.Rows[selectedIndex];

                
                string updatedName = TxtName.Text;
                string updatedSurname = TxtSurname.Text;
                string updatedNumber = MTxtNumber.Text;
                string updatedAddress = TxtAddress.Text;
                string updatedDescription = TxtDescription.Text;
                string updatedEmail = TxtEmail.Text;

                
                selectedRow.Cells["contactName"].Value = updatedName;
                selectedRow.Cells["contactSurname"].Value = updatedSurname;
                selectedRow.Cells["contactPhoneNumber"].Value = updatedNumber;
                selectedRow.Cells["contactAddress"].Value = updatedAddress;
                selectedRow.Cells["contactDesc"].Value = updatedDescription;
                selectedRow.Cells["contactEmail"].Value = updatedEmail;

                dgvPhone.Refresh();

                UserManager um = new UserManager();
                um.WriteDataTableToCsv(dataTable, filePath);

                MessageBox.Show("Contact updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a contact to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void PhonebookForm_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            dgvPhone.ForeColor = SystemColors.ControlText;
           
            try
            {
                
                if (!File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        string csvHeader = "contactName,contactSurname,contactPhoneNumber,contactAddress,contactDesc,contactEmail";
                        writer.WriteLine(csvHeader);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataTable = userManager.LoadCsvToDataTable(filePath);
            dgvPhone.DataSource = dataTable;
        }

        private void btnAddRecord_MouseHover(object sender, EventArgs e)
        {
            btnAddRecord.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnAddRecord_MouseLeave(object sender, EventArgs e)
        {
            btnAddRecord.BackColor= SystemColors.ControlText;
        }

        private void btnContacts_MouseHover(object sender, EventArgs e)
        {
            btnContacts.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnContacts_MouseLeave(object sender, EventArgs e)
        {
            btnContacts.BackColor = SystemColors.ControlText;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            LblName.Visible = true;
            LblSurname.Visible = true;
            LblAddress.Visible = true;
            LblDescription.Visible = true; 
            LblMail.Visible = true;
            LblNumber.Visible = true;
            btnAdd.Visible = true;
            TxtAddress.Visible = true;
            TxtName.Visible = true;
            TxtSurname.Visible = true;
            MTxtNumber.Visible = true;
            txtSearch.Visible = false;
            lblSearch.Visible = false;
            TxtDescription.Visible = true;
            TxtEmail.Visible = true;
            
            dgvPhone.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = false;
          
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            LblName.Visible = false; 
            LblSurname.Visible = false;
            LblAddress.Visible = false;
            LblDescription.Visible = false;
            LblMail.Visible = false;
            LblNumber.Visible = false;
            btnAdd.Visible = false;
            TxtAddress.Visible = false;
            TxtName.Visible = false;
            TxtSurname.Visible = false;
            MTxtNumber.Visible = false;
            
            TxtDescription.Visible = false;
            TxtEmail.Visible=false;
            txtSearch.Visible = true;
            lblSearch.Visible = true;
            dgvPhone.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = true;
         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(loginedUser);
            menuForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            if (TxtName.Text == "" || TxtSurname.Text == "" || MTxtNumber.Text == "" || MTxtNumber.Text.Length < 14 || TxtEmail.Text == "" || TxtDescription.Text == "" || TxtAddress.Text == "" || !UserManager.isEmailValid(TxtEmail.Text))
            {
                lblError.Text = "Please fill in all required fields.";
            }
            else
            {
                userManager.AddCsv(filePath, TxtName.Text, TxtSurname.Text, MTxtNumber.Text, TxtAddress.Text, TxtDescription.Text, TxtEmail.Text);
                dataTable = userManager.LoadCsvToDataTable(filePath);
                dgvPhone.DataSource = dataTable;
                lblError.Text = "";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 2)
            {
                string searchValue = txtSearch.Text.Trim().ToLower();
                dgvPhone.ClearSelection();

                foreach (DataGridViewRow row in dgvPhone.Rows)
                {
                    if (row.Cells["contactName"].Value != null && row.Cells["contactName"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvPhone.SelectedRows)
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

        private void dgvPhone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int selectedIndex = e.RowIndex;

                DataGridViewRow selectedRow = dgvPhone.Rows[selectedIndex];
                TxtName.Text = selectedRow.Cells["contactName"].Value.ToString();
                TxtSurname.Text = selectedRow.Cells["contactSurname"].Value.ToString();
                MTxtNumber.Text = selectedRow.Cells["contactPhoneNumber"].Value.ToString();
                TxtAddress.Text = selectedRow.Cells["contactAddress"].Value.ToString();
                TxtDescription.Text = selectedRow.Cells["contactDesc"].Value.ToString();
                TxtEmail.Text = selectedRow.Cells["contactEmail"].Value.ToString();
            }
        }
    }
}
