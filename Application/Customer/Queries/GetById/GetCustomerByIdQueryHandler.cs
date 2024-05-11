using Application.Abstractions;
using Application.Customer.Contracts;
using Domain.Repositories;
using Mapster;

namespace Application.Customer.Queries.GetById;

internal class GetCustomerByIdQueryHandler(ICustomerRepository customerRepository)
    : IQueryHandler<GetCustomerByIdQuery, CustomerResponse>
{
    public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        var customer = await customerRepository.GetByIdAsync(request.Id);

        return customer.Adapt<CustomerResponse>();
    }
}
