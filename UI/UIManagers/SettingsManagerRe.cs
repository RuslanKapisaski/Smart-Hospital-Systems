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
    using System.Windows.Forms.VisualStyles;

    public class SettingsManagerRe
    {

        private readonly UserService _userService;

        public SettingsManagerRe() { }

        public SettingsManagerRe(UserService _userService)
        {
            this._userService = _userService;
        }


        private Size ButtonSize = new Size(360, 300);
        private Color OriginalButtonColor = Color.Transparent;

        //Admins forms
       
        private void ShowFormPatientsForAdmins()
        {
            using (var form = new PatientForm())
            {
                form.Text = "Patients";

                form.ShowDialog();
            }
        }

        private void ShowFormHospitalsForAdmins()
        {
            using (var form = new HospitalFormAdmin())
            {
                form.Text = "Hospitals";

                form.ShowDialog();
            }
        }

        private void ShowFormAppointmentsForAdmins()
        {
            using (var form = new AppointmentsForm())
            {
                form.Text = ("Appointments");

                form.ShowDialog();
            }
        }

        private void ShowFormUsersForAdmins()
        {
            using (var form = new UserFormAdmin())
            {
                form.Text = "Users";


                form.ShowDialog();
            }
        }

        //Developer forms
        private void ShowFormReferencesForDevelopers()
        {
            using (var form = new DeveloperForm())
            {
                form.Text = ("Developer mode");

                form.ShowDialog();
            }
        }

        ////users form
        private void ShowFormBasicUserInformation()
        {
            using (var form = new UserForm())
            {
                form.Text = "User information";

                form.ShowDialog();
            }
        }

        //patients
        private void ShowFormHospitalsForPatiens()
        {
            using (var form = new PatientForm())
            {
                form.SelectTab("hospitals");
                form.ShowDialog();
            }
        }

        private void ShowFormDoctorsForPatiens()
        {
            using (var form = new PatientForm())
            {
                form.SelectTab("doctors");
                form.ShowDialog();
            }
        }

        private void ShowFormPaymentsForPatiens()
        {
            using (var form = new Payments())
            {
                form.Text = "Payments";
                form.ShowDialog();
            }
        }

        private void ShowFormAppointmentsForPatiens()
        {
            using (var form = new PatientForm())
            {
                form.SelectTab("appointments");
                form.ShowDialog();
            }
        }

        private void ShowFormAboutUsForPatiens()
        {
            using (var form = new AboutForm())
            {
                form.Text = "Hospital Systems";
                form.ShowDialog();
            }
        }






        //Panels
        private void ShowUserPanel(MainForm form)
        {

            var buttons = new List<Control>();

            
            buttons.Add(CreateTile("My Profile", Color.White, () =>
            {
                ShowFormBasicUserInformation();
            }));
         
            //form.flowLayoutPanelAdmin.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));


        }

        private void ShowPatientPanel(MainForm form)
        {
 
            var buttons = new List<Control>();

            buttons.Add(CreateTile("Hospitals", Color.DarkRed, () =>
            {
                ShowFormHospitalsForPatiens();
            }));

            buttons.Add(CreateTile("Doctors", Color.DarkOliveGreen, () =>
            {
                ShowFormDoctorsForPatiens();
            }));

            buttons.Add(CreateTile("Payments", Color.DarkOrange, () =>
            {
                ShowFormPaymentsForPatiens();
            }));

            buttons.Add(CreateTile("Appointments", Color.DarkMagenta, () =>
            {
                ShowFormAppointmentsForPatiens();
            }));

            buttons.Add(CreateTile("About Us", Color.Blue, () =>
            {
                ShowFormAboutUsForPatiens();
            }));

            //form.flowLayoutPanelAdmin.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));


        }

        private void ShowDoctorPanel(MainForm form)
        {

            var buttons = new List<Control>();

            buttons.Add(CreateTile("Hospitals", Color.DarkRed, () =>
            {
                ShowFormHospitalsForPatiens();
            }));

            buttons.Add(CreateTile("Doctors", Color.DarkOliveGreen, () =>
            {
                ShowFormDoctorsForPatiens();
            }));

            buttons.Add(CreateTile("Payments", Color.DarkOrange, () =>
            {
                ShowFormPaymentsForPatiens();
            }));

            buttons.Add(CreateTile("Appointments", Color.DarkMagenta, () =>
            {
                ShowFormAppointmentsForPatiens();
            }));

            buttons.Add(CreateTile("About Us", Color.Blue, () =>
            {
                ShowFormAboutUsForPatiens();
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
                ShowFormHospitalsForAdmins();
            }));

            buttons.Add(CreateTile("Patients", Color.DarkOrange, () =>
            {
                ShowFormPatientsForAdmins();
            }));

            buttons.Add(CreateTile("Appointments", Color.DarkMagenta, () =>
            {
                ShowFormAppointmentsForAdmins();
            }));


            buttons.Add(CreateTile("Users", Color.Blue, () =>
            {
                ShowFormUsersForAdmins();
            }));



            //form.flowLayoutPanelAdmin.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));


        }

        private void ShowDeveloperPanel(MainForm form)
        {
            var label = CreateLabel("Developer", Color.White, Color.Black, null, 350);

            var buttons = new List<Control>();

            buttons.Add(CreateTile("Developer Mode", Color.DarkRed, () =>
            {
                ShowFormHospitalsForAdmins();
            }));

            buttons.Add(CreateTile("Developer Mode", Color.DarkOrange, () =>
            {
                ShowFormPatientsForAdmins();
            }));

            buttons.Add(CreateTile("Developer Mode", Color.DarkMagenta, () =>
            {
                ShowFormAppointmentsForAdmins();
            }));


            buttons.Add(CreateTile("Developer Mode", Color.Blue, () =>
            {
                ShowFormUsersForAdmins();
            }));

            buttons.Add(CreateTile("Developer Mode", Color.Purple, () =>
            {
                ShowFormReferencesForDevelopers();
            }));

            //form.flowLayoutPanelDeveloper.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelMainForm.Controls.Add(x));
        }

        //Buttons Dispatcher
        public void DispatchPanels(int role, MainForm form)
        {
         
            switch (role)
            {
                case 1:
                    ShowUserPanel(form);
                    break;

                case 2:
                    ShowPatientPanel(form);

                    break;

                case 3:
                    ShowDoctorPanel(form);

                    break;

                case 4:
                    ShowAdminPanel(form);
                    break; 
                
                case 5:
                    ShowDeveloperPanel(form);
                    break;

                default:
                    MessageBox.Show("Role not recognized: " + role);
                    break;
            }
        }

        private Control CreateTile(string buttonText, Color borderColor, Action onClick)
        {
            var button = new Button();
            button.Size = ButtonSize;
            button.BackColor = OriginalButtonColor;
            button.Margin = new Padding(10);
            button.Text = buttonText;
            button.ForeColor = Color.White;
            button.Font = new Font(button.Font.FontFamily, 24, FontStyle.Bold);

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = borderColor;
            button.FlatAppearance.BorderSize = 3;

            button.UseVisualStyleBackColor = false;

            Color hoverColor = Color.FromArgb(
                Math.Min(255, borderColor.R + 40),
                Math.Min(255, borderColor.G + 40),
                Math.Min(255, borderColor.B + 40)
            );

            button.MouseEnter += (s, e) =>
            {
                button.FlatAppearance.BorderColor = hoverColor;
                button.BackColor = Color.FromArgb(10, hoverColor.R, hoverColor.G, hoverColor.B); // Slight tint
            };

            button.MouseLeave += (s, e) =>
            {
                button.FlatAppearance.BorderColor = borderColor;
                button.BackColor = OriginalButtonColor;
            };

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
