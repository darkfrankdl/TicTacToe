using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class ApplicationBoardModel
    {
        public Board Board { get; set; }
        public int BoardPosition { get; set; }
        public string[,] BoardPositionSymbols { get; set; } // X or O
    }
}
