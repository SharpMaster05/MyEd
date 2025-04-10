namespace MyEd.BOL.DTOs;

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public int? RoleId { get; set; }
}
