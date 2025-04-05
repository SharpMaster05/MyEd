namespace MyEd.DAL.Abstractions;

public interface IRepository<T>
    where T : class, new()
{
    Task AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task EditAsync(T entity);
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
}
