using Lesson1.Models;

namespace Lesson1.Services;

public interface ProductService
{
    public List<Product> findAll();
    public Product findId(int id);
    public List<Product> findByKeyWord(string keyWord);
    public List<Product> searchByPrice(double min, double max);
    public List<Product> searchByDate(DateTime from, DateTime to);
}
