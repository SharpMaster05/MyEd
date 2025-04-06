using AutoMapper;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Models;

namespace MyEd.BOL.Services;

public class GroupService : GenericService<GroupDto, Group>
{
    public GroupService(IRepository<Group> repository, IMapper mapper)
        : base(repository, mapper) { }
}
