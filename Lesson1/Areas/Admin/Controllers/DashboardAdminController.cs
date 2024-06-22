using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson1.Areas.Admin.Controllers;

[Area("admin")]
[Route("admin/dashboard")]
public class DashboardAdminController : Controller
{
    [Route("index")]
    [Route("")]
    // http://localhost:5041/admin/dashboard/index
    public IActionResult Index()
    {
        return View();

    }

    [Route("index2/{id}")]
    public IActionResult Index2(int id)
    {
        Debug.WriteLine("id: " + id);
        return View();
    }
}
