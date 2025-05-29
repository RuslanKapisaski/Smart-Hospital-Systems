using Hospital_System.BLL.Interfaces;
using Hospital_System.DAL.DB;
using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using Hospital_System.DAL.Models.Enums;
using Hospital_System.Utils;
using Mapster;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hospital_System.DAL.Services
{
    class DoctorService : IDoctorService
    {
        private readonly HospitalDbContext hospitalDbContext;

        public DoctorService(HospitalDbContext hospitalDbContext)
        {
            this.hospitalDbContext = hospitalDbContext;
        }

        public void AddDoctor(DoctorDTO doctorDto)
        {
            this.hospitalDbContext.Doctors.Add(doctorDto.Adapt<Doctor>());
            this.hospitalDbContext.SaveChanges();
        }

        public void AddDoctorAppointment(int doctorId, AppointmentDTO appointmentDto)
        {
            var doctor = CheckIfDoctorExistByID(doctorId);
            if (doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }
            doctor.Appointments.Add(appointmentDto.Adapt<Appointment>());
        }

        public void AddDoctorSchedule(int doctorId, DoctorSchedule newSchedule )
        {
            var doctor = CheckIfDoctorExistByID(doctorId);
            if (doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }
            else
            {
                doctor.Schedules.Add((int)newSchedule);
                this.hospitalDbContext.SaveChanges();
            }
        }

        public void AddDoctorSpecialization(int doctorId, string newSpecialization)
        {
            var doctor = CheckIfDoctorExistByID(doctorId);

            if (doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }

            if (doctor.Specialization != null)
            {
                throw new ArgumentException(ExceptionMessages.SpecializationAlreadyExist);
            }

            else
            {
                doctor.Specialization = newSpecialization;
            }
        }

        public List<AppointmentDTO> GetDoctorAppointment(int doctorId)
        {
            var doctor = CheckIfDoctorExistByID(doctorId);

            if(doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }
            else
            {
                return doctor.Appointments.Adapt<List<AppointmentDTO>>();
            }
        }

        public DoctorDTO GetDoctorById(int doctorID)
        {
            var doctor = CheckIfDoctorExistByID(doctorID);

            if(doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }
            else
            {
                return doctor.Adapt<DoctorDTO>();
            }
        }

        public DoctorDTO GetDoctorByFullName(string doctorName)
        {
            //Empty space 
            var doctor = this.hospitalDbContext
                .Users
                .Where(u => u.Id == 2)
                .Select(x => $"{x.FirstName}" + " " + $"{x.LastName}" == doctorName);
            
            if(doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }
            else
            {
                return doctor.Adapt<DoctorDTO>();
            }
        }

        public ICollection GetDoctorSchedule(int doctorId)
        {
            var doctor = CheckIfDoctorExistByID(doctorId);
            if (doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }
            else
            {
                var doctorSchedules = doctor.Schedules.ToList();
                return doctorSchedules;
            }
        }

        public string GetDoctorSpecialization(int doctorId)
        {
            var doctor = CheckIfDoctorExistByID(doctorId);

            if(doctor == null)
            {
                throw new ArgumentException(ExceptionMessages.DoctorNotFound);
            }
            else
            {
                return doctor.Specialization.ToString();
            }
        }

        private Doctor CheckIfDoctorExistByID(int doctorId)
        {
            var doctor = this.hospitalDbContext
                .Users
                .OfType<Doctor>()
                .FirstOrDefault(d => d.Id == doctorId);

            if (doctor != null)
            {
                return doctor;
            }
            else
            {
                return null;
            }
        }

    }
}
