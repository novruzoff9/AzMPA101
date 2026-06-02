using logis.Data;
using logis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace logis.Areas.Admin.Controllers;

[Area("Admin")]
public class ServicesController : Controller
{
    private readonly AppDbContext DbContext;

    public ServicesController(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var service = await DbContext.Services.ToListAsync();
            return View(service);

    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Service service)
    {
        if (!ModelState.IsValid)
        {
            return View(service);
        }
        await DbContext.Services.AddAsync(service);
        await DbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
}
