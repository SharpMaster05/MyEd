using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;

namespace MyEd.DAL.Repositories;

public class TeacherRepository : GenericRepository<Teacher>
{
    public TeacherRepository(AppDbContext context)
        : base(context) { }
}
