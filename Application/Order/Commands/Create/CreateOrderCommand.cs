using Application.Abstractions;
using Application.Order.Contracts;

namespace Application.Order.Commands.Create;

public record class CreateOrderCommand(string Name,
    string Description,
    double Price,
    Guid CustomerId) : ICommand<OrderResponse>;
