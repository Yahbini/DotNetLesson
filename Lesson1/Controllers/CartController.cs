using Lesson1.Models;
using Lesson1.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lesson1.Controllers;
[Route("cart")]
public class CartController : Controller
{
    private ProductService productService;
    private CartService cartService;
    public CartController(ProductService _productService, CartService _cartService)
    {
        productService = _productService;
        cartService = _cartService;
    }

    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("cart") != null)
        {
            var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
            ViewBag.cart = cart;
            ViewBag.total = cartService.Total(cart);
        }
        return View();
    }

    [Route("buy/{id}")]
    public IActionResult Buy(int id)
    {
        var product = productService.findId(id);
        if (HttpContext.Session.GetString("cart") == null)
        {
            var cart = new List<Item>();
            cart.Add(new Item
            {
                Product = product,
                Quantity = 1,
            });
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        }
        else
        {
            var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
            int index = cartService.Exists(id, cart);

            if (index == -1)
            {
                cart.Add(new Item
                {
                    Product = product,
                    Quantity = 1,
                });
            }
            else
            {
                cart[index].Quantity++;
            }
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        }

        return RedirectToAction("index");
    }

    [HttpPost]
    [Route("update")]
    public IActionResult Update(List<int> quantities)
    {
        var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
        for (int i = 0; i < cart.Count; i++)
        {
            cart[i].Quantity = quantities[i];
        }
        HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        return RedirectToAction("index");
    }


    [Route("remove/{id}")]
    public IActionResult Remove(int id)
    {
        var cart = JsonConvert.DeserializeObject<List<Item>>(HttpContext.Session.GetString("cart"));
        var index = cartService.Exists(id, cart);
        cart.RemoveAt(index);
        HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
        return RedirectToAction("index");
    }

    [Route("checkout")]
    public IActionResult Checkout(int id)
    {
        if (HttpContext.Session.GetString("username") == null)
        {
            return RedirectToAction("login", "account");
        }
        else
        {
            HttpContext.Session.Remove("cart");
            return View("Success");
        }
    }

}
