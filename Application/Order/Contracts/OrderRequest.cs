namespace Application.Order.Contracts;

public class OrderRequest
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public double Price { get; set; }

    public Guid CustomerId { get; set; }
}
