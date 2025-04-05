using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;

namespace MyEd.DAL.Repositories;

public class GradeRepository : GenericRepository<Grade>
{
    public GradeRepository(AppDbContext context)
        : base(context) { }
}
