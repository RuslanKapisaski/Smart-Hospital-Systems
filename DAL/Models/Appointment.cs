using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.DAL.Models;


[Table("appointments")]
public partial class Appointment
{
    [Key]
    public int AppointmentId { get; set; }

    [ForeignKey(nameof(Patient))]
    public int PatientId { get; set; }

    [ForeignKey(nameof(Doctor))] 
    public int DoctorId { get; set; }

    public DateTime? AppointmentDate { get; set; }

    [Required]
    public int Status { get; set; }

    public int? HospitalId { get; set; }

    public virtual Doctor Doctor { get; set; }

    public virtual Hospital Hospital { get; set; }

    public virtual Patient Patient { get; set; }
}
