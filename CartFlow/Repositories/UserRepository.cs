using CartFlow.Context;
using CartFlow.Models;

namespace CartFlow.Repositories;

public sealed class UserRepository(AppDbContext dbContext) : GenericRepository<User>(dbContext)
{
    
}