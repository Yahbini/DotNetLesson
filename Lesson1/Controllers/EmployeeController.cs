using Lesson1.Models;
using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson1.Controllers;

[Route("employee")]
public class EmployeeController : Controller
{

    private AccountService accountService;

    public EmployeeController(AccountService _accountService)
    {
        accountService = _accountService;
    }

    [Route("")]
    [Route("index")]
    //[Route("~/")]
    public IActionResult Index()
    {
        var employee = new Employee();
        return View("Index", employee);
    }

    [Route("save")]
    [HttpPost]
    public IActionResult Save(Employee emp)
    {
        if (emp.Username != null && accountService.Exists(emp.Username))
        {
            ModelState.AddModelError("Username", "Username exsited");
        }
        if (ModelState.IsValid)
        {
            Debug.WriteLine("username", emp.Username);
            return View("Success");
        }
        else
        {
            return View("Index");
        }
    }
}
