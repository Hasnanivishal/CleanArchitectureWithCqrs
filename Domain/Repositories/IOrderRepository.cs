using Domain.Entities;

namespace Domain.Repositories;

public interface IOrderRepository
{
    /// <summary>
    /// Get Order by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Order</returns>
    Task<Order> GetOrderAsync(int id);

    /// <summary>
    /// Create a Order
    /// </summary>
    /// <param name="order"></param>
    void CreateOrder(Order order);

    /// <summary>
    /// Get Orders by Customer Id
    /// </summary>
    /// <param name="customerId"></param>
    /// <returns>List of Orders</returns>
    Task<IEnumerable<Order>> GetOrderByCustomerIdAsync(int customerId);
}
