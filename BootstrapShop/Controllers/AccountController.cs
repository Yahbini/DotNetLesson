using Microsoft.AspNetCore.Mvc;

namespace BootstrapShop.Controllers;
[Route("account")]
public class AccountController : Controller
{
    [Route("login")]
    public IActionResult Login()
    {
        return View("Login");
    }

    [Route("register")]
    public IActionResult Register()
    {
        return View("Register");
    }

}
