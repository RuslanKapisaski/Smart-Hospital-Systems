namespace Hospital_System.UI
{
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.DAL.Services;
    using Hospital_System.UI.UIManagers;
    using Mapster;
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class RegisterForm : Form
    {
        SettingsManagerRe manager = new SettingsManagerRe();

        public RegisterForm()
        {
            InitializeComponent();
            CenterForm();
            MaskPasswordFields();
            birthDatePicker.Value = DateTime.Today.AddYears(-18);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm(out User user))
            {
                user.FirstName = fNameInput.Text.Trim();
                user.LastName = lNameInput.Text.Trim();
                user.Email = emailInput.Text.Trim();
                user.Password = passInput.Text;
                user.BirthDate = EnsureUtc(birthDatePicker.Value);
                user.RegistrationDate = DateTime.UtcNow;
               
                RegisterUser(user);
            }
            else
            {
                MessageBox.Show("Enter valid information", "Registration error", MessageBoxButtons.OK);
            }

        }

        private bool ValidateForm(out User user)
        {
            user = new User();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(fNameInput.Text))
            {
                ShowError("Please enter first name.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lNameInput.Text))
            {
                ShowError("Please enter last name.");
                isValid = false;
            }

            if (!IsValidEmail(emailInput.Text))
            {
                ShowError("Please enter a valid email.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(passInput.Text) || passInput.Text.Length < 6)
            {
                ShowError("Password must be at least 6 characters.");
                isValid = false;
            }

            if (passInput.Text != repassInput.Text)
            {
                ShowError("Passwords do not match.");
                isValid = false;
            }

            if (birthDatePicker.Value > DateTime.Today)
            {
                ShowError("Birth date cannot be in the future.");
                isValid = false;
            }

            return isValid;
        }

        private void RegisterUser(User user)
        {
            try
            {
                using (var dbContext = new HospitalDbContext())
                {
                    var userService = new UserService(dbContext);

                    if (user.Role == null)
                    {
                        user.Role = dbContext.Roles.Find(0);
                    }

                    bool isSuccessful = userService.RegisterUser(user);

                    if (isSuccessful)
                    {
                        ResetForm();
                        this.Hide();

                        var userDto = user.Adapt<UserDTO>();
                        var mainForm = new MainForm(userDto);
                        manager.DispatchPanels(userDto.Role.roleId, mainForm);
                        mainForm.ShowDialog();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
            catch (Npgsql.PostgresException ex) when (ex.SqlState == "23505")
            {
                ShowError("Email already exists. Please use a different email.");
            }
            catch (Exception ex)
            {
                ShowError($"Registration failed: {ex.Message}");
            }
        }

        private void ResetForm()
        {
            fNameInput.Text = string.Empty;
            lNameInput.Text = string.Empty;
            emailInput.Text = string.Empty;
            passInput.Text = string.Empty;
            repassInput.Text = string.Empty;
            birthDatePicker.Value = DateTime.Today.AddYears(-18);
        }

        private DateTime EnsureUtc(DateTime input)
        {
            switch (input.Kind)
            {
                case DateTimeKind.Utc:
                    return input;
                case DateTimeKind.Local:
                    return input.ToUniversalTime();
                case DateTimeKind.Unspecified:
                default:
                    return DateTime.SpecifyKind(input, DateTimeKind.Utc);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Registration Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MaskPasswordFields()
        {
            passInput.PasswordChar = '*';
            repassInput.PasswordChar = '*';

        }

        private void CenterForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }

}


