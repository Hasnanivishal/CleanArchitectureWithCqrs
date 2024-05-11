namespace Domain.Entities
{
    public sealed class Order
    {
        public int OrderId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid CustomerId { get; set; }
    }
}
