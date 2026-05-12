using CartFlow.Context;

namespace CartFlow.UnitOfWorks;

public sealed class UnitOfWork(AppDbContext dbContext)
{
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken) =>
        dbContext.SaveChangesAsync(cancellationToken); 
}