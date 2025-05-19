namespace Hospital_System
{
    using Hospital_System.UI;
    using System;
    using System.Windows.Forms;


    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            String pass = passInput.Text;
            String email = emailInput.Text;

            //
            if (pass == "123" && email == "123")
            {
                this.Hide();
                
            }
            else if(pass!="" && email !="")
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Reset()
        {
            String pass = passInput.Text;
            String email = emailInput.Text;

            email = "";
            pass = "";

        }

        private void pass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

        private void passInput_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }

            if(e.KeyChar == (char)Keys.F1)
            {
                Reset();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
