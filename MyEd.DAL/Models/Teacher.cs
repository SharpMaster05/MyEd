namespace MyEd.DAL.Models;

public class Teacher : User
{
    public List<Group> Groups { get; set; } = [];
    public List<Subject> Subjects { get; set; } = [];
}
