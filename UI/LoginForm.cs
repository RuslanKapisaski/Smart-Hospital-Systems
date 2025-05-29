namespace Hospital_System
{
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.DAL.Services;
    using Hospital_System.UI;
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkRegisterForm_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

            if(ValidateLoginForm(pass, email))
            {
                try
                {
                    using (var context = new HospitalDbContext())
                    {
                        var service = new UserService(context);
                        UserDTO user = new UserDTO();
                        user.Email = email;
                        user.Password = pass;

                        if (service.LoginUser(user))
                        { 
                            //ResetForm();
                            var mainForm = new MainForm(user);
                            mainForm.ShowDialog();
                            
                            this.Hide();
                            mainForm.FormClosed += (s, args) => this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK);
                        }

                    }                      
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("An error occurred during login. Please try again. Ensure that email and password match with yours.","Error", MessageBoxButtons.OK);
                }
            }

        }

        private bool ValidateLoginForm(string password, string email)
        {
            bool isValid = true;
            string emailPattern = @"\w+@+\w+.\w+";

            if (password.Equals(""))
            {
                MessageBox.Show("Plese, enter a valid password", "Invalid Password");
                isValid = false;
            }
            if (email.Equals("") && Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Plese, enter a valid email", "Invalid Password");
                isValid = false;
            }

            return isValid;
        }

        private void ResetForm()
        {
            emailInput.Text = "";
            passInput.Text = "";
        }

        private void passInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }

            if (e.KeyChar == (char)Keys.F1)
            {
                ResetForm();
            }

        }
    }
}
