using Hospital_System.DAL.Models.DTOs;
using Hospital_System.DAL.Models.Enums;
using Hospital_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    interface IDoctorService
    {
        void AddDoctor(DoctorDTO doctorDTO);

        void AddDoctorSpecialization(int doctorId,string specialization);

        void AddDoctorAppointment(int doctorId,AppointmentDTO appointmentDto);

        void AddDoctorSchedule(int doctorId, DoctorSchedule doctorSchedule);

        string GetDoctorSpecialization(int doctorId);

        List<AppointmentDTO> GetDoctorAppointment(int doctorId);

        ICollection GetDoctorSchedule(int doctorId);

        DoctorDTO GetDoctorById(int doctorID);

        DoctorDTO GetDoctorByFullName(string doctorName);
    }
}
