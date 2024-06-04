using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson1.Controllers;

[Route("d3")]
public class Demo3Controller : Controller

{
    [Route("homepage")]
    [Route("index")]
    [Route("")]

    public IActionResult Index()
    {
        return View("Index");
    }

    [Route("index2")]
    public IActionResult Index2()
    {
        return View("Index2");
    }

    [Route("index3/{id}")]
    public IActionResult Index3(int id)
    {
        Debug.WriteLine("id: ", id);
        return View("Index3");
    }

    [Route("index4/{id}/{username}")]
    public IActionResult Index4(String id, String username)
    {
        Debug.WriteLine("id:", id);
        Debug.WriteLine("username:", username);
        return View("Index4");
    }

    // query string: http://localhost:5041/d3/index5?id=123&username=phoebe
    // thêm dấu ? phía sau
    [Route("index5")]
    public IActionResult Index5(int id, String username)
    {
        Debug.WriteLine("id: " + id);
        Debug.WriteLine("username: " + username);
        return View("Index5");
    }

    [Route("index6")]
    public IActionResult Index6(int id, String username)
    {
        return RedirectToAction("index2", "d3"); //redirect về index 2
    }

    [Route("index7")]
    public IActionResult Index7(int id, String username)
    {
        return RedirectToAction("index4", "d3", new { id = 123, username = "phoebe" });
    }
}
