using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Models
{
    public class Patient
    {
        public enum genderState{
            M,
            F
        }


        int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public genderState gender { get; set; }

        public string address { get; set; }

        public string insuranceInfo { get; set; }


    }
}
