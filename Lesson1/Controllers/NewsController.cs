using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
[Route("news")]
public class NewsController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
