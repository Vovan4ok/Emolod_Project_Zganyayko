using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    abstract class Skill
    {
        protected string name;
        public string getName() => this.name;
        public abstract void useSkill(Monster monster);
    }
}
