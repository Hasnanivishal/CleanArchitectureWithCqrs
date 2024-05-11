using Application.Abstractions;
using Application.Order.Contracts;
using Domain.Repositories;
using Mapster;

namespace Application.Order.Commands.Create;

internal class CreateOrderCommandHandler(IOrderRepository orderRepository,
    ICustomerRepository customerRepository,
    IUnitOfWork unitOfWork)
    : ICommandHandler<CreateOrderCommand, OrderResponse>
{
    private readonly IOrderRepository orderRepository = orderRepository;
    private readonly ICustomerRepository customerRepository = customerRepository;
    private readonly IUnitOfWork unitOfWork = unitOfWork;

    public async Task<OrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Domain.Entities.Order()
        {
            CustomerId = request.CustomerId,
            Description = request.Description,
            Name = request.Name,
            OrderId = Guid.NewGuid(),
            Price = request.Price
        };

        await orderRepository.CreateOrder(order);

        // Deduct the Available amount for the customer once order is placed.
        var customer = await customerRepository.GetByIdAsync(request.CustomerId);
        customer.AvailableBalance -= request.Price;

        await customerRepository.Update(customer);

        await unitOfWork.SaveChangesAsync();

        return order.Adapt<OrderResponse>();
    }
}
