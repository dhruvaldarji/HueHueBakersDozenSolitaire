using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HueHueBakersDozenSolitaire
{
  
    class Deck
    {
        Card[] cardArray;
        int currentEmptyLocation = 0;
        public Deck()
        {
            cardArray = new Card[52];

        }
        public void addCard(Card x)
        {
            cardArray[currentEmptyLocation] = x;
            currentEmptyLocation++;
        }
    }
}
