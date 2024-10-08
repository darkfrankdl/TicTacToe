using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.AggregateRoot;

namespace ApplicationLayer
{
    public class ApplicationGame
    {
        GameAggregateRoot gameAggregateRoot;

        // used for mock test
        public ApplicationGame(GameAggregateRoot rootGame)
        {
            gameAggregateRoot = rootGame;
        }

        public ApplicationGame()
        {
            gameAggregateRoot = new GameAggregateRoot();
        }

        public bool CreatePlayer(ApplicationPlayerModel player)
        {
            
            return gameAggregateRoot.CreatePlayer(player.Name, player.Player1Or2);
        }

        public ApplicationPlayerModel GetPlayer (int playerNumber)
        {
            ApplicationPlayerModel player = null;
            if(playerNumber == 1)
            {
                player = new ApplicationPlayerModel();
                player.Name = gameAggregateRoot.Game.Player1.Name;
                player.Player1Or2 = gameAggregateRoot.Game.Player1.PlayerNumber;
            }
            else if (playerNumber == 2)
            {
                player = new ApplicationPlayerModel();
                player.Name = gameAggregateRoot.Game.Player2.Name;
                player.Player1Or2 = gameAggregateRoot.Game.Player2.PlayerNumber;
            }

            return player;
        }

        public bool CreateBoard ()
        {
            bool isBoardCreated = gameAggregateRoot.Game.CreateBoard();
            return isBoardCreated;
        }
    }
}
