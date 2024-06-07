namespace Lesson1.Services;

public class DemoServiceImpl : DemoService
{
    public string Hello()
    {
        return "Hello Phoebe!!!";
    }

    public string Hi(string fullname)
    {
        return "Hi " + fullname;
    }
}
