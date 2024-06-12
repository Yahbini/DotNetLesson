using Lesson1.Helper;
using Lesson1.Models;
using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson1.Controllers;
[Route("account")]
public class AccountController : Controller
{
    private AccountService accountService;
    private CertService certService;
    private LanguageService languageService;
    private RoleService roleService;
    private IWebHostEnvironment webHostEnvironment;

    public AccountController(AccountService _accountService, CertService _certService, LanguageService _languageService, RoleService _roleService, IWebHostEnvironment _webHostEnvironment)
    {
        certService = _certService;
        accountService = _accountService;
        languageService = _languageService;
        roleService = _roleService;
        webHostEnvironment = _webHostEnvironment;
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
    //[Route("~/")]
    public IActionResult Register()
    {
        var account = new Account()
        {
            Id = 123,
            Username = "acc1",
            Description = "abc",
            Details = "<b><i><u>Hello word!!!</u></i></b>",
            Dob = DateTime.Now,
            Gender = "male",
            CertId = 2,
            Status = true,
            RoleId = 3,
            Email = "abc@gmail.com",
            Address = new Address
            {
                Street = "st1",
                Ward = "w1"
            }
        };
        ViewBag.certs = certService.findAll();
        ViewBag.languages = languageService.findAll();
        ViewBag.roles = roleService.findAll();
        return View("Register", account);
    }

    [HttpPost]
    [Route("register")]

    public IActionResult Register(Account account, List<int> languages, IFormFile file)
    {
        account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
        account.LanguagesIds = languages;
        Debug.WriteLine("Account Info");
        Debug.WriteLine("id: " + account.Id);
        Debug.WriteLine("username: " + account.Username);
        Debug.WriteLine("password: " + account.Password);
        Debug.WriteLine("fullname: " + account.Fullname);
        Debug.WriteLine("description: " + account.Description);
        Debug.WriteLine("details: " + account.Details);
        Debug.WriteLine("dob: " + account.Dob.ToString("dd/MM/yyyy"));
        Debug.WriteLine("gender: " + account.Gender);
        Debug.WriteLine("cert: " + account.CertId);
        Debug.WriteLine("status: " + account.Status);
        if (account.LanguagesIds != null && account.LanguagesIds.Count > 0)
        {
            Debug.WriteLine("Languages Ids: " + account.LanguagesIds.Count);
            foreach (int languageId in account.LanguagesIds)
            {
                Debug.WriteLine(languageId);
            }
        }
        Debug.WriteLine("roleId: " + account.RoleId);
        Debug.WriteLine("Email : " + account.Email);
        Debug.WriteLine("Street : " + account.Address.Street);
        Debug.WriteLine("Ward : " + account.Address.Ward);
        if (file != null && file.Length > 0)
        {
            var fileName = FileHelper.generateFileName(file.FileName);
            var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            account.Photo = fileName;
        }

        return RedirectToAction("register");
    }
}
