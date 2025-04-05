namespace MyEd.DAL.Models;

public class Student : User
{
    public int? GroupId { get; set; }
    public Group? Group { get; set; }
    public List<Grade> Grades { get; set; } = [];
    public List<Subject> Subjects { get; set; } = [];
}
