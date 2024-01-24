using System.Security.Claims;
using ShopSemka.Client.Services.UserService;

namespace ShopSemka.Client;

public class CustomAuthProvider : AuthenticationStateProvider
{
    private readonly IUserService _userService;

    public CustomAuthProvider(IUserService userService)
    {
        _userService = userService;
    }

    public string username { get; set; } = "Admin";
    public string password { get; set; } = "admin123";
    
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        bool isAuthenticated = await CheckAuth();

        if (isAuthenticated)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, _userService.SelectedUser.UserName),
                new Claim(ClaimTypes.Role, "admin"),
            }, "custom");

            var user = new ClaimsPrincipal(identity);

            var state = new AuthenticationState(user);

            return state;
        }
        else
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            return state;
        }
    }

    public async Task<bool> CheckAuth()
    {
        await _userService.GetUser(this.username, this.password);

        return _userService.SelectedUser != null;
    }

}