using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;

[Route("employee")]
public class EmployeeController : Controller
{
    [Route("")]
    [Route("index")]
    [Route("~/")]
    public IActionResult Index()
    {
        var employee = new Employee();
        return View("Index", employee);
    }
}
