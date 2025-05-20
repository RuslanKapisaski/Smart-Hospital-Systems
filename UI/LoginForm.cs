namespace Hospital_System
{
    using Hospital_System.DAL.DbConnection;
    using Hospital_System.UI;
    using Npgsql;
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


    public partial class LoginForm : Form
    {
        DataTable users = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            String pass = passInput.Text;
            String email = emailInput.Text;

            ValidateLoginForm(pass, email);

        }

        private void ValidateLoginForm(string password, string email)
        {
            string emailPattern = @"\w+@+\w+.\w+";

            if (password.Equals(""))
            {
                MessageBox.Show("Plese, enter a valid password", "Invalid Password");
            }
            if (email.Equals("") && Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Plese, enter a valid email", "Invalid Password");
            }

            else
            {
                string query = "SELECT COUNT(*) FROM users WHERE password = @password AND email = @email";
                using (var cmd = new NpgsqlCommand(query, DBConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("email", email);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar()); 
                    if (userCount == 1)
                    {
                        HospitalForm form = new HospitalForm();
                        DBConnection.Close();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login. Please enter your data.");
                    }
                };

            }

        }

        private void Reset()
        {
            String pass = passInput.Text;
            String email = emailInput.Text;

            email = "";
            pass = "";

        }




        private void passInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }

            if (e.KeyChar == (char)Keys.F1)
            {
                Reset();
            }

        }


    }
}
