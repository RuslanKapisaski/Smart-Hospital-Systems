namespace Hospital_System.BLL.Interfaces
{
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.Models;
    using System.Collections.Generic;

    interface IPatientService
    {
        IReadOnlyList<PatientDTO> GetAllPatients();

        bool RemovePatient(int PatientId);

        void AddPatient(Patient patient);

        PatientDTO GetPatientById(int patientId);

    }
}
