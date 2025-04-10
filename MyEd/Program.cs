using Microsoft.EntityFrameworkCore;
using MyEd.BOL.Abstractions;
using MyEd.BOL.DTOs;
using MyEd.BOL.Services;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;
using MyEd.DAL.Repositories;
using MyEd.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddScoped<IRepository<Teacher>, TeacherRepository>();
builder.Services.AddScoped<IRepository<Student>, StudentRepository>();
builder.Services.AddScoped<IRepository<Group>, GroupRepository>();
builder.Services.AddScoped<IRepository<Grade>, GradeRepository>();
builder.Services.AddScoped<IRepository<Subject>, SubjectRepository>();
builder.Services.AddScoped<IRepository<Role>, RoleRepository>();

builder.Services.AddScoped<IService<UserDto>, UserService>();
builder.Services.AddScoped<IService<TeacherDto>, TeacherService>();
builder.Services.AddScoped<IService<StudentDto>, StudentService>();
builder.Services.AddScoped<IService<GroupDto>, GroupService>();
builder.Services.AddScoped<IService<GradeDto>, GradeService>();
builder.Services.AddScoped<IService<SubjectDto>, SubjectService>();
builder.Services.AddScoped<IService<RoleDto>, RoleService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
