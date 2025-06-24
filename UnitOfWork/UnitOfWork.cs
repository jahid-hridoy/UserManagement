using UserManagement.Data;
using UserManagement.Repository;

namespace UserManagement.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly UserDbContext _context;
    public UnitOfWork(UserDbContext context) => _context = context;
    public IUserRepository Users => new UserRepository(_context);
}