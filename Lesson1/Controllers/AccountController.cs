using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
[Route("account")]
public class AccountController : Controller
{
    private AccountService accountService;
    public AccountController(AccountService _accountService)
    {
        accountService = _accountService;
    }

    [HttpGet]
    [Route("")]
    [Route("login")]
    //[Route("~/")]
    public IActionResult Login()
    {
        return View("Login");
    }

    [HttpPost]
    [Route("login")]
    public IActionResult Login(string username, string password)
    {
        if (accountService.Login(username, password))
        {
            return View("Welcome");
        }
        else
        {
            ViewBag.message = "Invalid";
            return View("Login");
        }
    }

    [HttpPost]
    [Route("welcome")]
    public IActionResult Welcome(string username, string password)
    {

        return View("Welcome");
    }

    [HttpPost]
    [Route("logout")]
    public IActionResult Logout()
    {

        return RedirectToAction("login");
    }
}
