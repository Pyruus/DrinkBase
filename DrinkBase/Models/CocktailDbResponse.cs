using System.Text.Json.Serialization;

namespace DrinkBase.Models;

public class CocktailDbResponse
{
    public List<Drink> Drinks { get; set; }
}

public class Drink
{
    public string StrDrink { get; set; }
    public string StrCategory { get; set; }
    public string StrInstructions { get; set; }
}