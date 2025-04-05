using System.ComponentModel.DataAnnotations;

namespace MyEd.DAL.Models;

public class Role
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public List<User> Users { get; set; } = [];
}
