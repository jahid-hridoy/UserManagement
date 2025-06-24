using UserManagement.Models;

namespace UserManagement.Services;

public interface IUserService
{
    IEnumerable<UserViewModel> GetUsers(string role);
}