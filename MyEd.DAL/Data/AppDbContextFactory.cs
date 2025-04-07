using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyEd.DAL.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "MyEd");

        var config = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", true, true)
            .Build();

        var options = new DbContextOptionsBuilder<AppDbContext>();

        string connectionString =
            config.GetConnectionString("DefaultConnection")
            ?? throw new Exception("connection string is not correct!");

        options.UseSqlServer(connectionString);

        return new AppDbContext(options.Options);
    }
}
