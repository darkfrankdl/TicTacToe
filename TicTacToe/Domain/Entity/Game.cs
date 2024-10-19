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
        public Player1 Player1 { get; set; }

        public Player2 Player2 { get; set; }

        public Board Board { get; set; }

        public bool CreateBoard ()
        {
            bool isBoardCreated = false;
            Board = new Board();
            isBoardCreated = true;
            return isBoardCreated;
        }


        public bool CreatePlayer(string playerName, int playerNumber)
        {
            bool success = false;
            if(playerNumber == 1)
            {
                Player1 = new Player1(playerName);
                Player1.PlayerNumber = playerNumber;
                success = true;
            }
            else if(playerNumber == 2)
            {
                Player2 = new Player2(playerName);
                Player2.PlayerNumber = playerNumber;
                success = true;
            }
            return success;
        }
    }
}
