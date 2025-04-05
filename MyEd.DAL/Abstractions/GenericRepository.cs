using Microsoft.EntityFrameworkCore;
using MyEd.DAL.Data;

namespace MyEd.DAL.Abstractions;

public class GenericRepository<T>(AppDbContext context) : IRepository<T>
    where T : class, new()
{
    private readonly AppDbContext _context = context;

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task EditAsync(T entity)
    {
        _context.Set<T>().Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
}
