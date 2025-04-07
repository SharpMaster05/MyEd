using Microsoft.EntityFrameworkCore;
using MyEd.BOL.Services;
using MyEd.DAL.Abstractions;
using MyEd.DAL.Data;
using MyEd.DAL.Models;
using MyEd.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddScoped<IRepository<Teacher>, TeacherRepository>();
builder.Services.AddScoped<IRepository<Student>, StudentRepository>();
builder.Services.AddScoped<IRepository<Group>, GroupRepository>();
builder.Services.AddScoped<IRepository<Grade>, GradeRepository>();
builder.Services.AddScoped<IRepository<Subject>, SubjectRepository>();
builder.Services.AddScoped<IRepository<Role>, RoleRepository>();

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<TeacherService>();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<GroupService>();
builder.Services.AddScoped<GradeService>();
builder.Services.AddScoped<SubjectService>();
builder.Services.AddScoped<RoleService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
