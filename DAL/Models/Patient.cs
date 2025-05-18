
namespace Hospital_System.Models
{
    using Hospital_System.DAL.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Patient
    {
        [Key]
        int patientId { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        
        [Required]
        public GenderState? Gender { get; set; }

        [Required]
        public string Address { get; set; }
        
        [Required]
        public string InsuranceInfo { get; set; }


    }
}
