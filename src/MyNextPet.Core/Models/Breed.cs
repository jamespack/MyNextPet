using System.Text.Json.Serialization;


namespace MyNextPet.Core.Models;

public class Breed
{
    [JsonPropertyName("name")]
    public string Name
    {
        get; set;
    }
}