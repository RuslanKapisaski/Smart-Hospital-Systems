
using System.Windows.Forms;
using System;
namespace Hospital_System.UI
{
    public partial class ManagmentForm : Form
    {
        public ManagmentForm()
        {
            InitializeComponent();
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.toggleButton1.ApplyTheme(this.toggleButton1.Checked);
        }
    }
}
