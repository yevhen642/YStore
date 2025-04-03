using Newtonsoft.Json;
using System.Text.Json;

namespace ApiClient.Contracts.Responses;

public class GetRateByZip
{
    [JsonProperty("rate")]
    public decimal Rate { get; set; }
}
