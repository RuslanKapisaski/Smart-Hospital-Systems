using Hospital_System.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.BLL.Interfaces
{
    interface IHospitalService
    {
        List<Hospital> GetAllHospitals();

        bool RemoveHospital();

        bool AddHospital();

        bool DeleteHospital(int id);

        bool UpdateHospital(Hospital hospital);

        Hospital GetHospital(int id);

    }
}
