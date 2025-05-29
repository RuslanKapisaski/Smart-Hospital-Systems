using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.DAL.Models;


[Table("patients")]
public partial class Patient
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Hospital))]
    public int HospitalId { get; set; }
    [Required]
    public int Gender { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string InsuranceInfo { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [ForeignKey(nameof(HospitalId))]
    public virtual Hospital Hospital { get; set; }

    [ForeignKey(nameof(Id))]
    public virtual User IdNavigation { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
