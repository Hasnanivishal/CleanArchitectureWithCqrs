namespace Application.Customer.Contracts;

public class CustomerResponse
{
    public Guid CustomerId { get; set; }

    public required string Name { get; set; }

    public double AvailableBalance { get; set; }
}
