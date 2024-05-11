namespace Domain.Entities
{
    public sealed class Order
    {
        public Guid OrderId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public Guid CustomerId { get; set; }
    }
}
