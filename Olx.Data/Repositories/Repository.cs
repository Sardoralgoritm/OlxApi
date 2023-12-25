using Microsoft.EntityFrameworkCore;
using Olx.Data.DataContext;
using Olx.Data.Interfaces;
using Olx.Domain.Models;

namespace Olx.Data.Repositories;

public class Repository<T>(AppDb appDb) : IRepository<T> where T : BaseModel
{
    protected DbSet<T> _dbSet = appDb.Set<T>();

    public async Task CreateAsync(T entity) => await _dbSet.AddAsync(entity);

    public void Delete(T entity) => _dbSet.Remove(entity);

    public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

    public async Task<T> GetByIdAsync(int id) => await _dbSet.FirstOrDefaultAsync(i => i.Id == id);

    public void Update(T entity) => _dbSet.Update(entity);
}
