using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Player
    {
        public int lifePoints, attackPoints;
        public Deck deck;
        public Hand hand;
        public Board board;
        public SpecialCard captain;

        public Player(int lifePoints, int attackPoints, Deck deck, Hand hand, Board board, SpecialCard captain)
        {
            this.lifePoints = lifePoints;
            this.attackPoints = attackPoints;
            this.deck = deck;
            this.hand = hand;
            this.board = board;
            this.captain = captain;
        }

        public void DrawCard()
        {

        }
        public void PlayCard()
        {

        }
        public void ChangeCard()
        {

        }
        public void FirstHand()
        {

        }
        public void ChooseCaptainCard()
        {

        }
    }
}
