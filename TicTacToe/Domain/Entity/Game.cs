using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Game
    {
        private Player1 _player1;
        private Player2 _player2;
        private Board _board;
        public Player1 Player1 
        { 
            get
            {
                return _player1;
            }
        }

        public Player2 Player2
        {
            get
            {
                return _player2;
            }
        }

        public bool CreateBoard ()
        {
            bool isBoardCreated = false;
            if (_board == null)
            {
                _board = new Board();
                isBoardCreated = true;
            }
            return isBoardCreated;
        }


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
