using System.Linq.Expressions;
using CartFlow.Context;
using Microsoft.EntityFrameworkCore;

namespace CartFlow.Abstractions;

public abstract class GenericRepository<T>(AppDbContext dbContext) where T : class
{
    protected readonly DbSet<T> DbSet = dbContext.Set<T>();
    
    public async Task AddAsync(T entity, CancellationToken cancellationToken) =>
        await DbSet.AddAsync(entity, cancellationToken);

    public Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken) =>
        DbSet.AddRangeAsync(entities, cancellationToken);

    public void Update(T entity) => DbSet.Update(entity);

    public void UpdateRange(IEnumerable<T> entities) => DbSet.UpdateRange(entities);

    public async Task RemoveByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var entity = await DbSet.FindAsync(id, cancellationToken);
        if (entity is not null)
            DbSet.Remove(entity);
    }

    public void Remove(T entity) => DbSet.Remove(entity);

    public void RemoveRange(IEnumerable<T> entities) => DbSet.RemoveRange(entities);

    public IQueryable<T> GetAll() => DbSet.AsQueryable();

    public Task<List<T>> GetAllAsync(CancellationToken cancellationToken) => DbSet.ToListAsync(cancellationToken);
    public IQueryable<T> GetAllQueryable() => DbSet.AsQueryable();

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression) => DbSet.Where(expression);

    public ValueTask<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        DbSet.FindAsync(id, cancellationToken);

    public Task<T?> GetFirstByExpressionAsync(Expression<Func<T, bool>> expression,
        CancellationToken cancellationToken) => DbSet.FirstOrDefaultAsync(expression, cancellationToken);

    public Task<T?> GetFirst(CancellationToken cancellationToken) => DbSet.FirstOrDefaultAsync(cancellationToken);

    public Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken) => 
        DbSet.AnyAsync(expression, cancellationToken);
    
    
}