using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Models;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : GenericController<UserDto>
{
    public UserController(IService<UserDto> service)
        : base(service) { }
}
