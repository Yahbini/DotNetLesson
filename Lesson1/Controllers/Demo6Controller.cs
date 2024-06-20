using Lesson1.Models;
using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Lesson1.Controllers;
[Route("demo6")]
public class Demo6Controller : Controller
{
    private ProductService productService;

    public Demo6Controller(ProductService _productService)
    {
        productService = _productService;
    }

    [Route("")]
    [Route("index")]
    //[Route("~/")]
    public IActionResult Index()
    {
        HttpContext.Session.SetInt32("id", 123);
        HttpContext.Session.SetString("username", "Anh");
        string s = JsonConvert.SerializeObject(productService.findId(1));
        string s2 = JsonConvert.SerializeObject(productService.findAll());
        Debug.WriteLine(s);
        Debug.WriteLine(s2);
        HttpContext.Session.SetString("product: ", s);
        HttpContext.Session.SetString("products: ", s2);
        HttpContext.Session.Remove("id");

        return RedirectToAction("index2");
    }

    [Route("index2")]
    public IActionResult Index2()
    {
        if (HttpContext.Session.GetInt32("id") != null)
        {
            int id = HttpContext.Session.GetInt32("id").Value;
            Debug.WriteLine(id);
        }
        else
        {
            Debug.WriteLine("Session not found");

        }
        if (HttpContext.Session.GetString("product") != null)
        {
            string s = HttpContext.Session.GetString("product");
            Product product = JsonConvert.DeserializeObject<Product>(s);
            Debug.WriteLine("Product Info");
            Debug.WriteLine("id: " + product.Id);
            Debug.WriteLine("name: " + product.Name);
            Debug.WriteLine("price: " + product.Price);
        }
        else
        {
            Debug.WriteLine("Session not found");

        }
        if (HttpContext.Session.GetString("products") != null)
        {
            string s = HttpContext.Session.GetString("products");
            var products = JsonConvert.DeserializeObject<List<Product>>(s);

            Debug.WriteLine("id: " + products.Count);
            foreach (var product in products)
            {
                Debug.WriteLine("id: " + product.Id);
                Debug.WriteLine("name: " + product.Name);
                Debug.WriteLine("price: " + product.Price);
            }
        }
        else
        {
            Debug.WriteLine("Session not found");

        }
        return View();
    }
}
