namespace Hospital_System.DAL.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("roles")]
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
