using Hospital_System.DAL.DB;
using Hospital_System.DAL.Services;
using Mapster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System.DAL.Models.DTOs
{
    partial class HospitalFormAdmin : Form
    {
        public HospitalFormAdmin()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            LoadHospitals();
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void addHospitalButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (var context = new HospitalDbContext())
                {
                    var service = new HospitalService(context);
                    var hospitalDto = new HospitalDTO
                    {
                        Name = nameTextBox.Text,
                        Address = addressTextBox.Text,
                        ContactNumber = phoneTextBox.Text,
                        Email = emailTextBox.Text,
                        HospitalDescription = descriptionTextBox.Text
                    };
                    service.AddHospital(hospitalDto);
                    MessageBox.Show("New hospital is successfuly added!", "Confirmation message", MessageBoxButtons.OK);
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Plaese, enter valid information in the fields", "Entern invalid information error", MessageBoxButtons.OK);
            }

        }

        private void LoadHospitals()
        {
            using (var context = new HospitalDbContext())
            {
                var service = new HospitalService(context);
                IReadOnlyList<HospitalDTO> hospitals = service.GetAllHospitals();
                hospitalsGridView.DataSource = hospitals;
                hospitalsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private bool ValidateForm()
        {
            bool isValid = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox text)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        isValid = false;
                        return isValid;
                    }
                }
            }
            return isValid;
        }

        private void ResetForm()
        {

            nameTextBox.Text = " ";
            addressTextBox.Text = " ";
            phoneTextBox.Text = " ";
            emailTextBox.Text = " ";
            descriptionTextBox.Text = " ";
        }
    }
}
