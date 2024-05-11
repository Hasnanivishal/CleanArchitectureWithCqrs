using Application.Abstractions;
using Application.Customer.Contracts;
using Domain.Repositories;
using Mapster;

namespace Application.Customer.Commands.Create
{
    internal sealed class CreateCustomerCommandHandler(ICustomerRepository customerRepository,
        IUnitOfWork unitOfWork) :
        ICommandHandler<CreateCustomerCommand, CustomerResponse>
    {
        private readonly ICustomerRepository customerRepository = customerRepository;
        private readonly IUnitOfWork unitOfWork = unitOfWork;

        public async Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = await customerRepository.Insert(new Domain.Entities.Customer(Guid.NewGuid(), request.Name));

            await unitOfWork.SaveChangesAsync();

            return response.Adapt<CustomerResponse>();
        }
    }
}
