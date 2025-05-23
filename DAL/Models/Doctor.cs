
namespace Hospital_System.Models
{
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Models.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("doctors")]
    public class Doctor:User
    {

        [Required]
        [MaxLength(30)]
        public string Specialization { get; set; }

        [ForeignKey(nameof(Hospital))]
        public int HospitalId { get; set; }


        public ICollection<Appointment> Appointments { get; set; }

        [Required]
        public ICollection<DoctorSchedule> Schedules { get; set; }
    
        //Navigational
        public Hospital Hospital { get; set; }
    }
}
