using Lesson1.Models;

namespace Lesson1.Services;

public class RoleServiceImpl : RoleService
{
    private List<Role> roles;

    public RoleServiceImpl()
    {
        roles = new List<Role>()
        {
            new Role() {
                Id = 1,
                Name = "Admin"
            },
            new Role() {
                Id = 2,
                Name = "User"
            },
            new Role() {
                Id = 3,
                Name = "Manager"
            }
        };


    }

    public List<Role> findAll()
    {
        return roles;
    }

}
