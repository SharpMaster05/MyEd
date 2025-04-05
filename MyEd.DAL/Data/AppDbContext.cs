using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using MyEd.DAL.Models;

namespace MyEd.DAL.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(u =>
        {
            u.ToTable("Users");
            u.HasOne(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
            u.HasIndex(x => x.Email).IsUnique();
        });

        modelBuilder.Entity<Teacher>(t =>
        {
            t.ToTable("Teachers");
            t.HasMany(x => x.Groups)
                .WithOne(x => x.Teacher)
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);
            t.HasMany(x => x.Subjects)
                .WithOne(x => x.Teacher)
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Student>(s =>
        {
            s.ToTable("Students");
            s.HasOne(x => x.Group)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.SetNull);
            s.HasMany(x => x.Grades)
                .WithOne(x => x.Student)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Group>(g =>
        {
            g.ToTable("Groups");
            g.HasMany(x => x.Students)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.SetNull);
            g.HasMany(x => x.Subjects)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Grade>(g =>
        {
            g.ToTable("Grades");
        });

        modelBuilder.Entity<Subject>(s =>
        {
            s.ToTable("Subjects");
            s.HasOne(x => x.Teacher)
                .WithMany(x => x.Subjects)
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);
            s.HasOne(x => x.Group)
                .WithMany(x => x.Subjects)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Subject> Subjects { get; set; }
}
