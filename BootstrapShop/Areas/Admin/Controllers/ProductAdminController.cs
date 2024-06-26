using Microsoft.AspNetCore.Mvc;

namespace BootstrapShop.Areas.Admin.Controllers;

[Area("admin")]
[Route("admin/product")]
public class ProductAdminController : Controller
{
    [Route("admin/product/add")]
    public IActionResult Add()
    {
        return View();
    }

    [Route("admin/product/list")]
    public IActionResult List()
    {
        return View();
    }
}
