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
    public partial class EditNoteForm : Form
    {
        public string UpdatedNote { get; private set; }

        public EditNoteForm(string existingNote)
        {
            InitializeComponent();
            txtNote.Text = existingNote;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatedNote = txtNote.Text;
            DialogResult = DialogResult.OK;
            Close();
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
            this.Close();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EditNoteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
