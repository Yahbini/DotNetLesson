using Lesson1.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace Lesson1.Controllers;
[Route("demo5")]
public class Demo5Controller : Controller
{
    private IWebHostEnvironment webHostEnvironment;
    public Demo5Controller(IWebHostEnvironment _webHostEnvironment)
    {
        webHostEnvironment = _webHostEnvironment;
    }

    [Route("")]
    [Route("index")]
    //[Route("~/")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("index2")]
    //[Route("~/")]
    public IActionResult Index2()
    {
        Debug.WriteLine(Guid.NewGuid().ToString());
        return View("Index2");
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


    [HttpPost]
    [Route("update1")]
    public IActionResult update1(List<string> emails)
    {
        Debug.WriteLine("emails: " + emails.Count);
        foreach (string email in emails)
        {
            Debug.WriteLine(email);
        }

        return RedirectToAction("index");
    }

    [HttpPost]
    [Route("update2")]
    public IActionResult update2(List<int> quantities)
    {
        Debug.WriteLine("quantities: " + quantities.Count);
        foreach (var quantity in quantities)
        {
            Debug.WriteLine(quantity);
        }

        return RedirectToAction("index");
    }

    [HttpPost]
    [Route("upload")]
    public IActionResult upload(IFormFile file)
    {
        Debug.WriteLine("File info");
        Debug.WriteLine("File name: " + file.FileName);
        Debug.WriteLine("File size(byte): " + file.Length);
        Debug.WriteLine("File type: " + file.ContentType);

        // Upload file
        var fileName = FileHelper.generateFileName(file.FileName);
        var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName);

        using (var fileStream = new FileStream(path, FileMode.Create))
        {
            file.CopyTo(fileStream);
        }

        return RedirectToAction("index2");
    }

    [HttpPost]
    [Route("uploads")]
    public IActionResult uploads(List<IFormFile> files)
    {
        Debug.WriteLine("files: " + files.Count);
        foreach (var file in files)
        {
            Debug.WriteLine("File info");
            Debug.WriteLine("File name: " + file.FileName);
            Debug.WriteLine("File size(byte): " + file.Length);
            Debug.WriteLine("File type: " + file.ContentType);
            Debug.WriteLine("--------------------");
            var fileName = FileHelper.generateFileName(file.FileName);
            var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
        }
        return RedirectToAction("index2");
    }
}
