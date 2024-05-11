using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public sealed class OrderRepository(ApplicationDbContext applicationDbContext) : IOrderRepository
    {
        private readonly ApplicationDbContext applicationDbContext = applicationDbContext;

        public Task<Order> CreateOrder(Order order)
        {
            applicationDbContext.Orders.Add(order);

            return Task.FromResult(order);
        }

        public Task<List<Order>> GetOrderByCustomerIdAsync(Guid customerId)
        {
            return applicationDbContext.Orders.Where(x => x.CustomerId == customerId).ToListAsync();
        }

        public Task<Order> GetOrderByIdAsync(Guid id)
        {
            return applicationDbContext.Orders.FirstAsync(x => x.OrderId == id);
        }
    }
}
