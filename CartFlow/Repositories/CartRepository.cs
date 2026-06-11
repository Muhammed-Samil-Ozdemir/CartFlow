using CartFlow.Abstractions;
using CartFlow.Context;
using CartFlow.Models;

namespace CartFlow.Repositories;

public sealed class CartRepository(AppDbContext dbContext) : GenericRepository<Cart>(dbContext)
{
    
}