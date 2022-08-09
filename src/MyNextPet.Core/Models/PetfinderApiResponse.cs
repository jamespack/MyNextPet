using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MyNextPet.Core.Models;
public class PetfinderApiResponse
{
    [JsonPropertyName("types")]
    public List<PetType> Types
    {
        get;set;
    }

    [JsonPropertyName("type")]
    public PetType PetType
    {
        get;set;
    }

    [JsonPropertyName("breeds")]
    public List<Breed> Breeds
    {
        get; set;
    }

    [JsonPropertyName("organizations")]
    public List<PetOrganization> Organizations
    {
        get; set;
    }

    [JsonPropertyName("pagination")]
    public PetfinderApiPagination PaginationInformation
    {
        get; set;
    }


}

public class PetfinderApiPagination
{
    [JsonPropertyName("count_per_page")]
    public int OrganizationsPerPage
    {
        get; set;
    }

    [JsonPropertyName("total_count")]
    public int TotalOrganizationsCount
    {
        get; set;
    }

    [JsonPropertyName("current_page")]
    public int CurrentPage
    {
        get; set;
    }
    [JsonPropertyName("total_pages")]
    public int TotalPageCount
    {
        get; set;
    }
}