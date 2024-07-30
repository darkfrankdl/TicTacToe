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

        public Game Game { get; private set; }

        public bool CreatePlayer(string playerName, int playerNumber)
        {
           return Game.CreatePlayer(playerName, playerNumber);
        }
    }
}
