using Microsoft.AspNetCore.Mvc;

namespace BootstrapShop.Area.Admin.Controllers;

[Area("admin")]
[Route("admin")]
[Route("admin/login")]
public class LoginAdminController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
