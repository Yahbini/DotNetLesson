using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace Lesson1.Controllers;
[Route("demo5")]
public class Demo5Controller : Controller
{
    [Route("")]
    [Route("index")]
    //[Route("~/")]
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


    [HttpPost]
    [Route("login")]
    public IActionResult Login(string username, string password)
    {
        Debug.WriteLine("username: " + username);
        Debug.WriteLine("password: " + password);
        string hashPass = BCrypt.Net.BCrypt.HashPassword(password);
        Debug.WriteLine("hash: " + hashPass);
        return RedirectToAction("index");
    }

    [HttpPost]
    [Route("searchByDates")]
    public IActionResult SearchByDates(string from, string to)
    {
        Debug.WriteLine("from: " + from);
        Debug.WriteLine("to: " + to);
        DateTime startDate = DateTime.ParseExact(from, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(to, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Debug.WriteLine("startDate: " + startDate);
        Debug.WriteLine("endDate: " + endDate);
        return RedirectToAction("index");
    }
}
