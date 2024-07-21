using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject
{
    internal class Player2
    {
        public Player2(string name)
        {
             Name= name;
        }

        public string Name { get; set; }
        public int PlayerNumber { get; set; }
    }
}
