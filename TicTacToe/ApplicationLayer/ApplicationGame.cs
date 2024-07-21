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

        public static void PlayerInfo(ApplicationPlayerModel player)
        {
            appGame.CreatePlayer(player);
        }
    }
}
