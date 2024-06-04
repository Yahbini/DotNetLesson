namespace Lesson1.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> courses { get; set; }
}
