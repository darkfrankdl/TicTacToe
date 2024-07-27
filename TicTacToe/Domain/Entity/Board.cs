using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Board
    {
        private Piece _X1;
        private Piece _X2;
        private Piece _X3;
        private Piece _X4;
        private Piece _X5;
        private Piece _O1;
        private Piece _O2;
        private Piece _O3;
        private Piece _O4;

        private Piece[] pieces;

        public Board()
        {
            pieces = new Piece[9];
        }
    }
}
