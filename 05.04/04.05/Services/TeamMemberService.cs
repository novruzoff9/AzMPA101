using _04._05.Data;
using _04._05.Models;
using _04._05.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _04._05.Services;

public class TeamMemberService : ITeamMemberService
{
    private readonly AppDbContext _context;
    public TeamMemberService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<TeamMember>> GetAllAsync()
    {
        var teamMembers = await _context.TeamMembers.Include(x => x.SocialMedias).ToListAsync();
        return teamMembers;
    }
}
