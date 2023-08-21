using ModelLibrary.Model;

namespace BlazorServerUI.Services
{
    public class GameService : IGameService
    {
        public readonly HttpClient _httpClient;
        public GameService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("API");
        }

        public async Task<List<GameModel>> GetAllGamesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<GameModel>>("GameAPI/GetAllGames");
        } 
    }
}
