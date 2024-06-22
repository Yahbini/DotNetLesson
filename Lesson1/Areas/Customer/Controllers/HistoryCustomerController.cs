using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Areas.Customer.Controllers;

[Area("customer")]
[Route("customer/history")]
public class HistoryCustomerController : Controller
{

    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
