using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoleController : GenericController<RoleDto>
{
    public RoleController(IService<RoleDto> service)
        : base(service) { }
}
