using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;

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
    [Route("homepage")]
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

    [Route("details/{id}")]
    public IActionResult Details(int id)
    {
        ViewBag.product = productService.findId(id);
        return View("Details");
    }

}
