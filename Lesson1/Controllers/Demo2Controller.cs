using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Lesson1.Controllers;
public class Demo2Controller : Controller
{
    public IActionResult Index()
    {
        ViewBag.Id = 123;
        ViewBag.UserName = "abc";
        ViewBag.Status = true;
        ViewBag.Price = 4.5;
        ViewBag.Photo = "phoebe.png";
        ViewBag.Quantity = 3;
        ViewBag.Width = 100;
        ViewBag.Height = 100;
        ViewBag.Photos = new List<string>
        {
            "phoebe.png", "phoebe1.png", "phoebe2.jpg"
        };
        return View();
    }

    public IActionResult Index2()
    {
        ViewBag.product = new Product
        {
            Id = 1,
            Name = "Name 1",
            Photo = "phoebe2.jpg",
            Creation = DateTime.Now,
            Price = 4.6,
            Quantity = 2

        };
        return View("Index2");
    }

    public IActionResult Index3()
    {
        ViewBag.products = new List<Product>
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
        return View("Index3");
    }

    public IActionResult Index4()
    {
        var invoice = new Invoice
        {
            Id = 1,
            Name = "Invoice 1",
            Creation = DateTime.Now,
            Payment = "Cash",
            Customer = new Customer
            {
                Id = 1,
                FullName = "Cus 1",
                Phone = "09xxxxxx",
                Email = "abc@gmail.com"
            },
            Products = new List<Product>
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
            }
        };

        ViewBag.invoice = invoice;
        ViewBag.total = invoice.Products.Sum(p => p.Price * p.Quantity);
        return View("Index4");
    }
}
