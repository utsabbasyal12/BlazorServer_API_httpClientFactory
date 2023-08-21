using ModelLibrary.Model;

namespace BlazorServerUI.Services
{
    public interface IGameService
    {
        Task<List<GameModel>> GetAllGamesAsync();
    }
}
