using CartFlow.Context;
using CartFlow.Models;

namespace CartFlow.Repositories;

public sealed class CouponRepository(AppDbContext dbContext) : GenericRepository<Coupon>(dbContext)
{
    
}