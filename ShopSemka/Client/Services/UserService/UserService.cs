namespace ShopSemka.Client.Services.UserService;

public class UserService : IUserService
{
    private readonly HttpClient _httpClient;
    
    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public User SelectedUser { get; set; }
    
    public async Task GetUser(string userName, string password)
    {
        var response = await
            _httpClient.GetFromJsonAsync<ServiceResponse<User>>($"api/User/{userName}/{password}");
        
        if (response != null && response.Data != null)
            SelectedUser = response.Data;
    }
}