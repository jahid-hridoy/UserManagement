using Microsoft.AspNetCore.Mvc;
using UserManagement.Services;

namespace UserManagement.Controllers;

public class UserController : Controller
{
    private readonly IUserService _userService;
    public UserController(IUserService userService) => _userService = userService;

    public IActionResult Index(string role)
    {
        ViewBag.SelectedRole = role;
        ViewBag.Roles = new List<string> { "Admin", "Manager", "Salesman" };
        var users = _userService.GetUsers(role);
        return View(users);
    }
}