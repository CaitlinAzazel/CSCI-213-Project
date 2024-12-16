using System.Collections.Generic;
using System.Linq;
using AnniesCatSanctuary.Data;

namespace AnniesCatSanctuary.Services
{
    public class PetManagementService
    {
        private readonly List<Pet> _pets; // In-memory list of pets

        public PetManagementService()
        {
            _pets = new List<Pet>(); // Initialize the pets list
        }

        // Get the list of all pets
        public List<Pet> GetPets()
        {
            return _pets;
        }

        // Add a new pet
        public void AddPet(Pet newPet)
        {
            _pets.Add(newPet); // Add pet to in-memory list
        }

        // Remove a pet
        public void RemovePet(Pet petToRemove)
        {
            _pets.Remove(petToRemove); // Remove pet from in-memory list
        }

        // Hide a pet
        public void HidePet(Pet petToHide)
        {
            var pet = _pets.FirstOrDefault(p => p.Name == petToHide.Name);
            if (pet != null)
            {
                pet.IsHidden = true; // Mark the pet as hidden
            }
        }

        // Unhide a pet
        public void UnhidePet(Pet petToUnhide)
        {
            var pet = _pets.FirstOrDefault(p => p.Name == petToUnhide.Name);
            if (pet != null)
            {
                pet.IsHidden = false; // Mark the pet as visible
            }
        }
    }
}
