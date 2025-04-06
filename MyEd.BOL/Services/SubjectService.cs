using AutoMapper;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Models;

namespace MyEd.BOL.Services;

public class SubjectService : GenericService<SubjectDto, Subject>
{
    public SubjectService(IRepository<Subject> repository, IMapper mapper)
        : base(repository, mapper) { }
}
