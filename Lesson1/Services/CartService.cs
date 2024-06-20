using Lesson1.Models;

namespace Lesson1.Services;

public interface CartService
{
    public int Exists(int id, List<Item> cart);
    public double Total(List<Item> cart);
}
