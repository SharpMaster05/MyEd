using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;

namespace MyEd.DAL.Repositories;

public class UserRepository : GenericRepository<User>
{
    public UserRepository(AppDbContext context)
        : base(context) { }
}
