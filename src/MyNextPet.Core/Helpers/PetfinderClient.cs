using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyNextPet.Core.Models;

namespace MyNextPet.Core.Helpers;

public class PetfinderClientAuthResponse
{
    public string token_type
    {
        get; set;
    }

    public int expires_in
    {
        get; set;
    }
    public string access_token
    {
        get; set;
    }
}
public class PetfinderClient : IPetfinderClient
{
    private const string ApiKey = "oVg7ume8Gbu4LPpnxBCfGPgMUl0KUg3elW9PTM4V4o22cVNSip";
    private const string Secret = "fwv00IHQIGmNUvmBqo42fG6UMCWiz0N7vRyTFLye";
    private const string AuthEndpoint = "https://api.petfinder.com/v2/oauth2/token";
    private const string AllAnimalsEndpoint = "https://api.petfinder.com/v2/animals";
    private const string AnimalTypesEndpoint = "https://api.petfinder.com/v2/types";
    private const string AllOrganizationsEndpoint = "https://api.petfinder.com/v2/organizations";

    private HttpClient _client;

    public List<PetType> PetTypes
    {
        get; set;
    } = new List<PetType>();
    public string AccessToken
    {
        get; private set;
    }

    public Uri AuthUrl
    {
        get; private set;
    }

    public Task Initialization
    {
        get; private set;
    }



    public PetfinderClient()
    {
        Initialization = CreateAsync();
    }



    private async Task AuthenticateClientAsync()
    {

        var content = new Dictionary<string, string>();
        content.Add("grant_type", "client_credentials");
        content.Add("client_id", ApiKey);
        content.Add("client_secret", Secret);
        var response = await _client.PostAsync(AuthUrl, new FormUrlEncodedContent(content));
        var responseString = await response.Content.ReadAsStringAsync();
        var authResponse = JsonSerializer.Deserialize<PetfinderClientAuthResponse>(responseString);
        if (authResponse is not null)
        {
            AccessToken = authResponse.access_token;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        }
    }

    public Task<string> GetAllAnimalsAsync()
    {
        return _client.GetStringAsync(new Uri(AllAnimalsEndpoint));
    }
    private async Task IntializeAsync()
    {
        _client = new HttpClient();
        AuthUrl = new Uri(AuthEndpoint);
        await AuthenticateClientAsync();
        await GetPetTypesAsync();

    }

    private async Task GetPetTypesAsync()
    {
        var animalTypes = await _client.GetStringAsync(new Uri(AnimalTypesEndpoint));
        PetTypes = JsonSerializer.Deserialize<PetfinderApiResponse>(animalTypes).Types;

    }

    public async Task CreateAsync()
    {
        await IntializeAsync();
    }

    public Task<string> GetPetsByTypeAsync(PetType petType)
    {
        return _client.GetStringAsync($"{AnimalTypesEndpoint}/{petType.Name}");
    }

    public Task<string> GetAnimalBreedsAsync(PetType petType)
    {
        return _client.GetStringAsync($"{AnimalTypesEndpoint}/{petType.Name}/breeds");
    }

    public Task<string> GetAllOrganizationsAsync()
    {
        return _client.GetStringAsync(AllOrganizationsEndpoint);
    }
}

