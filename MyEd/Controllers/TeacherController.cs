using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Services;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    private readonly TeacherService _teacherService;

    public TeacherController(TeacherService teacherService)
    {
        _teacherService = teacherService;
    }
}
