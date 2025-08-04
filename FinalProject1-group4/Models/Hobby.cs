namespace FinalProject.Models;

public class Hobby
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SkillLevel { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int HoursPerWeek { get; set; }
}