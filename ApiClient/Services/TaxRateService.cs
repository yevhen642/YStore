using ApiClient.Contracts.Responses;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace ApiClient.Services;

public class TaxRateService
{
    public string _apiKey { get; set; }
    private readonly IHttpClientFactory _httpClientFactory;

    public TaxRateService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _apiKey = configuration["ApiKeys:TaxRateApiKey"];
    }

    public async Task<string> GetTaxRateByStateCode(int stateCode)
    {
        try
        {
            using HttpClient client = _httpClientFactory.CreateClient();
            var response = await client.GetFromJsonAsync<GetRateByZip>(
                $"https://www.taxrate.io/api/v1/rate/getratebyzip?zip={stateCode}&api_key={_apiKey}",
                new JsonSerializerOptions(JsonSerializerDefaults.Web));

            return response.Rate.ToString();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error retrieving tax rate: {ex.Message}");
            throw;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error parsing response: {ex.Message}");
            throw;
        }
    }
}
