using _04._05.Models;

namespace _04._05.Services.Interfaces;

public interface ITeamMemberService
{
    public Task<List<TeamMember>> GetAllAsync();
}
