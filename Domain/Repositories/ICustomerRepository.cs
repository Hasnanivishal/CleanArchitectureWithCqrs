using Domain.Entities;

namespace Domain.Repositories;

public interface ICustomerRepository
{
    /// <summary>
    /// Get Customers
    /// </summary>
    /// <returns>List of Customer</returns>
    Task<List<Customer>> GetAsync();

    /// <summary>
    /// Get Customer by Id
    /// </summary>
    /// <param name="customerId"></param>
    /// <returns>Customer</returns>
    Task<Customer> GetByIdAsync(Guid customerId);

    /// <summary>
    /// Create Customer
    /// </summary>
    /// <param name="customer"></param>
    /// <returns>Customer</returns>
    Task<Customer> Insert(Customer customer);

    /// <summary>
    /// Update Customer
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    Task<Customer> Update(Customer customer);
}
