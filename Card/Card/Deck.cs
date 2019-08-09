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

        static void AddCombatCard(CombatCard combatCard)
        {

        }
        static void AddSpecialCard (SpecialCard specialCard)
        {

        }
        static void DestroyCombatCard (CombatCard combatCard)
        {

        }
        static void DestroySpecialCard (SpecialCard specialCard|)
        {

        }
        static void Shuffle()
        {

        }

    }
}
