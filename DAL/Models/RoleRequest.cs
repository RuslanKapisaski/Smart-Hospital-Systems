using Hospital_System.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("role_requests")]
public class RoleRequest
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    [Column(TypeName = "timestamp without time zone")]
    public DateTime RequestedAt { get; set; } = DateTime.Now;

    public bool? IsApproved { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }

    public int RequestedRoleId { get; set; } 

    [ForeignKey("RequestedRoleId")]  
    public virtual Role RequestedRole { get; set; }
}

