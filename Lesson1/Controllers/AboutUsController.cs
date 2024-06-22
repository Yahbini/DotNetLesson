using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;

[Route("acboutus")]
public class AboutUsController : Controller
{
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}
