using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Models
{
    public class Appointment
    {
        public enum appointmentStatus{
            EXPRECTED,
            DONE
        }

        public int appointmentId { get; set; }

        public int patientId { get; set; }

        public int doctorId { get; set; }

        public DateTime? appointmentDate { get; set; }

        public appointmentStatus appostatus { get; set; }
    }
}
