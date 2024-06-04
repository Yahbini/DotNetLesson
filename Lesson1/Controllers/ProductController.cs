using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
[Route("product")]
public class ProductController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        var productModel = new ProductModel();
        ViewBag.products = productModel.findAll();
        return View();
    }

    [Route("details/{id}")]
    public IActionResult Details(int id)
    {
        var productModel = new ProductModel();
        ViewBag.product = productModel.find(id);
        return View("Details");
    }
}
