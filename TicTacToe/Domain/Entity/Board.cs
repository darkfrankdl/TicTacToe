using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Board
    {
        private Piece?[,] _boardState;

        public Board()
        {
            _boardState = new Piece?[3,3];
        }

        public bool MakeMoveXorO(string XorO, int xPos, int yPos)
        {
            bool successInMakingMove = false;
            bool moveOn = true;
            // verification 
            string XorO_UpperCase = XorO.ToUpper();

            if(string.IsNullOrEmpty(XorO_UpperCase) || (XorO_UpperCase != "X" && XorO_UpperCase != "O"))
            {
                moveOn = false;
            }

            if (_boardState[yPos, xPos] != null) // not null means that a piece is already there on the board
            {
                moveOn = false;
            }

            if (moveOn) 
            {
                Piece piece = new Piece();
                piece.PieceSymbol = XorO_UpperCase;
                _boardState[yPos, xPos] = piece;
                successInMakingMove = true;
            }

            return successInMakingMove;
        }
    }
}
