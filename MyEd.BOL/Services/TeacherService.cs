using AutoMapper;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Models;

namespace MyEd.BOL.Services;

public class TeacherService : GenericService<TeacherDto, Teacher>
{
    public TeacherService(IRepository<Teacher> repository, IMapper mapper)
        : base(repository, mapper) { }
}
