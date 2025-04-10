using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GradeController : GenericController<GradeDto>
{
    public GradeController(IService<GradeDto> service)
        : base(service) { }
}
