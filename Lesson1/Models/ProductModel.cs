using System.Globalization;

namespace Lesson1.Models;

public class ProductModel
{
    private List<Product> products;

    public ProductModel()
    {
        products = new List<Product>
        {
            new Product
        {
            Id = 1,
            Name = "Name 1",
            Photo = "phoebe2.jpg",
            Creation = DateTime.Now,
            Price = 4.6,
            Quantity = 2
        },
            new Product
            {
                Id = 2,
                Name = "Name 2",
                Photo = "phoebe1.png",
                Creation = DateTime.ParseExact("20/10/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Price = 2.3,
                Quantity = 2
            },
            new Product
            {
                Id = 3,
                Name = "Name 3",
                Photo = "phoebe.png",
                Creation = DateTime.ParseExact("20/11/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Price = 2.9,
                Quantity = 3
            },
        };
    }

    public List<Product> findAll()
    {

        return products;
    }

    public Product find(int id)
    {
        return products.SingleOrDefault(p => p.Id == id);
    }
}
