using System.Text.Json;
using DrinkBase.Models;
using RestSharp;

namespace DrinkBase.Services;

public class CocktailDbHttpClient
{
    public async Task<RestResponse> GetRandomDrink()
    {
        var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/random.php");

        var request = new RestRequest();

        return await client.ExecuteAsync(request);
    }
}