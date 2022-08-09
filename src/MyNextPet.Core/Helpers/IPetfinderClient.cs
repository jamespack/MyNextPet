using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNextPet.Core.Models;

namespace MyNextPet.Core.Helpers;
public interface IPetfinderClient
{
    Task CreateAsync();
    Task<string> GetAllAnimalsAsync();

    Task<string> GetPetsByTypeAsync(PetType petType);
    Task<string> GetAnimalBreedsAsync(PetType petType);
    Task<string> GetAllOrganizationsAsync();

    Task Initialization
    {
        get;
    }


}
