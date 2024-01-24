namespace ShopSemka.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    
    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public event Action? ProductsChanged;
    public List<Product> Products { get; set; } = new List<Product>();
    
    public async Task GetProducts(string? categoryURL = null)
    {
        var result = categoryURL == null ?
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>
                ("api/Product")
            : 
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>
                ($"api/Product/category/{categoryURL}");
        
        if (result != null && result.Data != null)
            Products = result.Data;
        
        //Checks if category is changed
        ProductsChanged.Invoke();
    }

    public async Task<ServiceResponse<Product>> GetProduct(int productId)
    {
        var result =
            await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/{productId}");
        return result;
    }

    public async Task PostProduct(Product product)
    {
        var result = await _httpClient.PostAsJsonAsync("api/AddProduct", product);
    }

    public async Task DeleteProduct(int id)
    {
        var result = await _httpClient.DeleteAsync($"api/AddProduct/{id}");
    }
}