using Hospital_System.BLL.Interfaces;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.Models;
using Hospital_System.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.DAL.Services
{
    class PatientService : IPatientService
    {
        private readonly HospitalDbContext dbContext;

        public void AddPatient(Patient patient)
        {
           this.dbContext.Patients.Add(patient);
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = this.dbContext.Patients.ToList();
            
            return patients;
        }

        public Patient GetPatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePatient(int PatientId)
        {
            Patient patient = this.dbContext.Patients.FirstOrDefault(x => x.Id == PatientId);

            if (patient == null)
            {
                throw new ArgumentException(ExceptionMessages.UserNotFound);
            }

            this.dbContext.Patients.Remove(patient);
            bool isRemoved =  this.dbContext.SaveChanges() == 1;

            return isRemoved;
        }
    }
}
