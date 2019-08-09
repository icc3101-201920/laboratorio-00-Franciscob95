using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Deck
    {

        public List<CombatCard> combatCard;
        public List<SpecialCard> specialCard;
        public Deck(List<CombatCard> combatCard, List<SpecialCard> specialCard)
        {
            this.combatCard = combatCard;
            this.specialCard = specialCard;
        }

        public void AddCombatCard(CombatCard combatCard)
        {

        }
        public void AddSpecialCard (SpecialCard specialCard)
        {

        }
        public void DestroyCombatCard (CombatCard combatCard)
        {

        }
        public void DestroySpecialCard (SpecialCard specialCard)
        {

        }
        public void Shuffle()
        {

        }

    }
}
