using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAdapterLayer
{
    public interface IGame
    {
        bool Player1(string name);
        bool Player2(string name);
    }
}
