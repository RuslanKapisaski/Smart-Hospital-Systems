using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.DAL.Models.DTOs
{
    public  class HospitalDTO
    {
        
        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public string HospitalDescription { get; set; }

        public string Email { get; set; }

    }
}
