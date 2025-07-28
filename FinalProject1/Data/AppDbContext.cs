using Microsoft.EntityFrameworkCore;
using FinalProject1.Models;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Hobby> Hobbies { get; set; }
    public DbSet<BreakfastFood> BreakfastFoods { get; set; }
    public DbSet<FavoriteMovie> FavoriteMovies { get; set; }
}