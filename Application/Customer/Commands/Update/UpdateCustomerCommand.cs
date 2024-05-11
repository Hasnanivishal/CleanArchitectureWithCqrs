using Application.Abstractions;
using Application.Customer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customer.Commands.Update
{
    public sealed record UpdateCustomerCommand(
        Guid Id,
        double AvailableAmount)
        : ICommand<CustomerResponse>
    {
    }
}
