//Регистратура. Панел за админи и разработчици
namespace Hospital_System.UI.UIManagers
{
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.DAL.Services;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;

    using System.Windows.Forms;

    public class SettingsManagerRe
    {

        private readonly UserService _userService;

        public SettingsManagerRe() { }

        public SettingsManagerRe(UserService _userService)
        {
            this._userService = _userService;
        }



        private Size ButtonSize = new Size(180, 140);


        //public void ShowManagmentForm(bool isAdmin, bool isDeveloper)
        //{
        //    using (var form = new MainForm())
        //    {
        //        form.Text = "Managment Form";

        //        if (isAdmin)
        //        {
        //            ShowAdminPanel(form);
        //        }

        //        if (isDeveloper)
        //        {
        //            ShowDeveloperPanel(form);
        //        }

        //        form.ShowDialog();
        //    }
        //}

        public void ShowFormDoctors()
        {
            using (var form = new DoctorFormAdmin())
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
            using (var form = new HospitalFormAdmin())
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
            using (var form = new UserFormAdmin())
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


                    //form.dataGridViewUsers.DataSource = table;
                }



                refreshGridUsers();

                //form.btnAddNewUser.Click += (s, e) =>
                //{
                //    // var dialogResult = ShowFormUsersNewEdit();
                //    // if (dialogResult == DialogResult.Yes)
                //    // {
                //    //     refreshGridUsers();
                //    // }
                //};



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

        //users form
        public void ShowFormHospitalsForUsers()
        {
            using (var form = new PatientForm())
            {
                form.SelectTab("hospitals");
                form.ShowDialog();
            }
        }

        public void ShowFormDoctorsForUsers()
        {
            using (var form = new PatientForm())
            {
                form.SelectTab("doctors");
                form.ShowDialog();
            }
        }

        public void ShowFormPaymentsForUsers()
        {
            using (var form = new Payments())
            {
                form.Text = "Payments";
                form.ShowDialog();
            }
        }

        public void ShowFormAppointmentsForUsers()
        {
            using (var form = new PatientForm())
            {
                form.SelectTab("appointments");
                form.ShowDialog();
            }
        }

        public void ShowFormAboutUsForUsers()
        {
            using (var form = new AboutForm())
            {
                form.Text = "Hospital Systems";
                form.ShowDialog();
            }
        }

        public void DispatchPanels(int role, MainForm form)
        {
         
            switch (role)
            {
                case 0:
                    ShowPatientPanel(form);
                    break;

                case 1:
                    ShowDeveloperPanel(form);

                    break;

                case 2:
                    ShowPatientPanel(form);

                    break;

                case 3:
                    ShowPatientPanel(form);

                    break;

                default:
                    MessageBox.Show("Role not recognized: " + role);
                    break;
            }
        }

        public void ShowPatientPanel(MainForm form)
        {
 
            var buttons = new List<Control>();

            buttons.Add(CreateTile("Hospitals", Color.DarkRed, () =>
            {
                ShowFormHospitalsForUsers();
            }));

            buttons.Add(CreateTile("Doctors", Color.DarkOliveGreen, () =>
            {
                ShowFormDoctorsForUsers();
            }));

            buttons.Add(CreateTile("Payments", Color.DarkOrange, () =>
            {
                ShowFormPaymentsForUsers();
            }));

            buttons.Add(CreateTile("Appointments", Color.DarkMagenta, () =>
            {
                ShowFormAppointmentsForUsers();
            }));

            buttons.Add(CreateTile("About Us", Color.Blue, () =>
            {
                ShowFormAboutUsForUsers();
            }));



            //form.flowLayoutPanelAdmin.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));


        }

        public void ShowDoctorPanel(MainForm form)
        {

            var buttons = new List<Control>();

            buttons.Add(CreateTile("Hospitals", Color.DarkRed, () =>
            {
                ShowFormHospitalsForUsers();
            }));

            buttons.Add(CreateTile("Doctors", Color.DarkOliveGreen, () =>
            {
                ShowFormDoctorsForUsers();
            }));

            buttons.Add(CreateTile("Payments", Color.DarkOrange, () =>
            {
                ShowFormPaymentsForUsers();
            }));

            buttons.Add(CreateTile("Appointments", Color.DarkMagenta, () =>
            {
                ShowFormAppointmentsForUsers();
            }));

            buttons.Add(CreateTile("About Us", Color.Blue, () =>
            {
                ShowFormAboutUsForUsers();
            }));



            //form.flowLayoutPanelAdmin.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));


        }

        private void ShowAdminPanel(MainForm form)
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
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));


        }

        private void ShowDeveloperPanel(MainForm form)
        {
            var label = CreateLabel("Developer", Color.White, Color.Black, null, 350);

            var buttons = new List<Control>();

            buttons.Add(CreateTile("XML references", Color.Purple, () =>
            {
                ShowFormReferences();
            }));

            //form.flowLayoutPanelDeveloper.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));
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
