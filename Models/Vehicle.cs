using System.Text.Json.Serialization;

namespace StarWarsApp.Models;

public class Vehicle
{
    public string Name { get; set; } = "";

    [JsonPropertyName("cost_in_credits")]
    public string CostInCredits { get; set; } = "";

    public string Manufacturer { get; set; } = "";

    [JsonPropertyName("url")]
    public string Url { get; set; } = "";
}