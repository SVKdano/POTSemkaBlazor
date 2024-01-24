using ShopSemka.Server.Data;

namespace ShopSemka.Server.Services.UserService;

public class UserService : IUserService
{
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
        _context = context;
    }
    
    public async Task<ServiceResponse<User>> GetUserByPasswordAndName(string password, string name)
    {
        var result = new ServiceResponse<User>
        {
            Data = await _context.Users
                .Where(a => a.UserName == name && a.Password == password)
                .FirstOrDefaultAsync()
        };
        
        return result;
    }
}