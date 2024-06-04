using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
//locahost:/demo/index => hiện hello
// Vì controller tên Demo thì tương đương View demo 
public class DemoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Index2()
    {
        return View("Index2"); // tương dương index2.cshtml
                               // locahost:/demo/index2 => hiện hello
    }
}
