using Lesson1.Models;
using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

    [Route("register")]
    [Route("~/")]
    public IActionResult Register()
    {
        var account = new Account()
        {
            Id = 123,
            Username = "acc1",
            Description = "abc",
            Details = "<b><i><u>Hello word!!!</u></i></b>"
        };
        return View("Register", account);
    }

    [HttpPost]
    [Route("register")]
    [Route("~/")]
    public IActionResult Register(Account account)
    {
        account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
        Debug.WriteLine("Account Info");
        Debug.WriteLine("id: " + account.Id);
        Debug.WriteLine("username: " + account.Username);
        Debug.WriteLine("password: " + account.Password);
        Debug.WriteLine("fullname: " + account.Fullname);
        Debug.WriteLine("description: " + account.Description);
        Debug.WriteLine("details: " + account.Details)
        return RedirectToAction("register");
    }
}
