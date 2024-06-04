using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
[Route("/students")]
public class StudentController : Controller
{

    [Route("")]
    [Route("index")]
    [Route("~/")]
    public IActionResult Index()
    {
        var students = new StudentModel();
        ViewBag.students = students.findAll();
        return View();
    }
}
