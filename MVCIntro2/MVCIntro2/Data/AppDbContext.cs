using Microsoft.EntityFrameworkCore;
using MVCIntro2.Models;

namespace MVCIntro2.Data;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
