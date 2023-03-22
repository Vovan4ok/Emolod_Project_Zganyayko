using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Fireball : Skill
    {
        public Fireball()
        {
            this.name = "Fireball";
        }
        public override void useSkill(Monster monster)
        {
            monster.setHealth(monster.getHealth() - 500);
        }
    }
}
