namespace FinalProject.Models;

public class BreakfastFood
{
    public int Id { get; set; }
    public string FoodName { get; set; } = string.Empty;
    public string OriginCountry { get; set; } = string.Empty;
    public int Calories { get; set; }
    public bool IsVegetarian { get; set; }
}