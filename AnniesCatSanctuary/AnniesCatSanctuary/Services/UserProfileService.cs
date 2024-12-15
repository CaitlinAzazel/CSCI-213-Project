using System.Net.Http.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AnniesCatSanctuary.Data;

namespace AnniesCatSanctuary.Services
{
    public class UserProfileService
    {
        private readonly HttpClient _httpClient;

        // Inject HttpClient into the service
        public UserProfileService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Method to fetch user profile by user ID
        public async Task<UserProfile> GetUserProfile(string userId)
        {
            return await _httpClient.GetFromJsonAsync<UserProfile>($"UserProfile/{userId}");
        }

        // Method to save or update user profile
        public async Task SaveUserProfile(UserProfile profile)
        {
            await _httpClient.PostAsJsonAsync("UserProfile", profile);
        }
    }
}
