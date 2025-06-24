using UserManagement.Repository;

namespace UserManagement.UnitOfWork;

public interface IUnitOfWork
{
    IUserRepository Users { get; }
}