using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class GameModel
    {
        public int GameId { get; set; }
        public string GameName { get; set; } = string.Empty;
        public int NumberOfPlayers { get; set; }
    }
}
