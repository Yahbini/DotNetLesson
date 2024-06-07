using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
[Route("/students")]
public class StudentController : Controller
{

    [Route("")]
    [Route("index")]

    public IActionResult Index()
    {
        var students = new StudentModel();
        ViewBag.students = students.findAll();
        return View();
    }

    [Route("details/{id}")]
    public IActionResult Details(int id)
    {
        var students = new StudentModel();
        var student = students.find(id);

        var m = student.courses.FirstOrDefault(c => c.Name == "Math")?.Score ?? null;
        var g = student.courses.FirstOrDefault(c => c.Name == "Geography")?.Score ?? null;
        var b = student.courses.FirstOrDefault(c => c.Name == "Biography")?.Score ?? null;

        double avarage = 0;
        if (m != null && g != null && b != null)
        {
            avarage = Math.Round(((double)(m + g + b) / 3), 2);
        }
        else
        {
            avarage = ((m ?? 0) + (g ?? 0) + (b ?? 0)) / (3 - ((m == null ? 1 : 0) + (g == null ? 1 : 0) + (b == null ? 1 : 0)));
        }

        ViewBag.Student = student;
        ViewBag.MathScore = m;
        ViewBag.GeoScore = g;
        ViewBag.BiogScore = b;
        ViewBag.Average = avarage;
        return View("Details");
    }
}
