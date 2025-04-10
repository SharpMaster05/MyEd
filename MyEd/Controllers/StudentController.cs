using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : GenericController<StudentDto>
{
	public StudentController(IService<StudentDto> service) : base(service)
	{
	}
}
