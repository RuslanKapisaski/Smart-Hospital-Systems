using Hospital_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.DAL.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Address { get; set; }

        [MaxLength(10)]
        public string ContactNumber { get; set; }


        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime? EstablishedDate { get; set; }

        //Navigational 
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}