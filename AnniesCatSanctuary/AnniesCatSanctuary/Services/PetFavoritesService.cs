using System.Collections.Generic;

namespace AnniesCatSanctuary.Services
{
    public class PetFavoritesService
    {
        private List<string> favoritePetNames = new List<string>();

        public List<string> GetFavoritePets()
        {
            return favoritePetNames;
        }

        public void ToggleFavorite(string petName)
        {
            if (favoritePetNames.Contains(petName))
            {
                favoritePetNames.Remove(petName);
            }
            else
            {
                favoritePetNames.Add(petName);
            }
        }
    }
}
