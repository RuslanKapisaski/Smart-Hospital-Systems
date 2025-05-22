//Регистратура. Панел за админи и разработчици
namespace Hospital_System.UI.UIManagers
{
    using Hospital_System.DAL.Services;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;

    using System.Windows.Forms;

    public class SettingsManagerRe
    {

        private readonly UserService _userService;

        //Dependency Injection

        public SettingsManagerRe() { }

        public SettingsManagerRe(UserService _userService)
        {
            this._userService = _userService;
        }


        private Size ButtonSize = new Size(180, 140);


        public void ShowManagmentForm(bool isAdmin, bool isDeveloper)
        {
            using (var form = new ManagmentForm())
            {
                form.Text = "Managment Form";

                if (isAdmin)
                {
                    ShowAdminPanel(form);
                }

                if (isDeveloper)
                {
                    ShowDeveloperPanel(form);
                }

                form.ShowDialog();
            }
        }

        public void ShowFormDoctors()
        {
            using (var form = new DoctorForm())
            {
                form.Text = "Doctors";

                form.ShowDialog();
            }
        }

        public void ShowFormPatients()
        {
            using (var form = new PatientForm())
            {
                form.Text = "Patients";

                form.ShowDialog();
            }
        }

        public void ShowFormHospitals()
        {
            using (var form = new HospitalForm())
            {
                form.Text = "Hospitals";

                form.ShowDialog();
            }
        }


        public void ShowFormAppointments()
        {
            using (var form = new AppointmentsForm())
            {
                form.Text = ("Appointments");

                form.ShowDialog();
            }
        }
        public void ShowFormUsers()
        {
            using (var form = new UserForm())
            {
                form.Text = "Users";

                void refreshGridUsers()
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("User ID");
                    table.Columns.Add("Username");
                    table.Columns.Add("Email");
                    table.Columns.Add("Registration Date");

                    var users = _userService.GetAllUsers();

                    foreach (var user in users)
                    {
                        table.Rows.Add(user.Id, user.FirstName + " " + user.LastName, user.Email, user.RegistrationDate);
                    }


                    form.dataGridViewUsers.DataSource = table;
                }



                refreshGridUsers();

                form.btnAddNewUser.Click += (s, e) =>
                {
                    // var dialogResult = ShowFormUsersNewEdit();
                    // if (dialogResult == DialogResult.Yes)
                    // {
                    //     refreshGridUsers();
                    // }
                };



                form.ShowDialog();
            }
        }



        public void ShowFormReferences()
        {
            using (var form = new DeveloperForm())
            {
                form.Text = ("Developer mode");

                form.ShowDialog();
            }
        }


        private void ShowAdminPanel(ManagmentForm form)
        {
            var label = CreateLabel("Administrator", Color.White, Color.Black, null);

            var buttons = new List<Control>();

            buttons.Add(CreateTile("Hospitals", Color.DarkRed, () =>
            {
                ShowFormHospitals();
            }));

            buttons.Add(CreateTile("Doctors", Color.DarkOliveGreen, () =>
            {
                ShowFormDoctors();
            }));

            buttons.Add(CreateTile("Patients", Color.DarkOrange, () =>
            {
                ShowFormPatients();
            }));

            buttons.Add(CreateTile("Appointments", Color.DarkMagenta, () =>
            {
                ShowFormAppointments();
            }));


            buttons.Add(CreateTile("Users", Color.Blue, () =>
            {
                ShowFormUsers();
            }));



            //form.flowLayoutPanelAdmin.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelAdmin.Controls.Add(x));


        }

        private void ShowDeveloperPanel(ManagmentForm form)
        {
            var label = CreateLabel("Developer", Color.White, Color.Black, null, 350);

            var buttons = new List<Control>();

            buttons.Add(CreateTile("XML references", Color.Purple, () =>
            {
                ShowFormReferences();
            }));

            //form.flowLayoutPanelDeveloper.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelDeveloper.Controls.Add(x));
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Size = new Size(ButtonSize.Width + 2, ButtonSize.Height + 2);
                button.Location = new Point(button.Location.X - 1, button.Location.Y - 1);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Size = ButtonSize;
                button.Location = new Point(button.Location.X + 1, button.Location.Y + 1);
            }
        }

        private Control CreateTile(string buttonText, Color backColor, Action onClick)
        {
            var button = new Button();
            button.Text = buttonText;
            button.Size = ButtonSize;
            button.ForeColor = Color.White;
            button.BackColor = backColor;
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;
            button.Click += (s, e) => onClick?.Invoke();

            return button;
        }

        private Control CreateLabel(string text, Color backColor, Color foreColor, Font font = null, float fontSize = 10f)
        {
            var label = new Label();
            label.Text = text;
            label.Font = font;
            label.Font = new Font(label.Font.FontFamily, fontSize);
            label.ForeColor = foreColor;
            label.BackColor = backColor;
            label.Font = new Font(label.Font.FontFamily, fontSize);

            return label;
        }
    }
}
