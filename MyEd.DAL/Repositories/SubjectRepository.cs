using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;

namespace MyEd.DAL.Repositories;

public class SubjectRepository : GenericRepository<Subject>
{
    public SubjectRepository(AppDbContext context)
        : base(context) { }
}
