namespace ShopSemka.Client.Services.UserService;

public interface IUserService
{
    public User SelectedUser { get; set; }

    Task GetUser(string userName, string password);
}