using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    internal class Game
    {
        private Player1 _player1;
        private Player2 _player2;
        internal void CreatePlayer(string playerName, int playerNumber)
        {
            if(playerNumber == 1)
            {
                _player1 = new Player1(playerName);
                _player1.PlayerNumber = playerNumber;
            }
            else if(playerNumber == 2)
            {
                _player2 = new Player2(playerName);
                _player2.PlayerNumber = playerNumber;
            }
        }
    }
}
