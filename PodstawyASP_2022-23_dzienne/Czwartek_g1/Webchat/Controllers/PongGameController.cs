using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webchat.Game;

namespace Webchat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PongGameController : ControllerBase
    {
        private static int numberOfPlayers = 0;
        private static int maxNumberOfPlayers = 1;
        private static PongGame game = PongGame.BuildGame();

        [HttpGet]
        public Object GetGameState()
        {
            var gameState = game.GameState();
            return gameState;
        }

        [HttpPost]
        public Object AddNewPlayer()
        {
            //No concurrence checking
            if (numberOfPlayers < 3)
            {
                numberOfPlayers++;
                if (numberOfPlayers == maxNumberOfPlayers)
                {
                    System.Diagnostics.Debug.WriteLine("Starting the game");
                    game.StartGame();
                    return new { id = (numberOfPlayers - 1), gameStaeted = true };
                }
                return new { id = (numberOfPlayers - 1), gameStaeted = false };
            }
            return new { id = 0, gameStarted = false, message="Too many players" };
        }

        [HttpPut]
        public Object PlayerMoved(int id, int direction)
        {
            
            return game.MovePalette(id, direction);
        }

        
    }
}
