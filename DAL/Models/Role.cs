using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.DAL.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(10)]
        public string roleName { get; set; }
    }
}
