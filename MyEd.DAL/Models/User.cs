using System.ComponentModel.DataAnnotations;

namespace MyEd.DAL.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Lastname { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    [MaxLength(20)]
    [RegularExpression(
        @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*?&]{6,20}$",
        ErrorMessage = "Password must be 6-20 characters long and include at least one letter and one number."
    )]
    public string Password { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public int? RoleId { get; set; }
    public Role? Role { get; set; }
}
