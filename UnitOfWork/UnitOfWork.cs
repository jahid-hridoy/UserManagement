using UserManagement.Data;
using UserManagement.Models;
using UserManagement.Repository;
using UserManagement.Services;

namespace UserManagement.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly UserDbContext _context;
    public UnitOfWork(UserDbContext context) => _context = context;
    public IUserRepository Users => new UserRepository(_context);
}