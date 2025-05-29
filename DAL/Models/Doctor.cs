using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.DAL.Models;


[Table("doctors")]
public partial class Doctor
{
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Specialization { get; set; }

    [ForeignKey(nameof(Hospital))]
    public int HospitalId { get; set; }

    public List<int> Schedules { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [ForeignKey(nameof(HospitalId))]
    public virtual Hospital Hospital { get; set; }

    [ForeignKey(nameof(Id))]
    public virtual User IdNavigation { get; set; }
}
