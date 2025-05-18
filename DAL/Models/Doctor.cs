
namespace Hospital_System.Models
{
    using Hospital_System.DAL.Models.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Specialization { get; set; }


        public List<DoctorSchedule> Schedules { get; set; } = new List<DoctorSchedule>();
    }
}
