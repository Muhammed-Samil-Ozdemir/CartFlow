using CartFlow.Abstractions;
using CartFlow.Context;
using CartFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CartFlow.Repositories;

public sealed class CartItemRepository(AppDbContext dbContext) : GenericRepository<CartItem>(dbContext)
{
    public async Task<List<CartItem>> GetByCartIdAsync(Guid cartId, CancellationToken cancellationToken) =>
        await DbSet.Where(ci => ci.CartId == cartId).ToListAsync(cancellationToken);
}