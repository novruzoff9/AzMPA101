using Axis.Models;

namespace Axis.Services;

public interface ITeamService
{
    Task<List<Team>> GetAllTeamsAsync();
}
