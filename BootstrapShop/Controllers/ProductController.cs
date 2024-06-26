using Microsoft.AspNetCore.Mvc;

namespace BootstrapShop.Controllers;
[Route("products")]
public class ProductController : Controller
{
    [Route("category")]
    public IActionResult Category()
    {
        return View("Category");
    }

    [Route("details")]
    public IActionResult Details()
    {
        return View("ProductDetail");
    }

}
