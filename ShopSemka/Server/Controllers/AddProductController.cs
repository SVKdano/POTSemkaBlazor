using Microsoft.AspNetCore.Mvc;
using ShopSemka.Server.Data;

namespace ShopSemka.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddProductController : ControllerBase
{
    private readonly DataContext _context;

    public AddProductController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Product>> PostProduct(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Product>> DeleteProduct(int id)
    {
        var dbProduct = await _context.Products.FindAsync(id);

        if (dbProduct == null)
            return BadRequest();

        _context.Remove(dbProduct);
        await _context.SaveChangesAsync();

        return Ok();
    }
}