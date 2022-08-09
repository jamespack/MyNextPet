using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyNextPet.Core.Contracts.Services;
using MyNextPet.Core.Helpers;
using MyNextPet.Core.Models;

namespace MyNextPet.Core.Services;
public class PetfinderService : IPetfinderService
{
    IPetfinderClient _client;
    public Task<IPetfinderClient> Initialization
    {
        get; private set;
    }
    public PetfinderService(IPetfinderClient client)
    {
        _client = client;
    }

    public async Task<string> GetAllOrganizationsAsync()
    {
        await EnsureClientReadyAsync();
        var orgs = await _client.GetAllOrganizationsAsync();
        var o = JsonSerializer.Deserialize<PetfinderApiResponse>(orgs);
        return "";
    }

    private async Task EnsureClientReadyAsync()
    {
        var clientService = _client as IPetfinderService;
        if (clientService == null)
            await _client.Initialization;
    }

    public async Task<string> GetAllPetsAsync()
    {
        await EnsureClientReadyAsync();
        var animals = await _client.GetAllAnimalsAsync();
        return animals;

    }

    public async Task<List<Breed>> GetAnimalBreedsAsync(PetType petType)
    {
        await EnsureClientReadyAsync();
        var breeds = await _client.GetAnimalBreedsAsync(petType);
        return JsonSerializer.Deserialize<PetfinderApiResponse>(breeds).Breeds;
    }

    public async Task<PetType> GetPetsByTypeAsync(PetType petType)
    {
        await EnsureClientReadyAsync();
        var pet = await _client.GetPetsByTypeAsync(petType);
        return JsonSerializer.Deserialize<PetfinderApiResponse>(pet).PetType;
    }

}
