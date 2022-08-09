using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyNextPet.Core.Models;
public class PetOrganization
{
    [JsonPropertyName("id")]
    public string Id
    {
        get; set;
    }
    [JsonPropertyName("name")]
    public string OrganizationName
    {
        get; set;
    }

    [JsonPropertyName("email")]
    public string EmailAddress
    {
        get; set;
    }

    [JsonPropertyName("phone")]
    public string PhoneNumber
    {
        get; set;
    }

    [JsonPropertyName("url")]
    public Uri PetfinderUrl
    {
        get; set;
    }
    [JsonPropertyName("website")]
    public Uri OrganizationWebsite
    {
        get; set;
    }

}
