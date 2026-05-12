using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
