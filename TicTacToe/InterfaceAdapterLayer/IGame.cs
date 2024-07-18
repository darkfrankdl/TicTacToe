﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAdapterLayer
{
    public interface IGame
    {
        DTOPlayer CreatePlayer(string name);
        int MakeMove(DTOPlayer currentPlayer, int wantedPlayerMove);
    }
}
