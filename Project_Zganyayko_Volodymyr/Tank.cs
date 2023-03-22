using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Tank : Player
    {
        public Tank(string name) : base(name)
        {
            this.power = 20;
            this.endurance = 15;
            this.agility = 5;
        }
    }
}
