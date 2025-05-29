using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.DAL.Models;


[Table("hospitals")]
public partial class Hospital
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

    [Required]
    [MaxLength(50)]
    public string HospitalDescription { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
