namespace ShopSemka.Server.Services.UserService;

public interface IUserService
{
    Task<ServiceResponse<User>> GetUserByPasswordAndName(string password, string name);
}