using System.ComponentModel.DataAnnotations;

namespace MyEd.DAL.Models;

public class Grade
{
    [Key]
    public int Id { get; set; }

    [Range(0, 100)]
    public int Value { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public int? StudentId { get; set; }
    public Student? Student { get; set; }
}
