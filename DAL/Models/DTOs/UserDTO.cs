using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.DAL.Models.DTOs
{
    public class UserDTO
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public RoleDTO Role { get; set; }
    }
}
