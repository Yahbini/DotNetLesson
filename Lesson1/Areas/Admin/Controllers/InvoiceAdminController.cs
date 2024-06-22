using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Areas.Admin.Controllers;

[Area("admin")]
[Route("admin/invoices")]
public class InvoiceAdminController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();

    }

}
