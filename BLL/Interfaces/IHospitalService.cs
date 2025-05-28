namespace Hospital_System.BLL.Interfaces
{
    using Hospital_System.DAL.Models.DTOs;
    using System.Collections.Generic;

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
