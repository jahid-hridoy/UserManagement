using UserManagement.Data;
using UserManagement.Models;

namespace UserManagement.Repository;

public class UserRepository : IUserRepository
{
    private readonly UserDbContext _context;
    public UserRepository(UserDbContext context) => _context = context;

    public IEnumerable<User> GetAll() => _context.Users.ToList();
    public IEnumerable<User> GetByRole(string role) =>
        _context.Users.Where(u => u.Role == role).ToList();
}