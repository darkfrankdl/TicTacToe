using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject
{
    internal class Player1
    {
        public Player1(string name)
        {
            name = Name;
        }

        public string Name { get; set; }
        public int PlayerNumber { get; set; }
    }
}
