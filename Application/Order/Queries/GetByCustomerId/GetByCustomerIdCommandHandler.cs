using Application.Abstractions;
using Application.Order.Contracts;
using Domain.Repositories;
using Mapster;

namespace Application.Order.Queries.GetByCustomerId;

public sealed class GetByCustomerIdCommandHandler(IOrderRepository orderRepository) :
    IQueryHandler<GetByCustomerIdCommand, List<OrderResponse>>
{
    private readonly IOrderRepository orderRepository = orderRepository;

    public async Task<List<OrderResponse>> Handle(GetByCustomerIdCommand request, CancellationToken cancellationToken)
    {
        var orders = await orderRepository.GetOrderByCustomerIdAsync(request.CustomerId);

        return orders.Adapt<List<OrderResponse>>();
    }
}
