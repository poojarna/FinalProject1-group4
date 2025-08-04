using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TeamMember> TeamMembers => Set<TeamMember>();
    public DbSet<Hobby> Hobbies => Set<Hobby>();
    public DbSet<BreakfastFood> BreakfastFoods => Set<BreakfastFood>();
    public DbSet<FavoriteMovie> FavoriteMovies => Set<FavoriteMovie>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TeamMember>().HasData(
            new TeamMember { Id = 1, FullName = "Alice Johnson", Birthdate = new DateTime(2002, 5, 12), CollegeProgram = "Computer Science", YearInProgram = "Junior" }
        );

        modelBuilder.Entity<Hobby>().HasData(
            new Hobby { Id = 1, Name = "Guitar", SkillLevel = "Intermediate", Description = "Playing acoustic guitar", HoursPerWeek = 5 }
        );

        modelBuilder.Entity<BreakfastFood>().HasData(
            new BreakfastFood { Id = 1, FoodName = "Pancakes", OriginCountry = "USA", Calories = 350, IsVegetarian = true }
        );

        modelBuilder.Entity<FavoriteMovie>().HasData(
            new FavoriteMovie { Id = 1, Title = "Inception", Genre = "Sci-Fi", Director = "Christopher Nolan", LeadActor = "Leonardo DiCaprio" }
        );
    }
}