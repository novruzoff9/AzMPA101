using AzMPA101Api.Dto.Account;
using AzMPA101Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AzMPA101Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController(
    RoleManager<IdentityRole> roleManager,
    IConfiguration configuration,
    UserManager<AppUser> userManager
    ) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        AppUser newUser = new()
        {
            FullName = registerDto.FullName,
            Email = registerDto.Email,
            UserName = registerDto.UserName,
        };
        var result = await userManager.CreateAsync(newUser, registerDto.Password);
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        var roleResult = await userManager.AddToRoleAsync(newUser, "Member");
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var user = await userManager.FindByEmailAsync(loginDto.Email);
        if (user is null)
            return NotFound("Istifadeci tapilmadi");
        var succeeed = await userManager.CheckPasswordAsync(user, loginDto.Password);
        if (!succeeed)
            return BadRequest("Parol yanlisdir");

        var roles = await userManager.GetRolesAsync(user);

        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim("Full Name", user.FullName)
        };

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        var secretKey = configuration.GetSection("Jwt")["SecretKey"];

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenOptions = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddSeconds(20),
            signingCredentials: creds
        );

        var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        return Ok(token);
    }
}
