using _04._05.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _04._05.Controllers;

public class TeamController : Controller
{
    private readonly AppDbContext _dbContext;

    public TeamController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var teamMembers = await _dbContext.TeamMembers
            .Include(x=> x.SocialMedias)
            .ToListAsync();
        return View(teamMembers);
    }
}
