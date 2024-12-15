using AnniesCatSanctuary.Data;
using Microsoft.JSInterop;

namespace AnniesCatSanctuary.Services
{
    public class UserProfileStorageService
    {
        private readonly IJSRuntime _jsRuntime;

        public UserProfileStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        // Save user profile to localStorage
        public async Task SaveProfileToLocalStorage(string key, UserProfile profile)
        {
            var profileJson = System.Text.Json.JsonSerializer.Serialize(profile);
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, profileJson);
        }

        // Get user profile from localStorage
        public async Task<UserProfile> GetProfileFromLocalStorage(string key)
        {
            var profileJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
            if (string.IsNullOrEmpty(profileJson))
            {
                return null;
            }
            return System.Text.Json.JsonSerializer.Deserialize<UserProfile>(profileJson);
        }

        // Remove user profile from localStorage
        public async Task RemoveProfileFromLocalStorage(string key)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }
    }
}
