using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Models
{
    public class Billing
    {
        private string _status;

        public int billingId { get; set; }

        public int patientId { get; set; }

        public double amount { get; set; }

        public DateTime? billingDate { get; set; }

        public string billingtStatus
        {
            get => _status;
            set
            {
                if (value != "PENDING" || value != "PAID")
                    throw new ArgumentException("Billing state must be 'Pending' or 'Paid'");


            }            
        } 
    }

}
