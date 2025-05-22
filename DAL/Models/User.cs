namespace Hospital_System.DAL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
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

        public DateTime RegistrationDate
        { get; set; } = DateTime.UtcNow;

        //[ForeignKey(nameof(Role))]
        public int? RoleId { get; set; }

        public Role Role { get; set; }

        public int? LinkedPatientId { get; set; }

        public int? LinkedDoctorId { get; set; }

    }
}
