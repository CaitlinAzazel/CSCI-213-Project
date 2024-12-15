using AnniesCatSanctuary.Data;
using Microsoft.JSInterop;
using System.Text.Json;

public class PetManagementService
{
    private List<Pet> pets = new List<Pet>();  // Stores pets in memory

    // Get the list of all pets
    public List<Pet> GetPets()
    {
        return pets;
    }

    // Add a new pet to the list
    public void AddPet(Pet newPet)
    {
        pets.Add(newPet);
    }

    // Remove a pet from the list
    public void RemovePet(Pet petToRemove)
    {
        pets.Remove(petToRemove);
    }

    // Hide a pet
    public void HidePet(Pet petToHide)
    {
        var pet = pets.FirstOrDefault(p => p.Name == petToHide.Name);
        if (pet != null)
        {
            pet.IsHidden = true; // Mark the pet as hidden
        }
    }

    // Unhide a pet
    public void UnhidePet(Pet petToUnhide)
    {
        var pet = pets.FirstOrDefault(p => p.Name == petToUnhide.Name);
        if (pet != null)
        {
            pet.IsHidden = false; // Mark the pet as visible again
        }
    }
}
