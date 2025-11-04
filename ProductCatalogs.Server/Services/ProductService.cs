using ProductCatalogs.Server.Models;

namespace ProductCatalogs.Server.Services
{
    public class ProductService
    {
        private static List<Product> products = new()
        {
            new Product { ProductId = 1, ProductName = "Laptop", PricePerItem = 1200, AverageCustomerRating = 4.8 },
            new Product { ProductId = 2, ProductName = "Smartphone", PricePerItem = 800, AverageCustomerRating = 4.5 },
        };

        private static List<ProductAttribute> attributes = new()
        {
            new ProductAttribute { Id = 1, ProductId = 1, AttributeName = "Color", AttributeValue = "Silver" },
            new ProductAttribute { Id = 2, ProductId = 1, AttributeName = "RAM", AttributeValue = "16 GB" },
            new ProductAttribute { Id = 3, ProductId = 1, AttributeName = "Storage", AttributeValue = "512 GB SSD" },

            new ProductAttribute { Id = 4, ProductId = 2, AttributeName = "Color", AttributeValue = "Black" },
            new ProductAttribute { Id = 5, ProductId = 2, AttributeName = "Screen Size", AttributeValue = "6.5 inch" },
            new ProductAttribute { Id = 6, ProductId = 2, AttributeName = "Battery", AttributeValue = "4500 mAh" },
            new ProductAttribute { Id = 7, ProductId = 2, AttributeName = "Camera", AttributeValue = "108 MP" },
        };

        public IEnumerable<Product> GetProducts() =>
            products.OrderByDescending(p => p.AverageCustomerRating);

        public Product? GetProduct(int id) =>
            products.FirstOrDefault(p => p.ProductId == id);

        public IEnumerable<ProductAttribute> GetProductAttributes(int productId) =>
            attributes.Where(a => a.ProductId == productId);
    }
}
