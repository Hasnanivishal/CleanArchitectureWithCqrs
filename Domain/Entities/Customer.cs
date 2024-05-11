namespace Domain.Entities;

public sealed class Customer(Guid customerId, string name, double AvailableBalance = 100)
{
    public Guid CustomerId { get; private set; } = customerId;

    public string Name { get; private set; } = name;

    public double AvailableBalance { get; set; } = AvailableBalance;
}
