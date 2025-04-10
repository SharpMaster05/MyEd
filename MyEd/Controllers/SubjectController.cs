using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubjectController : GenericController<SubjectDto>
{
    public SubjectController(IService<SubjectDto> service)
        : base(service) { }
}
