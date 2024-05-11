using Application.Abstractions;
using Application.Order.Contracts;

namespace Application.Order.Queries.GetByCustomerId;

public sealed record GetByCustomerIdCommand(Guid CustomerId) : IQuery<List<OrderResponse>>;
