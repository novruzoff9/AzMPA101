using Axis.Data;
using Axis.Services;
using Axis.ViewModel.Teams;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Axis.Controllers;

public class HomeController : Controller
{
    private readonly ITeamService teamService;
    private readonly AppDbContext _dbContext;

    public HomeController(ITeamService teamService, AppDbContext dbContext)
    {
        this.teamService = teamService;
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var team = await _dbContext.Teams.ToListAsync();
        return View(team);
    }
}
