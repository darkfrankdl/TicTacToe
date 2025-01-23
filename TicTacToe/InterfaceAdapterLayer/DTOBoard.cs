using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAdapterLayer
{
    public class DTOBoard
    {
        public string[,] PositionSymbols { get; set; }
        public Board Board { get; set; }
    }
}
