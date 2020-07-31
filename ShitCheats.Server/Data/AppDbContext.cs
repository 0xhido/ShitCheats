using Microsoft.EntityFrameworkCore;
using ShitCheats.Server.Models;

namespace ShitCheats.Server.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }
    public DbSet<Command> Commands { get; set; }
  }
}