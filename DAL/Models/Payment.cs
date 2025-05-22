
namespace Hospital_System.Models
{
    using System;
    using Hospital_System.DAL.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Payment
    {
 
        [Key]
        public int BillingId { get; set; }

        [ForeignKey (nameof(Patient))]
        public int PatientId { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime? BillingDate { get; set; }

        [Required]
        public PaymentStatus? Status { get; set; }

        public virtual Patient Patient { get; set; }
    }

}
