using Hospital_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    interface IPatientService
    {
        List<Patient> GetAllPatients();

        bool RemovePatient(int PatientId);

        void AddPatient(Patient patient);

        Patient GetPatient(int patientId);

    }
}
