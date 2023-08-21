using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameAPIController : ControllerBase
    {
        [HttpGet("GetAllGames")]
        public IActionResult GetAllGames()
        {
            List<GameModel> gameModels = new List<GameModel>();

            gameModels.Add(new GameModel
            {
                GameId = 1,
                GameName = "FootBall",
                NumberOfPlayers = 11,
            });

            gameModels.Add(new GameModel
            {
                GameId = 2,
                GameName = "Cricket",
                NumberOfPlayers = 11,
            });

            gameModels.Add(new GameModel
            {
                GameId = 3,
                GameName = "Baskeball",
                NumberOfPlayers = 5,
            });

            return Ok(gameModels);
        }
    }
}
