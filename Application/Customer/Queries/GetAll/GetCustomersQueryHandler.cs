using Application.Abstractions;
using Application.Customer.Contracts;
using Domain.Repositories;
using Mapster;

namespace Application.Customer.Queries.GetAll;

internal class GetCustomersQueryHandler(ICustomerRepository customerRepository) : IQueryHandler<GetCustomersQuery,
    List<CustomerResponse>>
{
    private readonly ICustomerRepository customerRepository = customerRepository;

    public async Task<List<CustomerResponse>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
    {
        var customers = await customerRepository.GetAsync();

        return customers.ToList().Adapt<List<CustomerResponse>>();
    }
}
