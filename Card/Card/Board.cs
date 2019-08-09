using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Board
    {
        public List<CombatCard> meleeCards, rangeCards, longRangeCards;
        public List<SpecialCard> captainCards, weatherCards;
        public SpecialCard[] specialMeleeCards, specialLongRangeCards, specialRangeCards;
        
        public Board(List<CombatCard> meleeCards, List<CombatCard> rangeCards, List<CombatCard> longRangeCards, List<SpecialCard> captainCards, List<SpecialCard> weatherCards, SpecialCard[] specialMeleeCards, SpecialCard[] specialLongRangeCards, SpecialCard[] specialRangeCards)
        {
            this.meleeCards = meleeCards;
            this.rangeCards = rangeCards;
            this.longRangeCards = longRangeCards;
            this.captainCards = captainCards;
            this.weatherCards = weatherCards;
            this.specialLongRangeCards = specialLongRangeCards;
            this.specialMeleeCards = specialMeleeCards;
            this.specialRangeCards = specialRangeCards;
        }

    }
}
