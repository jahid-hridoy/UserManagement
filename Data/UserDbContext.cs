using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) {}

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "Alice", LastName = "Smith", Role = "Admin" },
            new User { Id = 2, FirstName = "Bob", LastName = "Jones", Role = "Manager" },
            new User { Id = 3, FirstName = "Charlie", LastName = "Brown", Role = "Salesman" }
        );
    }
}