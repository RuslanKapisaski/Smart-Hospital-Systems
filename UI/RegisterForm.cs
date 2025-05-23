namespace Hospital_System.UI
{
    //using Hospital_System.DAL.DbConnection;
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Npgsql;
    using Hospital_System.DAL.Models;

    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }



        private void registerButton(object sender, EventArgs e)
        {
            ValidateForm();

        }

        private void ValidateForm()
        {
            User user = new User();

            user.FirstName = fNameInput.Text;
            user.LastName = lNameInput.Text;
            user.Email = emailInput.Text;
            user.Password = passInput.Text;
            string repass = repassInput.Text;
            user.BirthDate = DateTime.Parse(birthDatePicker.Text);
            user.RegistrationDate = DateTime.Now;
            user.RoleId = 0;

            string emailPattern = @"\w+@+\w+.\w+";

            if (user.FirstName.Equals(""))
            {
                MessageBox.Show("Please enter first name.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (user.LastName.Equals(""))
            {
                MessageBox.Show("Please enter last name.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (!Regex.IsMatch(user.Email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (user.Password.Equals(""))
            {
                MessageBox.Show("Please enter a valid password.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (repass != user.Password)
            {
                MessageBox.Show("Your passwords should match.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (user.BirthDate.Equals(""))
            {
                MessageBox.Show("Please enter a birthdat", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                //TODO

                //if ()
                //{

                //    MessageBox.Show("Registration successful.");

                //    this.fNameInput = null;
                //    this.lNameInput = null;
                //    this.emailInput = null;
                //    this.passInput = null;
                //    this.repassInput = null;
                //    //DoctorForm doctorForm = new DoctorForm();
                //    //PatientForm patientForm = new PatientForm();
                //    //if (role == "doctor")
                //    //{
                //    //    doctorForm.Show();
                //    //}
                //    //else
                //    //{
                //    //    patientForm.Show();
                //    //}
                //    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("Registration failed.");
                //}

            }
        }


    }

}

