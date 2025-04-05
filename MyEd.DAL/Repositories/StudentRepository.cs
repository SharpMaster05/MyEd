using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;

namespace MyEd.DAL.Repositories;

public class StudentRepository : GenericRepository<Student>
{
    public StudentRepository(AppDbContext context)
        : base(context) { }
}
