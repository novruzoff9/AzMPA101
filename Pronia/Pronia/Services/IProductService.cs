using Pronia.Models;

namespace Pronia.Services;

public interface IProductService
{
    Task<List<Product>> GetAllAsync();
}
