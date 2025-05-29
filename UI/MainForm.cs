
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models.DTOs;
using System;
using System.Windows.Forms;

namespace Hospital_System.UI
{
    public partial class MainForm : Form
    {
        private UserDTO currentUserDto;

        public MainForm(UserDTO userDto)
        {
            InitializeComponent();
            currentUserDto = userDto;
            greetLabel.Text += userDto.Email;

            //Attach event handlers
            personalInfoToolStripMenuItem.Click += personalInfoToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            viewToolStripMenuDoctors.Click += ViewToolStripMenuDoctors_Click;

        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm(currentUserDto);
            userForm.ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            this.Close();
        }

        private void ViewToolStripMenuDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm form = new PatientForm();
            form.SelectTab("doctors");
            form.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm form = new PatientForm();
            form.SelectTab("hospitals");
            form.ShowDialog();
        }
    }
}

