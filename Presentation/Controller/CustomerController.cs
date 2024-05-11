using Application.Customer.Commands.Create;
using Application.Customer.Contracts;
using Application.Customer.Queries.GetAll;
using Application.Customer.Queries.GetById;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller;

[ApiController]
[Route("api/[controller]")]
public sealed class CustomerController(ISender sender) : ControllerBase
{
    private readonly ISender sender = sender;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var customers = await sender.Send(new GetCustomersQuery());

        return Ok(customers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var customer = await sender.Send(new GetCustomerByIdQuery(id));

        return Ok(customer);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CustomerRequest request)
    {
        var command = request.Adapt<CreateCustomerCommand>();

        var result = await sender.Send(command);

        return CreatedAtAction(nameof(GetById), new { id = result.CustomerId }, result);
    }
}
