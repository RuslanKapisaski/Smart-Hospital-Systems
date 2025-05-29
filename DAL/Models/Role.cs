using Hospital_System.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.DAL.Models;


[Table("roles")]
public partial class Role
{
    [Key]
    [Required]
    public int RoleId { get; set; }

    [Required]
    [MaxLength(10)]
    public RoleType RoleName { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
