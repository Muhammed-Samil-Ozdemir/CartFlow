using CartFlow.Context;
using CartFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CartFlow.Repositories;

public sealed class CouponRepository(AppDbContext dbContext) : GenericRepository<Coupon>(dbContext)
{
    public Task<Coupon?> GetByCodeAsync(string code, CancellationToken cancellationToken) =>
        DbSet.FirstOrDefaultAsync(c => c.Code == code, cancellationToken);
}