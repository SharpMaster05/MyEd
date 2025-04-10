using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.BOL.Services;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherController : GenericController<TeacherDto>
{
	public TeacherController(IService<TeacherDto> service) : base(service)
	{
	}
}
