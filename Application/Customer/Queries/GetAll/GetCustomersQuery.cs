using Application.Abstractions;
using Application.Customer.Contracts;

namespace Application.Customer.Queries.GetAll;

public sealed class GetCustomersQuery() : IQuery<List<CustomerResponse>>;
