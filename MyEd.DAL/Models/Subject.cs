using System.ComponentModel.DataAnnotations;

namespace MyEd.DAL.Models;

public class Subject
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;
    public int? GroupId { get; set; }
    public int? TeacherId { get; set; }
    public Group? Group { get; set; }
    public Teacher? Teacher { get; set; }
}
