using Application.Abstractions;
using Application.Customer.Contracts;

namespace Application.Customer.Commands.Create;

public sealed record CreateCustomerCommand(string Name) : ICommand<CustomerResponse>;
