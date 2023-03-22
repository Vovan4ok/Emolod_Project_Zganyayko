using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Shield
    {
        private string name;
        private int protection;
        public Shield(string name, int protection)
        {
            this.name = name;
            this.protection = protection;
        }
        public string getName() => this.name;
        public void setName(string name) => this.name = name;
        public int getProtection() => this.protection;
        public void setProtection(int protection) => this.protection = protection;
    }
}
