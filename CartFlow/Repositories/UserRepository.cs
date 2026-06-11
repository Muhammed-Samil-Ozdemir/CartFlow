using CartFlow.Abstractions;
using CartFlow.Context;
using CartFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CartFlow.Repositories;

public sealed class UserRepository(AppDbContext dbContext) : GenericRepository<User>(dbContext)
{
    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken) =>
        await DbSet.FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
}