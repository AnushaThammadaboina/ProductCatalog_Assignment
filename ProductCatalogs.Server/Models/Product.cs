namespace ProductCatalogs.Server.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal PricePerItem { get; set; }
        public double AverageCustomerRating { get; set; }
    }
}
