using CartFlow.Context;
using CartFlow.Models;

namespace CartFlow.Repositories;

public sealed class CartItemRepository(AppDbContext dbContext) : GenericRepository<CartItem>(dbContext)
{
    
}