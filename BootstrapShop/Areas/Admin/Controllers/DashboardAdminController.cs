using Microsoft.AspNetCore.Mvc;

namespace BootstrapShop.Areas.Admin.Controllers;

[Area("admin")]
[Route("admin/dashboard")]
public class DashboardAdminController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
