using Hospital_System.BLL.Interfaces;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.Models;
using Hospital_System.Utils;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.DAL.Services
{
    class HospitalService : IHospitalService
    {
        private readonly HospitalDbContext _hospitalDbContext;

        public HospitalService(HospitalDbContext hospitalDbContext)
        {
            this._hospitalDbContext = hospitalDbContext;
        }

        public bool AddHospital(HospitalDTO hospitalDTO)
        {
            if (hospitalDTO != null)
            {
                this._hospitalDbContext.Hospitals.Add(hospitalDTO.Adapt<Hospital>());
                bool isAdded = this._hospitalDbContext.SaveChanges() == 1;

                return isAdded;
            }
            else
            {
                return false;
            }

        }

        public bool DeleteHospital(int hospitalId)
        {
            var hospital = CheckIfHospitalExist(hospitalId);
            if (hospital != null)
            {
                throw new ArgumentException(ExceptionMessages.HospitalNotFound);
            }
            else
            {
                this._hospitalDbContext.Hospitals.Remove(hospital);
                bool isDeleted = this._hospitalDbContext.SaveChanges() == 1;
                return isDeleted;
            }
        }

        public HospitalDTO GetHospitalById(int hospitalId)
        {
            var hospital = CheckIfHospitalExist(hospitalId);
            if (hospital == null)
            {
                throw new ArgumentException(ExceptionMessages.HospitalNotFound);
            }
            else
            {
                return hospital.Adapt<HospitalDTO>();
            }
        }

        public HospitalDTO GetHospitalByName(string hospitalName)
        {
            var hospital = this._hospitalDbContext.Hospitals.Find(hospitalName);
            if (hospital == null)
            {
                throw new ArgumentException(ExceptionMessages.HospitalNotFound);
            }
            else
            {
                return hospital.Adapt<HospitalDTO>();
            }

        }

        public IReadOnlyList<HospitalDTO> GetAllHospitals()
        {
            var hospitals = this._hospitalDbContext.Hospitals.ToList();

            return hospitals.Adapt<IReadOnlyList<HospitalDTO>>();

        }

        public IReadOnlyList<AppointmentDTO> GetAllHospitalAppointments()
        {
            //Nice to have iclude() method for doctors that are in the specific appointment
            try
            {
                var appointments = this._hospitalDbContext
                 .Hospitals
                 .SelectMany(h => h.Appointments)
                 .ToList();

                return appointments.Adapt<IReadOnlyList<AppointmentDTO>>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IReadOnlyList<DoctorDTO> GetAllHospitalDoctors()
        {
            try
            {
                var doctors = this._hospitalDbContext
                     .Hospitals
                     .SelectMany(d => d.Doctors)
                     .ToList();

                return doctors.Adapt<IReadOnlyList<DoctorDTO>>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IReadOnlyList<PatientDTO> GetAllHospitalPatients()
        {
            try
            {
                var patients = this._hospitalDbContext
                    .Hospitals
                    .SelectMany(p => p.Patients)
                    .ToList();

                return patients.Adapt<IReadOnlyList<PatientDTO>>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Hospital CheckIfHospitalExist(int hospitalId)
        {
            var hospital = this._hospitalDbContext.Hospitals.Find(hospitalId);

            if (hospital != null)
            {
                return hospital;
            }
            else
            {
                return null;
            }
        }

    }


}
