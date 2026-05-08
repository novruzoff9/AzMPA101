using _04._05.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _04._05.Controllers;

public class ServicesController : Controller
{
    private readonly AppDbContext _dbContext;

    public ServicesController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var services = await _dbContext.Services.ToListAsync();
        return View(services);
    }
}