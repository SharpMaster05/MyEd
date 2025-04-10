using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupController : GenericController<GroupDto>
{
    public GroupController(IService<GroupDto> service)
        : base(service) { }
}
