
namespace Hospital_System.Models
{
    using System;
    using Hospital_System.DAL.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Appointment
    {

        [Key]
        public int AppointmentId { get; set; }

        [ForeignKey (nameof(Patient))]
        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }

        [ForeignKey (nameof(Doctor))]
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        public DateTime? AppointmentDate { get; set; }

        public AppointmentStatus Status { get; set; }
    }
}
