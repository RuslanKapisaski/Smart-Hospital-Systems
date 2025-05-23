namespace Hospital_System.BLL.Interfaces
{
    using Hospital_System.DAL.Models.DTOs;
    using Hospital_System.DAL.Models.Enums;
    using System.Collections.Generic;

    interface IAppointmentService
    {
        void AddAppointment(AppointmentDTO appointmentDto);
        void EditAppointmentStatus(int appointmentDTOId, AppointmentStatus status );
        bool DeleteAppointment(int appointmenrId);
        bool IsConducted(int appointmentId);
        string GetPaymentStaus(int status);
        AppointmentDTO FindByID(int appointmentDtoId);
        AppointmentDTO GetAppointment(int appointmenrId);
        IReadOnlyList<AppointmentDTO> GetAllAppointments();
    }
}
