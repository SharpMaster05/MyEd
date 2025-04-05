using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;

namespace MyEd.DAL.Repositories;

public class GroupRepository : GenericRepository<Group>
{
    public GroupRepository(AppDbContext context)
        : base(context) { }
}
