using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.Data;
using Pronia.Models;
using Pronia.Services;
using System.Threading.Tasks;

namespace Pronia.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly AppDbContext _dbContext;

    public ProductController(IProductService productService, AppDbContext dbContext)
    {
        _productService = productService;
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _productService.GetAllAsync();
        return View(products);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var data = await _dbContext.Products.FirstOrDefaultAsync(x=>x.Id==id);
        _dbContext.Products.Remove(data);
        await _dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        _dbContext.Products.Add(product);
        await _dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Edit (int id )
    {
        var data = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        return View(data);
    }
    [HttpPost]
    public async Task<IActionResult> Edit (Product product,int id )
    {
        var data = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id==id);
        data.Name = product.Name;
        data.Price = product.Price;
        data.ImageUrl = product.ImageUrl;
        await _dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}