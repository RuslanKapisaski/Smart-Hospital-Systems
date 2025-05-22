using Hospital_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    interface IDoctorService
    {
        void AddDoctorSpecialization();

        void AddDoctorAppointment();

        void AddDoctorSchedule();

        string GetDoctorSpecialization();

        string GetDoctorAppointment();

        string GetDoctorSchedule();


        Doctor GetDoctorById(int doctorID);

        Doctor GetDoctorByName(string doctorName);
    }
}
