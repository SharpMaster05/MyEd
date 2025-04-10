using AutoMapper;
using MyEd.BOL.DTOs;
using MyEd.DAL.Models;

namespace MyEd.Infrastructure;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
        CreateMap<TeacherDto, Teacher>().ReverseMap();
        CreateMap<StudentDto, Student>().ReverseMap();
        CreateMap<GroupDto, Group>().ReverseMap();
        CreateMap<GradeDto, Grade>().ReverseMap();
        CreateMap<SubjectDto, Subject>().ReverseMap();
        CreateMap<RoleDto, Role>().ReverseMap();
    }
}
