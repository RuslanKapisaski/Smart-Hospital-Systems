namespace Hospital_System.UI
{
    using Hospital_System.DAL.DbConnection;
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Npgsql;

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
            string fName = fNameInput.Text;
            string lName = lNameInput.Text;
            string email = emailInput.Text;
            string pass = passInput.Text;
            string repass = repassInput.Text;
            DateTime bdate = DateTime.Parse(birthDatePicker.Text);
            DateTime registrationDate = DateTime.Now;
            int role_id = 0;

            string emailPattern = @"\w+@+\w+.\w+";

            if (fName.Equals(""))
            {
                MessageBox.Show("Please enter first name.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (lName.Equals(""))
            {
                MessageBox.Show("Please enter last name.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (pass.Equals(""))
            {
                MessageBox.Show("Please enter a valid password.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (repass != pass)
            {
                MessageBox.Show("Your passwords should match.", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (bdate.Equals(""))
            {
                MessageBox.Show("Please enter a birthdat", "Error registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                using (var connection = DBConnection.GetConnection())
                using (var cmd = new NpgsqlCommand("INSERT INTO \"users\"  (first_name, last_name,email,password,role_id,birth_date,registration_date) values (@fName,@lName,@email,@pass,@role_id,@bdate,@regDate)", connection))
                {
                    cmd.Parameters.AddWithValue("@fName", fName);
                    cmd.Parameters.AddWithValue("@lName", lName);
                    cmd.Parameters.AddWithValue("@email",email);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@role_id", role_id);
                    cmd.Parameters.AddWithValue("@bdate", bdate);
                    cmd.Parameters.AddWithValue("@regDate", registrationDate);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Registration successful.");

                        this.fNameInput = null;
                        this.lNameInput = null;
                        this.emailInput = null;
                        this.passInput = null;
                        this.repassInput = null;
                        //DoctorForm doctorForm = new DoctorForm();
                        //PatientForm patientForm = new PatientForm();

                        //if (role == "doctor")
                        //{
                        //    doctorForm.Show();
                        //}
                        //else
                        //{
                        //    patientForm.Show();
                        //}

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }

                }
            }


        }

    }
}
