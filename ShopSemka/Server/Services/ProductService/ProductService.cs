using Microsoft.AspNetCore.Mvc;
using ShopSemka.Server.Data;

namespace ShopSemka.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _context;
    
    public ProductService(DataContext context)
    {
        _context = context;
    }
    
    public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data = await _context.Products.ToListAsync()
        };

        return response;
    }

    public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
    {
        var response = new ServiceResponse<Product>();
        var product = await _context.Products.FindAsync(productId);

        if (product == null)
        {
            response.Success = false;
            response.Message = "Hľadaný produkt neexistuje!";
        }
        else
        {
            response.Data = product;
        }

        return response;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data = await _context.Products
                .Where(a => a.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .ToListAsync()
        };

        return response;
    }
}