using Application.Abstractions;
using Application.Customer.Contracts;

namespace Application.Customer.Queries.GetById;

public sealed record GetCustomerByIdQuery(Guid Id) : IQuery<CustomerResponse>;
