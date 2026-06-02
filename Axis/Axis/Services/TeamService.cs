using Axis.Data;
using Axis.Models;
using Microsoft.EntityFrameworkCore;

namespace Axis.Services;

public class TeamService : ITeamService
{
    private readonly AppDbContext _dbContext;

    public TeamService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Team>> GetAllTeamsAsync()
    {
        var teams = await _dbContext.Teams.ToListAsync();
        return teams;
    }
}
