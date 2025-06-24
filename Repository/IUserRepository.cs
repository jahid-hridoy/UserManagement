using UserManagement.Models;
namespace UserManagement.Repository;

public interface IUserRepository
{
    IEnumerable<User> GetAll();
    IEnumerable<User> GetByRole(string role);
}