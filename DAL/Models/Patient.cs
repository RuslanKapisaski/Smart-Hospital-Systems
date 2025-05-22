
namespace Hospital_System.Models
{
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Models.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Patient : User
    {
        [ForeignKey(nameof(Hospital))]
        public int HospitalId { get; set; }

        [Required]
        public GenderState? Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string InsuranceInfo { get; set; }

        //Navigational
        public Hospital Hospital { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
