using Lesson1.Models;

namespace Lesson1.Services;

public interface ProductService
{
    public List<Product> findAll();
    public Product findId(int id);
}
