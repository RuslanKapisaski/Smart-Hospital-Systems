using Hospital_System.DAL.DB;
using Hospital_System.DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System.UI
{
    public partial class DoctorFormAdmin : Form
    {
        public DoctorFormAdmin()
        {
            InitializeComponent();
        }


        private void addDoctorBtn_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                var service = new DoctorService(context);
                try
                {
                    //var doctorDto
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
