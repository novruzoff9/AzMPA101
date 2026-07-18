using Axis.Data;
using Axis.Models;
using Axis.Services;
using Axis.ViewModel.Teams;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Axis.Areas.Admin.Controllers;

[Area("Admin")]
public class TeamsController : Controller
{
    private readonly AppDbContext _dbContext;
    private readonly ITeamService _teamService;
    private readonly IFileService _fileService;

    public TeamsController(AppDbContext dbContext, ITeamService teamService, IFileService fileService)
    {
        _dbContext = dbContext;
        _teamService = teamService;
        _fileService = fileService;
    }

    public async Task<IActionResult> Index()
    {
        var teams = await _dbContext.Teams.ToListAsync();
        return View(teams);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id is null)
            return BadRequest();
        var data = await _dbContext.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (data is null)
            return NotFound();
        return View(data);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTeamVM teamVM)
    {
        if (!ModelState.IsValid)
            return View(teamVM);

        Team newTeam = new()
        {
            FullName = teamVM.FullName,
            Description = teamVM.Description,
            Position = teamVM.Position
        };

        if(teamVM.ImageUrl is not null)
        {
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/img/person");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var filePath = Path.Combine(uploadsFolder, teamVM.ImageUrl.FileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            teamVM.ImageUrl.CopyTo(stream);
            newTeam.ImageUrl = teamVM.ImageUrl.FileName;
        }

        await _dbContext.Teams.AddAsync(newTeam);
        await _dbContext.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null)
            return BadRequest();
        var data = await _dbContext.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (data is null)
            return NotFound();

        EditTeamVm teamVm = new()
        {
            FullName = data.FullName,
            Description = data.Description,
            Position = data.Position,
        };

        return View(teamVm);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int? id, EditTeamVm teamVm)
    {
        if (!ModelState.IsValid)
            return View(teamVm);

        if (id is null)
            return BadRequest();
        var data = await _dbContext.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (data is null)
            return NotFound();

        data.FullName = teamVm.FullName;
        data.Position = teamVm.Position;
        data.Description = teamVm.Description;

        if (teamVm.ImageUrl is not null)
        {
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/img/person");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var filePath = Path.Combine(uploadsFolder, teamVm.ImageUrl.FileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            teamVm.ImageUrl.CopyTo(stream);
            data.ImageUrl = teamVm.ImageUrl.FileName;
        }

        await _dbContext.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null)
            return BadRequest();
        var data = await _dbContext.Teams.FirstOrDefaultAsync(x=> x.Id == id);
        if (data is null)
            return NotFound();
        _dbContext.Teams.Remove(data);
        await _dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
