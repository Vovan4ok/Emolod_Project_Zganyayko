using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Robber : Player
    {
        public Robber(string name) : base(name)
        {
            this.power = 10;
            this.endurance = 5;
            this.agility = 25;
        }
    }
}
