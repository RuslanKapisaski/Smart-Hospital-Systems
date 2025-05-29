using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.DAL.Models;


[Table("payments")]
public partial class Payment
{
    [Key] // Explicit primary key annotation
    public int PaymentId { get; set; }

    public int BillingId { get; set; }

    public int PatientId { get; set; }

    public decimal Price { get; set; }

    public DateTime BillingDate { get; set; }

    [Required]
    public int Status { get; set; }

    [ForeignKey(nameof(PatientId))]
    public virtual Patient Patient { get; set; }
}
