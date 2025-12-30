using dotnetapp.Models;

namespace ProductData.Data
{
    /*
     * Static Product Data Store
     * 
     * Demonstrates: In-memory data storage using static class
     * - Persists data across page navigations
     * - Provides centralized access to product list
     */
    public static class ProductData
    {
        public static List<Product> ProductsList { get; set; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Samsung Galaxy S23",
                Description = "Flagship Android smartphone",
                Price = 125000,
                Quantity = 10,
                Category = "Electronics",
                ImageUrl = "https://via.placeholder.com/150",
                CreatedDate = DateTime.Now.AddDays(-20)
            },
            new Product
            {
                Id = 2,
                Name = "Dell Inspiron 15",
                Description = "15-inch laptop for everyday use",
                Price = 98000,
                Quantity = 6,
                Category = "Computers",
                ImageUrl = "https://via.placeholder.com/150",
                CreatedDate = DateTime.Now.AddDays(-15)
            },
            new Product
            {
                Id = 3,
                Name = "Apple AirPods Pro",
                Description = "Wireless noise-cancelling earbuds",
                Price = 42000,
                Quantity = 15,
                Category = "Accessories",
                ImageUrl = "https://via.placeholder.com/150",
                CreatedDate = DateTime.Now.AddDays(-10)
            },
            new Product
            {
                Id = 4,
                Name = "Sony WH-1000XM5",
                Description = "Noise cancelling headphones",
                Price = 55000,
                Quantity = 8,
                Category = "Audio",
                ImageUrl = "https://via.placeholder.com/150",
                CreatedDate = DateTime.Now.AddDays(-6)
            },
            new Product
            {
                Id = 5,
                Name = "Logitech MX Master 3S",
                Description = "Wireless productivity mouse",
                Price = 18000,
                Quantity = 20,
                Category = "Peripherals",
                ImageUrl = "https://via.placeholder.com/150",
                CreatedDate = DateTime.Now.AddDays(-3)
            }
        };

        public static int NextProductId { get; set; } = 6;
    }
}