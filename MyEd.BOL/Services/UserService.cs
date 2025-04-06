using AutoMapper;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Models;

namespace MyEd.BOL.Services;

public class UserService : GenericService<UserDto, User>
{
    public UserService(IRepository<User> repository, IMapper mapper)
        : base(repository, mapper) { }
}
