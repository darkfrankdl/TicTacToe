using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateRoot
{
    public class GameAggregateRoot
    {
        public GameAggregateRoot()
        {
            Game = new Game();
        }

        internal Game Game { get; private set; }

        public void CreatePlayer(string playerName, int playerNumber)
        {
            Game.CreatePlayer(playerName, playerNumber);
        }
    }
}
