using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyNextPet.Core.Models.Enums;


namespace MyNextPet.Core.Models;
public class PetType
{
    
    [JsonPropertyName("name")]
    public string Name
    {
        get; set;
    }

    [JsonPropertyName("colors")]
    public List<Color> Colors
    {
        get; set;
    }

    [JsonPropertyName("coats")]
    public List<Coat> Coats
    {
        get; set;
    }
    [JsonPropertyName("genders")]
    public List<Gender> Genders
    {
        get; set;
    }
}
