using _04._05.Data;
using _04._05.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _04._05.Controllers;

public class TeamController : Controller
{
    private readonly ITeamMemberService _teamMemberService;

    public TeamController(ITeamMemberService teamMemberService)
    {
        _teamMemberService = teamMemberService;
    }

    public async Task<IActionResult> Index()
    {
        var teamMembers =await _teamMemberService.GetAllAsync();
        return View(teamMembers);
    }
}
