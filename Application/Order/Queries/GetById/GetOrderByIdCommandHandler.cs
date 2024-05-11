using Application.Abstractions;
using Application.Order.Contracts;
using Domain.Repositories;
using Mapster;

namespace Application.Order.Queries.GetById;

public class GetOrderByIdCommandHandler(IOrderRepository orderRepository)
    : IQueryHandler<GetOrderByIdCommand, OrderResponse>
{
    private readonly IOrderRepository orderRepository = orderRepository;

    public async Task<OrderResponse> Handle(GetOrderByIdCommand request, CancellationToken cancellationToken)
    {
        var order = await orderRepository.GetOrderByIdAsync(request.Id);

        return order.Adapt<OrderResponse>();
    }
}
