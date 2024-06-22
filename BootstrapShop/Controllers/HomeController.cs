using Microsoft.AspNetCore.Mvc;

namespace BootstrapShop.Controllers;
[Route("homepage")]
public class HomeController : Controller
{
    [Route("~/")]
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
