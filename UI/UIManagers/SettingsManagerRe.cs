using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Регистратура. Панел за админи и разработчици
namespace Hospital_System.UI.UIManagers
{
    public class SettingsManagerRe
    {
        private Size ButtonSize = new Size(200, 200);


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

        public void ShowFormInventory()
        {
            using (var form = new InventoryForm())
            {
                form.Text = ("Inventory");

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

            buttons.Add(CreateTile("Inventory", Color.DarkSalmon, () =>
            {
                ShowFormInventory();
            }));


            //form.flowLayoutPanelAdmin.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelAdmin.Controls.Add(x));

        }

        private void ShowDeveloperPanel(ManagmentForm form)
        {
            var label = CreateLabel("Developer", Color.White, Color.Black, null,350);

            var buttons = new List<Control>();

            buttons.Add(CreateTile("XML references", Color.Purple, () =>
            {
                ShowFormReferences();
            }));

            //form.flowLayoutPanelDeveloper.Controls.Add(label);
            buttons.ForEach(x => form.flowLayoutPanelDeveloper.Controls.Add(x));
        }


        private Control CreateTile(string buttonText, Color backColor, Action onClick)
        {
            var button = new Button();
            button.Text = buttonText;
            button.Size = ButtonSize;
            button.ForeColor = Color.White;
            button.BackColor = backColor;
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

            return label;
        }
    }
}
