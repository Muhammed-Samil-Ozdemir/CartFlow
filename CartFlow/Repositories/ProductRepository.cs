using CartFlow.Abstractions;
using CartFlow.Context;
using CartFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CartFlow.Repositories;

public sealed class ProductRepository(AppDbContext dbContext) : GenericRepository<Product>(dbContext)
{
    public new Task<List<Product>> GetAllAsync(CancellationToken cancellationToken) => 
        DbSet.Include(p => p.Category).ToListAsync(cancellationToken);
}