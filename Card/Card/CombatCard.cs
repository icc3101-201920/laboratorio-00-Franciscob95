using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class CombatCard
    {
        public string name, type, effect;
        public bool hero;
        public int attackPoints;

        public CombatCard(string name, string type, string effect, bool hero, int attackPoints)
        {
            this.name = name;
            this.type = type;
            this.effect = effect;
            this.hero = hero;
            this.attackPoints = attackPoints;   
        }
    }
}
