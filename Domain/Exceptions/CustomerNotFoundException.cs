namespace Domain.Exceptions;

public sealed class CustomerNotFoundException(Guid customerId) 
    : Exception($"Customer {customerId} Not Found ")
{
}
