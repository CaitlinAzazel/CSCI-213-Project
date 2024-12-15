namespace AnniesCatSanctuary.Services
{
    public class PetFavoritesService
    {
        private List<string> favoritePetNames = new List<string>(); // Store names of favorite pets

        // Get the list of favorite pet names
        public List<string> GetFavoritePets()
        {
            return favoritePetNames;
        }

        // Toggle favorite status for a pet
        public void ToggleFavorite(string petName)
        {
            if (favoritePetNames.Contains(petName))
            {
                favoritePetNames.Remove(petName);  // Remove from favorites
            }
            else
            {
                favoritePetNames.Add(petName);  // Add to favorites
            }
        }
    }
}
