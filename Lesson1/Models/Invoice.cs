namespace Lesson1.Models;

public class Invoice
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Creation { get; set; }
    public string Payment { get; set; }
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }
}
