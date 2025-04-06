using AutoMapper;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Models;

namespace MyEd.BOL.Services;

public class GradeService : GenericService<GradeDto, Grade>
{
    public GradeService(IRepository<Grade> repository, IMapper mapper)
        : base(repository, mapper) { }
}
