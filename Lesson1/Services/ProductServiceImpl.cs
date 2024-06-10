using Lesson1.Models;
using System.Globalization;

namespace Lesson1.Services;

public class ProductServiceImpl : ProductService
{
    private List<Product> products;

    public ProductServiceImpl()
    {
        products = new List<Product>
        {
            new Product
        {
            Id = 1,
            Name = "laptop",
            Photo = "phoebe2.jpg",
            Creation = DateTime.Now,
            Price = 4.6,
            Quantity = 2
        },
            new Product
            {
                Id = 2,
                Name = "mobile",
                Photo = "phoebe1.png",
                Creation = DateTime.ParseExact("20/10/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Price = 2.3,
                Quantity = 2
            },
            new Product
            {
                Id = 3,
                Name = "keyboard",
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

    public List<Product> findByKeyWord(string keyWord)
    {
        return products.Where(p => p.Name.Contains(keyWord)).ToList();
    }

    public Product findId(int id)
    {
        return products.SingleOrDefault(p => p.Id == id);
    }

    public List<Product> searchByDate(DateTime from, DateTime to)
    {
        return products.Where(p => p.Creation >= from && p.Creation <= to).ToList();
    }

    public List<Product> searchByPrice(double min, double max)
    {
        return products.Where(p => p.Price >= min && p.Price <= max).ToList();
    }
}
