using CartFlow.Abstractions;
using CartFlow.Context;
using CartFlow.Models;

namespace CartFlow.Repositories;

public class CategoryRepository(AppDbContext dbContext) : GenericRepository<Category>(dbContext)
{
    
}