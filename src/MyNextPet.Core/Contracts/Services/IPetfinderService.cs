using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNextPet.Core.Models;

namespace MyNextPet.Core.Contracts.Services;
public interface IPetfinderService
{
    Task<string> GetAllPetsAsync();
    Task<PetType> GetPetsByTypeAsync(PetType petType);
    Task<List<Breed>> GetAnimalBreedsAsync(PetType petType);
    Task<string> GetAllOrganizationsAsync();
}
