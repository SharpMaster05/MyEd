using AutoMapper;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Models;

namespace MyEd.BOL.Services;

public class StudentService : GenericService<StudentDto, Student>
{
    public StudentService(IRepository<Student> repository, IMapper mapper)
        : base(repository, mapper) { }
}
