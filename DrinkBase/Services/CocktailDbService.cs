using DrinkBase.Models;
using Newtonsoft.Json;

namespace DrinkBase.Services;

public class CocktailDbService
{
    private readonly CocktailDbHttpClient _httpClient;

    public CocktailDbService(CocktailDbHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Drink?> GetRandomDrink()
    {
        var result = await _httpClient.GetRandomDrink();

        if (!result.IsSuccessful)
        {
            return null;
        }

        var drink = JsonConvert.DeserializeObject<CocktailDbResponse>(result.Content);

        return drink?.Drinks.FirstOrDefault();
    }
}