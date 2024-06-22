using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
[Route("homepage")]
public class HomeController : Controller
{
    [Route("")]
    [Route("index")]
    [Route("~/")]
    public IActionResult Index()
    {
        return View();
    }
}
