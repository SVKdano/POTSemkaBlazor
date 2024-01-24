using Microsoft.AspNetCore.Mvc;
using ShopSemka.Server.Services.UserService;

namespace ShopSemka.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet("{userName}/{password}")]
    public async Task<ActionResult<ServiceResponse<User>>> GetUser(string userName, string password)
    {
        var result = await _userService.GetUserByPasswordAndName(password, userName);
        return Ok(result);
    }
}