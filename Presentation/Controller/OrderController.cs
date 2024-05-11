using Application.Order.Commands.Create;
using Application.Order.Contracts;
using Application.Order.Queries.GetByCustomerId;
using Application.Order.Queries.GetById;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller;

[ApiController]
[Route("api/[controller]")]
public class OrderController(ISender sender) : ControllerBase
{
    private readonly ISender sender = sender;

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var order = await sender.Send(new GetOrderByIdCommand(id));

        return Ok(order);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] OrderRequest request)
    {
        var command = request.Adapt<CreateOrderCommand>();

        var result = await sender.Send(command);

        return CreatedAtAction(nameof(Get), new { id = result.OrderId }, result);
    }

    [HttpGet("GetByCustomerId/{customerId}", Name = "GetByCustomerId")]
    public async Task<IActionResult> GetByCustomerId([FromRoute] Guid customerId)
    {
        var orders = await sender.Send(new GetByCustomerIdCommand(customerId));

        return Ok(orders);
    }
}
