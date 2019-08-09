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
        public void AddCombatCardHand (CombatCard CombatCard)
        {

        }
        public void AddSpecialCardHand (SpecialCard SpecialCard)
        {

        }
        public void DestroySpecialCardHand (SpecialCard SpecialCard)
        {

        }
        public void DestroyCombatCardHand(CombatCard CombatCard)
        {

        }
    }
}
