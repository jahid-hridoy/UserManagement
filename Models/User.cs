using System.ComponentModel.DataAnnotations;
namespace UserManagement.Models;

public class User
{
    [Key]
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public string LastName { get; set; }
    public required string Role { get; set; }
}