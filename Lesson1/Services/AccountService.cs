namespace Lesson1.Services;

public interface AccountService
{
    public bool Login(string username, string password);
    public bool Exists(string username);
}
