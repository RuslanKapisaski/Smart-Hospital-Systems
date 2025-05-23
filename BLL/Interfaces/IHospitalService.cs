using Hospital_System.DAL.Models;
using Hospital_System.DAL.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    interface IHospitalService
    {
        bool AddHospital(HospitalDTO hospitalDTO);

        bool DeleteHospital(int hospitalId);

        HospitalDTO GetHospitalById(int id);

        HospitalDTO GetHospitalByName(string hospitalName);

        IReadOnlyList<HospitalDTO> GetAllHospitals();
        //NB - > all services
        IReadOnlyList<PatientDTO> GetAllHospitalPatients();

        IReadOnlyList<DoctorDTO> GetAllHospitalDoctors();

        IReadOnlyList<AppointmentDTO> GetAllHospitalAppointments();
    }
}
