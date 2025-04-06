using AutoMapper;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Models;

namespace MyEd.BOL.Services;

public class RoleService : GenericService<RoleDto, Role>
{
    public RoleService(IRepository<Role> repository, IMapper mapper)
        : base(repository, mapper) { }
}
