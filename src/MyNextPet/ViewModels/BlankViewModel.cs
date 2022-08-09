using CommunityToolkit.Mvvm.ComponentModel;
using MyNextPet.Contracts.ViewModels;
using MyNextPet.Core.Contracts.Services;
using MyNextPet.Core.Models;

namespace MyNextPet.ViewModels;

public class BlankViewModel : ObservableRecipient, INavigationAware
{
    private readonly IPetfinderService _petfinderService;

    public BlankViewModel(IPetfinderService petfinderService)
    {
        _petfinderService = petfinderService;
    }

    public void OnNavigatedFrom()
    {
    }

    
    public async void OnNavigatedTo(object parameter)
    {
        var pets =  await _petfinderService.GetAllPetsAsync();

        var dog = await _petfinderService.GetPetsByTypeAsync(new Dog());
        var cat = await _petfinderService.GetPetsByTypeAsync(new Cat());
        var horse = await _petfinderService.GetPetsByTypeAsync(new Horse());
        var rabbit = await _petfinderService.GetPetsByTypeAsync(new Rabbit());
        var scales = await _petfinderService.GetPetsByTypeAsync(new ScalesFinsAndOthers());
        var furry = await _petfinderService.GetPetsByTypeAsync(new SmallAndFurry());
        var bird = await _petfinderService.GetPetsByTypeAsync(new Bird());
        var breeds = await _petfinderService.GetAnimalBreedsAsync(new Dog());
        var orgs = await _petfinderService.GetAllOrganizationsAsync();


    }
}
