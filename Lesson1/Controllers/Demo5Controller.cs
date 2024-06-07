using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson1.Controllers;
[Route("demo5")]
public class Demo5Controller : Controller
{
    [Route("")]
    [Route("index")]
    [Route("~/")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("searchByKeyWord")]
    public IActionResult SearchByKeyword(string keyword)
    {
        Debug.WriteLine("keyword: " + keyword);
        return RedirectToAction("index");
    }

    [HttpGet]
    [Route("searchByPrices")]
    public IActionResult SearchByPrices(double min, double max)
    {
        Debug.WriteLine("min: " + min);
        Debug.WriteLine("max: " + max);
        return RedirectToAction("index");
    }
}
