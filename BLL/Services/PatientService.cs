using Hospital_System.BLL.Interfaces;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.Models;
using Hospital_System.Utils;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Hospital_System.DAL.Services
{
    class PatientService : IPatientService
    {
        private readonly HospitalDbContext _hospitalDbContext;

        public PatientService(HospitalDbContext dbContext)
        {
            this._hospitalDbContext = dbContext;   
        }

        public void AddPatient(Patient patient)
        {
           this._hospitalDbContext.Patients.Add(patient);
        }

        public IReadOnlyList<PatientDTO> GetAllPatients()
        {
            List<Patient> patients = this._hospitalDbContext.Patients.ToList();
            
            return patients.Adapt<IReadOnlyList<PatientDTO>>();
        }

        public PatientDTO GetPatientById(int patientId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePatient(int PatientId)
        {
            Patient patient = this._hospitalDbContext
                .Patients
                .FirstOrDefault(x => x.Id == PatientId);

            if (patient == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            this._hospitalDbContext.Patients.Remove(patient);
            bool isRemoved =  this._hospitalDbContext.SaveChanges() == 1;

            return isRemoved;
        }
    }
}
