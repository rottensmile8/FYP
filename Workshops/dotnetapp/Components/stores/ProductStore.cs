using dotnetapp.Models;

namespace dotnetapp.Stores;

public static class ProductStore
{
    public static List<Product> Products { get; } = new();

    private static int _nextId = 1;

    public static Product Add(Product product)
    {
        product.Id = _nextId++;
        Products.Add(product);
        return product;
    }
}
