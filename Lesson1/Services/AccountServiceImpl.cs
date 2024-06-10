using Lesson1.Models;

namespace Lesson1.Services;

public class AccountServiceImpl : AccountService
{
    private List<Account> accounts;

    public AccountServiceImpl()
    {
        accounts = new List<Account>()
        {
            new Account
            {
                Id = 1,
                Username = "Anh",
                Password = "$2b$10$kwNjGjd5Ys2fsp4cKfb6UO3N7uIS/Tm5gGa5salU3Ebj4k4CMXWYu", // 123
                Fullname = "Phuong Anh"
            },
            new Account
            {
                Id = 2,
                Username = "Phoebe",
                Password = "$2b$10$fi4lUGv21Q3mabE9cIwOgOAS0QYeMX0kn2X/yOUFNY81jNvdusBT2", // 456
                Fullname = "Phuong Anh"
            },
            new Account
            {
                Id = 3,
                Username = "Ryan",
                Password = "$2b$10$UXwguP.y8PS8ELGgXu33U.09eq6VfF6KVF4.F4ir00kpYm/Lfs4Lu", // 789
                Fullname = "Ryan Yah"
            },
        };

    }

    public bool Login(string username, string password)
    {
        var account = accounts.SingleOrDefault(acc => acc.Username == username);
        if (account != null)
        {
            return BCrypt.Net.BCrypt.Verify(password, account.Password);
        }
        return false;
    }
}
