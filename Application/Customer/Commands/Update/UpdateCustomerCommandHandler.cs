using Application.Abstractions;
using Application.Customer.Contracts;
using Domain.Repositories;
using Mapster;

namespace Application.Customer.Commands.Update;

public class UpdateCustomerCommandHandler(ICustomerRepository customerRepository,
    IUnitOfWork unitOfWork)
    : ICommandHandler<UpdateCustomerCommand, CustomerResponse>
{
    private readonly ICustomerRepository customerRepository = customerRepository;
    private readonly IUnitOfWork unitOfWork = unitOfWork;

    public async Task<CustomerResponse> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = await customerRepository.GetByIdAsync(request.Id);

        customer.AvailableBalance = request.AvailableAmount;

        await customerRepository.Update(customer);

        await unitOfWork.SaveChangesAsync();

        return customer.Adapt<CustomerResponse>();
    }
}
