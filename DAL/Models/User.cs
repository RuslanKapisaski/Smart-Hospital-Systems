using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_System.DAL.Models;

[Table("users")]
public partial class User
{


    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(20)]
    public string LastName { get; set; }
    [MaxLength(30)]
    public string Email { get; set; }
    [Required]
    [MaxLength(30)]
    public string Password { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    public DateTime RegistrationDate { get; set; }

    public int? LinkedPatientId { get; set; }

    public int? LinkedDoctorId { get; set; }

    //Navigational
    public virtual Doctor Doctor { get; set; }

    public virtual Patient Patient { get; set; }

    public virtual Role Role { get; set; }
}
