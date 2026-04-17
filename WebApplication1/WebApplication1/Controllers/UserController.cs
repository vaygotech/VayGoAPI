using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    // ✅ GET ALL USERS
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAllUsers();
        return Ok(users);
    }

    // ✅ GET USER BY ID
    [HttpGet("{GetById}")]
    public IActionResult GetById(int id)
    {
        var user = _userService.GetUserById(id);

        if (user == null)
            return NotFound("User not found");

        return Ok(user);
    }
}