using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Weapon
    {
        private string name;
        private int damage;
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
        public string getName() => this.name;
        public void setName(string name) => this.name = name;
        public int getDamage() => this.damage;
        public void setDamage(int damage) => this.damage = damage;
    }
}
