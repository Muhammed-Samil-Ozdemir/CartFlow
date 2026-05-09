using CartFlow.Context;
using CartFlow.Models;

namespace CartFlow.Repositories;

public sealed class DiscountRepository(AppDbContext dbContext) : GenericRepository<Discount>(dbContext)
{
    
}