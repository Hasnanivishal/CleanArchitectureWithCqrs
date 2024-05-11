using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories;

public sealed class CustomerRepository(ApplicationDbContext applicationDbContext) : ICustomerRepository
{
    private readonly ApplicationDbContext applicationDbContext = applicationDbContext;

    public Task<List<Customer>> GetAsync() => applicationDbContext.Customers.ToListAsync();

    public Task<Customer> GetByIdAsync(Guid customerId)
    {
        return applicationDbContext.Customers.FirstAsync(x => x.CustomerId == customerId); ;
    }

    public Task<Customer> Insert(Customer customer)
    {
        applicationDbContext.Add(customer);

        return Task.FromResult(customer);
    }

    public Task<Customer> Update(Customer customer)
    {
        applicationDbContext.Update(customer);

        return Task.FromResult(customer);
    }
}
