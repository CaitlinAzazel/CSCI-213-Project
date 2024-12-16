using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using AnniesCatSanctuary.Data;

namespace AnniesCatSanctuary.Services
{
    public class PetFileStorageService
    {
        private readonly string _filePath = "pets.json";

        // Load pets from the JSON file
        public List<Pet> LoadPets()
        {
            if (!File.Exists(_filePath)) return new List<Pet>(); // Return empty list if file doesn't exist

            var jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Pet>>(jsonString) ?? new List<Pet>();
        }

        // Save pets to the JSON file
        public void SavePets(List<Pet> pets)
        {
            var jsonString = JsonSerializer.Serialize(pets, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, jsonString);
        }
    }
}
