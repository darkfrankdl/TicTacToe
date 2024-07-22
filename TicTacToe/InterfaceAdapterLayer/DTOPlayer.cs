using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAdapterLayer
{
    public class DTOPlayer
    {
        public DTOPlayer(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Player1Or2 { get; set; }
    }
}
