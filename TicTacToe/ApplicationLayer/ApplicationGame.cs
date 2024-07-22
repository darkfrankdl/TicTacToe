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
        GameAggregateRoot gameAggregateRoot = new GameAggregateRoot();
        private static readonly ApplicationGame appGame = new ApplicationGame();

        public void CreatePlayer(ApplicationPlayerModel player)
        {
            
            gameAggregateRoot.CreatePlayer(player.Name, player.Player1Or2);
        }

        public ApplicationPlayerModel GetPlayer (int playerNumber)
        {
            ApplicationPlayerModel player = new ApplicationPlayerModel();
            if(playerNumber == 1)
            {
                player.Name = gameAggregateRoot.Game.Player1.Name;
                player.Player1Or2 = gameAggregateRoot.Game.Player1.PlayerNumber;
            }
            else if (playerNumber == 2)
            {
                player.Name = gameAggregateRoot.Game.Player2.Name;
                player.Player1Or2 = gameAggregateRoot.Game.Player2.PlayerNumber;
            }

            return player;
        }

        public static void PlayerInfo(ApplicationPlayerModel player)
        {
            appGame.CreatePlayer(player);
        }

        public static ApplicationPlayerModel GetPlayerInfo(int playerNumber)
        {
            return appGame.GetPlayer(playerNumber);
        }
    }
}
