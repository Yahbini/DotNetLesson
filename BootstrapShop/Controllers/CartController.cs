using Microsoft.AspNetCore.Mvc;

namespace BootstrapShop.Controllers;
[Route("cart")]
public class CartController : Controller
{
    //[Route("~/")]
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
