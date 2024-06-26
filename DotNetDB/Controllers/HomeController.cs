using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetDB.Controllers;
[Route("home")]
public class HomeController : Controller
{
    private IConfiguration configuration;

    public HomeController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    [Route("")]
    [Route("index")]
    [Route("~/")]
    public IActionResult Index()
    {
        string config2 = configuration["Config2:Config2_1"].ToString();
        Debug.WriteLine("Config2: Config2_1" + config1);
        return View();
    }
}
