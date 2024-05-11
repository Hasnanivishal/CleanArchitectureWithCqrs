namespace Application.Order.Contracts;

public class OrderResponse
{
    public Guid OrderId { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public double Price { get; set; }

    public Guid CustomerId { get; set; }
}
