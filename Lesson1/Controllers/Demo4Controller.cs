using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Lesson1.Controllers;
[Route("demo4")]
public class Demo4Controller : Controller
{
    private DemoService demoService;
    private CalculateService calcService;
    private RectangleService rectangleService;
    private ProductService productService;

    public Demo4Controller(DemoService _demoService, CalculateService _calcService, RectangleService _rectangleService, ProductService _productService)
    {
        demoService = _demoService;
        calcService = _calcService;
        rectangleService = _rectangleService;
        productService = _productService;
    }



    [Route("")]
    [Route("index")]
    //[Route("~/")]
    public IActionResult Index()
    {

        ViewBag.Result1 = demoService.Hello();
        ViewBag.Result2 = demoService.Hi("Phuong Anh");
        ViewBag.Add = calcService.Add(4, 6);
        ViewBag.Mul = calcService.Mul(12, 6);
        ViewBag.Area = rectangleService.Area(3, 6);
        ViewBag.Perimter = rectangleService.Perimter(3, 9);
        ViewBag.products = productService.findAll();
        return View();
    }


    [Route("index2")]
    public IActionResult Index2()
    {

        ViewBag.Result1 = demoService.Hello();
        ViewBag.Result2 = demoService.Hi("Phuong Anh");
        ViewBag.Add = calcService.Add(4, 6);
        ViewBag.Mul = calcService.Mul(12, 6);
        ViewBag.Area = rectangleService.Area(3, 6);
        ViewBag.Perimter = rectangleService.Perimter(3, 9);
        ViewBag.products = productService.findAll();
        return View("Index2");
    }

    [Route("details/{id}")]
    public IActionResult Details(int id)
    {
        ViewBag.product = productService.findId(id);
        return View("Details");
    }

    [Route("searchByKeyWord")]
    public IActionResult findByKeyWord(string keyword)
    {
        ViewBag.products = productService.findByKeyWord(keyword);
        ViewBag.keywords = keyword;
        return View("Index2");
    }

    [Route("searchByPrices")]
    public IActionResult searchByPrices(double min, double max)
    {
        ViewBag.products = productService.searchByPrice(min, max);
        //ViewBag.keywords = keyword;
        return View("Index2");
    }

    [HttpPost]
    [Route("searchByDate")]
    public IActionResult searchByDate(string from, string to)
    {
        DateTime startDate = DateTime.ParseExact(from, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(to, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        ViewBag.products = productService.searchByDate(startDate, endDate);
        //ViewBag.keywords = keyword;
        return View("Index2");
    }
}
