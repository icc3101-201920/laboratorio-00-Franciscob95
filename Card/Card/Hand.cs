using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Hand
    {
        public List<CombatCard> CombatCard;
        public List<SpecialCard> SpecialCard;

        public Hand(List<CombatCard> CombatCard, List<SpecialCard> SpecialCard)
        {
            this.CombatCard = CombatCard;
            this.SpecialCard = SpecialCard;
        }
         static void AddCombatCardHand (CombatCard CombatCard)
        {

        }
        static void AddSpecialCardHand (SpecialCard SpecialCard)
        {

        }
        static void DestroySpecialCardHand (SpecialCard SpecialCard)
        {

        }
        static void DestroyCombatCardHand(CombatCard CombatCard)
        {

        }
    }
}
