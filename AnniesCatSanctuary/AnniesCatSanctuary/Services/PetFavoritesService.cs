namespace AnniesCatSanctuary.Services
{
    public class PetFavoritesService
    {
        private readonly List<string> _favoritePetNames; // In-memory list of favorite pet names

        public PetFavoritesService()
        {
            _favoritePetNames = new List<string>(); // Initialize the favorites list
        }

        // Get the list of favorite pet names
        public List<string> GetFavoritePets()
        {
            return _favoritePetNames;
        }

        // Toggle favorite status for a pet
        public void ToggleFavorite(string petName)
        {
            if (_favoritePetNames.Contains(petName))
            {
                _favoritePetNames.Remove(petName);  // Remove from favorites
            }
            else
            {
                _favoritePetNames.Add(petName);  // Add to favorites
            }
        }
    }
}
