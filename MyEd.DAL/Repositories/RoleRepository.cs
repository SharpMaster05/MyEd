using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;

namespace MyEd.DAL.Repositories;

public class RoleRepository : GenericRepository<Role>
{
    public RoleRepository(AppDbContext context)
        : base(context) { }
}
