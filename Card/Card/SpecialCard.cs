using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class SpecialCard
    {
        public string name, type, buffType, effect;
        public SpecialCard(string name, string type, string buffType, string effect)
        {
            this.name = name;
            this.type = type;
            this.buffType = buffType;
            this.effect = effect;
        }

    }
}
