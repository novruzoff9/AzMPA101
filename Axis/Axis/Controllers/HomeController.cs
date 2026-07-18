using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Axis.Controllers;

public class HomeController(AppDbContext dbContext) : Controller
{
    public async Task<IActionResult> Index()
    {
        var team = await dbContext.Teams.ToListAsync();
        return View(team);
    }
}
