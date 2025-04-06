namespace MyEd.BOL.DTOs;

public class SubjectDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int? GroupId { get; set; }
    public int? TeacherId { get; set; }
}
