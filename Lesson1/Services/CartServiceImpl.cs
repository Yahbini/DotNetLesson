using Lesson1.Models;

namespace Lesson1.Services;

public class CartServiceImpl : CartService
{


    public int Exists(int id, List<Item> cart)
    {
        for (int i = 0; i < cart.Count; i++)
        {
            if (cart[i].Product.Id == id)
            {
                return i;
            }

        }
        return -1;
    }

    public double Total(List<Item> cart)
    {
        return cart.Sum(i => i.Product.Price * i.Product.Quantity);
    }
}
