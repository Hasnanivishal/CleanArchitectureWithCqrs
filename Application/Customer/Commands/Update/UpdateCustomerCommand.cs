using Application.Abstractions;
using Application.Customer.Contracts;

namespace Application.Customer.Commands.Update;

public sealed record UpdateCustomerCommand(Guid Id,
    double AvailableAmount)
    : ICommand<CustomerResponse>;
