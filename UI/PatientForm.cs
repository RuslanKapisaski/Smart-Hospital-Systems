using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Hospital_System.UI
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public void SelectTab(string tabName)
        {
            switch (tabName.ToLower())
            {
                case "hospitals":
                    mainTab.SelectedTab = hospitalsTab;
                    break;
                case "doctors":
                    mainTab.SelectedTab = doctorsTab;
                    break;
                case "appointments":
                    mainTab.SelectedTab = tabAppointemnts;
                    break;
                case "medical results":
                    mainTab.SelectedTab = resultsTab;
                    break;
                default:
                    MessageBox.Show("Tab not found.");
                    break;
            }

        }

       
    }
}


