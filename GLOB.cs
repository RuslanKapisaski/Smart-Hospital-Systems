using Hospital_System.DAL.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public static class GLOB
    {
        public static UserDTO LogedUser { get; set; }
    }
}
