using Application.Abstractions;
using Application.Order.Contracts;

namespace Application.Order.Queries.GetById;

public sealed record GetOrderByIdCommand(Guid Id) : IQuery<OrderResponse>;
