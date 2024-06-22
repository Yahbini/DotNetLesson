using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Areas.Customer.Controllers;

[Area("customer")]
[Route("customer/profile")]
public class ProfileCustomerController : Controller
{
    [Route("index")]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}
