using CartFlow.Abstractions;
using CartFlow.Context;
using CartFlow.Models;

namespace CartFlow.Repositories;

public sealed class ProductRepository(AppDbContext dbContext) : GenericRepository<Product>(dbContext)
{
    
}