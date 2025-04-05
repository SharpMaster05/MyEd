using System.ComponentModel.DataAnnotations;

namespace MyEd.DAL.Models;

public class Group
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Title { get; set; } = string.Empty;
    public int? TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    public List<Student> Students { get; set; } = [];
    public List<Subject> Subjects { get; set; } = [];
}
