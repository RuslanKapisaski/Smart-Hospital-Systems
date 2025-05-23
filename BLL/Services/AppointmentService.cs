namespace Hospital_System.DAL.Services
{
    using Hospital_System.BLL.Interfaces;
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.DAL.Models.Enums;
    using Hospital_System.Models;
    using Hospital_System.Utils;
    using Mapster;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppointmentService : IAppointmentService
    {
        private readonly HospitalDbContext hospitalDbContext;

        public AppointmentService(HospitalDbContext dbContext)
        {
            this.hospitalDbContext = dbContext;
        }

        public void AddAppointment(AppointmentDTO appointmentDto)
        {
            var newAppointment = appointmentDto.Adapt<Appointment>();
            this.hospitalDbContext.Appointments.Add(newAppointment);
            this.hospitalDbContext.SaveChanges();
        }

        public bool DeleteAppointment(int appointmenrId)
        {
            var appointment = this.hospitalDbContext.Appointments.Find(appointmenrId);
            this.hospitalDbContext.Appointments.Remove(appointment);

            bool isDeleted = hospitalDbContext.SaveChanges() == 1;

            return isDeleted;

        }

        public void EditAppointmentStatus(int appointmentDTOId, AppointmentStatus status)
        {
            var appointment = this.hospitalDbContext.Appointments.Find(appointmentDTOId);

            if(appointment==null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAppointmentStatus);
            }
            else
            {
                appointment.Status = status;
                this.hospitalDbContext.SaveChanges();
            }

        }

        public AppointmentDTO GetAppointment(int appointmenrId)
        {
            var appointment = this.hospitalDbContext.Appointments.Find(appointmenrId);

            if (appointment == null)
            {
                throw new ArgumentException(ExceptionMessages.AppointmentNotFound);
            }
            else
            {

                return appointment.Adapt<AppointmentDTO>();
            }
        }

        public string GetPaymentStaus(int status)
        {
            if (!Enum.IsDefined(typeof(PaymentStatus), status))
            {
                throw new ArgumentException(ExceptionMessages.InvalidAppointmentStatus);
            }
                var isStatusFound = this.hospitalDbContext.Appointments.Any(a => a.Status == (AppointmentStatus)status);
            if (isStatusFound)
            {
                return "CONDUCTED";
            }
            else
            {
                return "EXPECTED";
            }
        }
        
        public AppointmentDTO FindByID(int appointmentDtoId)
        {
            Appointment appointment = this.hospitalDbContext.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentDtoId);

            return appointment.Adapt<AppointmentDTO>();
        }

        public IReadOnlyList<AppointmentDTO> GetAllAppointments()
        {
            var appointments = this.hospitalDbContext.Appointments.ToList();

            return appointments.Adapt<IReadOnlyList<AppointmentDTO>>();
        }
        public bool IsConducted(int appointmentId)
        {
            Appointment appointmentToCheck = this.hospitalDbContext.Appointments.Find(appointmentId);

            bool isConducted = appointmentToCheck.Status == AppointmentStatus.CONDUCTED; ;

            return isConducted;
        }
    }
}
