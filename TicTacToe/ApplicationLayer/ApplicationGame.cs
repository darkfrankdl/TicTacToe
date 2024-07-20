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
        public void CreatePlayer(ApplicationPlayerModel player)
        {
            GameAggregateRoot gameAggregateRoot = new GameAggregateRoot();

            gameAggregateRoot.CreatePlayer(player.Name, player.Player1Or2);
        }
    }
}
