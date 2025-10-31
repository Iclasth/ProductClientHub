namespace ProductClientHub.API.Entities
{
    public class Products
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public Guid ClientId { get; set; }
    }
}
