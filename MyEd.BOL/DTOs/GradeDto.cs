namespace MyEd.BOL.DTOs;

public class GradeDto
{
    public int Id { get; set; }
    public int Value { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public int? StudentId { get; set; }
}
