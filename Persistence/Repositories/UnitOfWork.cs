using Domain.Repositories;
using Persistence.Context;
namespace Persistence.Repositories;

public sealed class UnitOfWork(ApplicationDbContext applicationDbContext) : IUnitOfWork
{
    private readonly ApplicationDbContext applicationDbContext = applicationDbContext;

    public Task<int> SaveChangesAsync() => applicationDbContext.SaveChangesAsync();
}
