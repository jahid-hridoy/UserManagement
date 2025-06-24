using UserManagement.Models;
using UserManagement.UnitOfWork;

namespace UserManagement.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    public UserService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

    public IEnumerable<UserViewModel> GetUsers(string role)
    {
        var users = string.IsNullOrEmpty(role)
            ? _unitOfWork.Users.GetAll()
            : _unitOfWork.Users.GetByRole(role);

        return users.Select(u => new UserViewModel
        {
            FullName = u.FirstName + " " + u.LastName,
            Role = u.Role
        });
    }
}